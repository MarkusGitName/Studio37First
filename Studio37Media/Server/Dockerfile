#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Studio37Media/Server/Studio37Media.Server.csproj", "Studio37Media/Server/"]
COPY ["Studio37Media/Shared/Studio37Media.Shared.csproj", "Studio37Media/Shared/"]
COPY ["Studio37Media/Client/Studio37Media.Client.csproj", "Studio37Media/Client/"]
RUN dotnet restore "Studio37Media/Server/Studio37Media.Server.csproj"
COPY . .
WORKDIR "/src/Studio37Media/Server"
RUN dotnet build "Studio37Media.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Studio37Media.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Studio37Media.Server.dll"]