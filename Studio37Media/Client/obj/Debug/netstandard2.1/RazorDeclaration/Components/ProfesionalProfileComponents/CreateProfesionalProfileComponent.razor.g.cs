#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707907d230fbae743f2ebace70056c6c0044dfd9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.ProfesionalProfileComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProfesionalProfileComponents/CreateProfProfile")]
    public partial class CreateProfesionalProfileComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfesionalProfileComponents\CreateProfesionalProfileComponent.razor"
       

    ProfesionallsProfile newProfesionalprofile = new ProfesionallsProfile();
    string LogoUploadStatus;


    MultipartFormDataContent LogoContex = new MultipartFormDataContent();

    async void HandleFormSubmit()
    {
        await Http.PostAsync("FileUpload", LogoContex);
        await Http.PostAsJsonAsync<ProfesionallsProfile>("ProfesionalProfile/GetProfesionalById/0", newProfesionalprofile);
  


    }
    async Task LogoSellection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        LogoUploadStatus = $"Finished loading {file.Size} bytes from {file.Name}";

        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);

            LogoContex = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/Logos", file.Name }
                };

            newProfesionalprofile.Logo = "/uploads/Logos/" + file.Name;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
