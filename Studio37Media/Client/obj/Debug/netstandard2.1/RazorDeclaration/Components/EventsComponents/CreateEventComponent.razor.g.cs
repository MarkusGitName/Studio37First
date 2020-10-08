#pragma checksum "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f7ae8b0fa02f4055049c7f2c2bc78194db9b10"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.EventsComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateEventComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
        
    Event newEvent = new Event();

     string ThumbnailStatsStats;


     
        // file contents declaration
        MultipartFormDataContent ThumbnailContent = new MultipartFormDataContent();

     async void HandleFormSubmit()
     {
         
            // upload photos
            await Http.PostAsync("FileUpload", ThumbnailContent);
         
            await Http.PostAsJsonAsync<Event>("Event/NewEvent", newEvent);
     }

             // This runs on profile Photo file selection
        async Task ThumbnailSelection(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file != null)
            {
                // Just load into .NET memory to show it can be done
                // Alternatively it could be saved to disk, or parsed in memory, or similar
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);

                ThumbnailStatsStats = $"Finished loading {file.Size} bytes from {file.Name}";

                ThumbnailContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/EventThumbnail", file.Name }
                };

                newEvent.EventThumbnail = "/uploads/EventThumbnail/" + file.Name;

            }

        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
