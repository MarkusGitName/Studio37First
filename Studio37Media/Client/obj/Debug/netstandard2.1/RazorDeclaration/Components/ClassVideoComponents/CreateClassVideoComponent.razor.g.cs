#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8a432fe59273a7e32412f761ae69a1b7ea1987"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.ClassVideoComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateClassVideoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
       

    string VideoUploudStats;
    string ThumbnailUploudStats;

    ClassVideo newClassVideo = new ClassVideo();


    // file contents declaration
    MultipartFormDataContent classVideoContent = new MultipartFormDataContent();
    MultipartFormDataContent ThumbnailContent = new MultipartFormDataContent();

    //This runs on form submit
    async void HandleFormSubmit()
    {
        
            // upload photos
            await Http.PostAsync("FileUpload", classVideoContent);
            await Http.PostAsync("FileUpload", classVideoContent);

        Console.WriteLine("Runs--------------------------------------------");
        newClassVideo.DateAdded = DateTime.Now;
        await Http.PostAsJsonAsync<ClassVideo>("ClassVideo/NewClassVideo", newClassVideo);
    }



    // This runs on profile Photo file selection
    async Task VideoSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);

            VideoUploudStats = $"Finished loading {file.Size} bytes from {file.Name}";

            classVideoContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/ClassVideos", file.Name }
                };

            newClassVideo.VideoPath = "/uploads/ClassVideos/" + file.Name;

        }

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

            ThumbnailUploudStats = $"Finished loading {file.Size} bytes from {file.Name}";

            ThumbnailContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/Thumbnails", file.Name }
                };

            newClassVideo.VideoThumbnail = "/uploads/Thumbnails/" + file.Name;

        }

    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
