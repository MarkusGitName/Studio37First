#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9b3f9eaaf5aebd29c279c1f7eb368c5abfd6fe"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.PhotoComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateNewPhotoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\PhotoComponents\CreateNewPhotoComponent.razor"
       
    [Parameter]
    public Guid PhotoId { get; set;}

    string PhotoUploadStats = "Select file...";

    // file contents declaration
    MultipartFormDataContent PhotoContent = new MultipartFormDataContent();

    Photo newPhoto = new Photo();

    //This runs on form submit
    async void HandleFormSubmit()
    {
        Console.WriteLine("form handle started");
        newPhoto.id = PhotoId;
        
        //post call to fileUploadConstructer (endpoint)
        await Http.PostAsync("FileUpload", PhotoContent);
        await Http.PostAsJsonAsync<Photo>("Photo/NewPhoto", newPhoto);
        
        Console.WriteLine("form handle ran");
    }
 

    // This runs on profile Photo file selection
    async Task PhotoSelection(IFileListEntry[] files)
    {
        
        Console.WriteLine("file selection started");
        var file = files.FirstOrDefault();
        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);

            PhotoUploadStats = $"Finished loading {file.Size} bytes from {file.Name}";

            PhotoContent = new MultipartFormDataContent {
                { new ByteArrayContent(ms.GetBuffer()), "uploads/PostPhotos", file.Name }
            };

            newPhoto.Path = "/uploads/PostPhotos/" + file.Name;
            

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
