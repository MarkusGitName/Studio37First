#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dbd16f440814f8fe99ccbecf7f0cd199656f9ac"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.PostComponents
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
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreatePostComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\PostComponents\CreatePostComponent.razor"
       

    //Decleration of lists that display files upload status. To be removed or adjusted for users
    List<string> ListOfPostVideosStats = new List<string>();
    List<string> ListOfPostPhotosStats = new List<string>();

    // decleration of stats added to status lists
    string PostPhotoStats;
    string PostVideoStats;


    //decleration of new Tutorial object
    Post newPost = new Post();

    // List Declerations to be added to the new tutorial object
    List<PostPhoto> ListOfPostPhotos = new List<PostPhoto>();
    List<PostVideo> ListOfPostVideos = new List<PostVideo>();

    //decleration of actual files to be uploaded
    MultipartFormDataContent PostPhotoContent = new MultipartFormDataContent();
    MultipartFormDataContent PostVideoContent = new MultipartFormDataContent();

    //This code runs on component load
    protected override async Task OnInitializedAsync()
    {
        newPost.id = Guid.NewGuid();
        

   
        Console.WriteLine("createPost component Load Started");
    
    }

    //This runs on form submit
    async void HandleFormSubmit()
    {
        //debuging
        Console.WriteLine("Videos added");
        //Add Videos
        newPost.PostVideos = ListOfPostVideos;

        Console.WriteLine("Videos added");
        //Fhotos Added
        newPost.PostPhotos = ListOfPostPhotos;

        // post to TutorialController
        newPost.Date = DateTime.Now;
        await Http.PostAsJsonAsync<Post>("Post/NewPost", newPost);
    }


    // runs on video file sellection
    async Task PostPhotoSelection(IFileListEntry[] files)
    {
        //incoming file
        var file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);

            PostPhotoContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/PostPhotos", file.Name }
                };

            //post call to fileUploadConstructer (endpoint)
            await Http.PostAsync("FileUpload", PostPhotoContent);

            //display file upload stats
            PostPhotoStats = $"Finished loading {file.Size} bytes from {file.Name}";
            ListOfPostVideosStats.Add(PostPhotoStats);

            //debugging
            Console.WriteLine("file upload complete");

            //decleration of new Post
            PostPhoto newPostPhoto = new PostPhoto();

            //setting new ID
            newPostPhoto.id = Guid.NewGuid();

            //decleratio of new Post
            Photo newPhoto = new Photo();
            newPhoto.id = Guid.NewGuid();
            newPhoto.Path = "/uploads/PostPhotos/" + file.Name;


            //setting Photo value
            newPostPhoto.Photo = newPhoto;


            // add new TutorialPost to Glabal List
            ListOfPostPhotos.Add(newPostPhoto);

            //debuging
            Console.WriteLine("photo added to list- " + newPostPhoto);
        }
    }

    // runs on video file sellection
    async Task PostVideoSelection(IFileListEntry[] files)
    {
        //incoming file
        var file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);

            PostVideoContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/PostVideo", file.Name }
                };

            //post call to fileUploadConstructer (endpoint)
            await Http.PostAsync("FileUpload", PostVideoContent);

            //display file upload stats
            PostVideoStats = $"Finished loading {file.Size} bytes from {file.Name}";
            ListOfPostVideosStats.Add(PostVideoStats);

            //debugging
            Console.WriteLine("file upload complete");

            //decleration of new Post
            PostVideo newPostVideo = new PostVideo();

            //setting new ID
            newPostVideo.id = Guid.NewGuid();

            //decleratio of new Post
            Video newVideo = new Video();
            newVideo.id = Guid.NewGuid();
            newVideo.Path = "/uploads/PostVideo/" + file.Name;


            //setting Video value
            newPostVideo.Video = newVideo;


            // add new PostVide to Glabal List
            ListOfPostVideos.Add(newPostVideo);

            //debuging
            Console.WriteLine("Video added to list- " + newPostVideo);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
