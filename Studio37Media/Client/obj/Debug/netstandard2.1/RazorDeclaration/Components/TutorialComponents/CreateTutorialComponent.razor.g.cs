#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f978b782afc67c3111d5c37763ac3e6bc7d85be4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.TutorialComponents
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
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tutorial/CreateTutorial")]
    public partial class CreateTutorialComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
           
        //Decleration of lists that display files upload status. To be removed or adjusted for users
        List<string> ListOfPromoVideosStat = new List<string>();
        List<string> ListOfPromoPhotosStats = new List<string>();

        // decleration of stats added to status lists
        string PromoVideoStats;
        string PromoPhotoStats;

        //decleration of new Tutorial object
        Tutorial newTutorial = new Tutorial();

        // List Declerations to be added to the new tutorial object
        List<TutorialPromoPhoto> ListOfTutorialPromoPhotos = new List<TutorialPromoPhoto>();
        List<TutorialPromoVideo> ListOfTutorialPromoVideos = new List<TutorialPromoVideo>();

        //decleration of actual files to be uploaded
        MultipartFormDataContent TutorialPromoVideoContent = new MultipartFormDataContent();
        MultipartFormDataContent TutorialPromoPhotoContent = new MultipartFormDataContent();

 
        // runs on pagte load
        protected override async Task OnInitializedAsync()
        {
            newTutorial.id = Guid.NewGuid();
        }

        // runs on form submit
        async void HandleFormSubmit()
        {
            
           //debuging
           Console.WriteLine("Videos added");
            //Add Videos
            newTutorial.TutorialPromoVideos = ListOfTutorialPromoVideos;
            
            Console.WriteLine("Videos added");
            //Fhotos Added
            newTutorial.TutorialPromoPhotoes = ListOfTutorialPromoPhotos;

            // post to TutorialController
            await Http.PostAsJsonAsync<Tutorial>("Tutorial/PostTutorial", newTutorial);

        }

        // runs on video file sellection
        async Task PromoVideoSelection(IFileListEntry[] files)
        {
            //incoming file
            var file = files.FirstOrDefault();
            if (file != null)
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);

                TutorialPromoVideoContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/TutorialPromoVideo", file.Name }
                };
                
                //post call to fileUploadConstructer (endpoint)
                await client.PostAsync("FileUpload", TutorialPromoVideoContent);
                
                //display file upload stats
                PromoVideoStats = $"Finished loading {file.Size} bytes from {file.Name}";
                ListOfPromoVideosStat.Add(PromoVideoStats);

                //debugging
                Console.WriteLine("file upload complete");

                //decleration of new TutorialPromoVideo
                TutorialPromoVideo newTutorialPromoVideo = new TutorialPromoVideo();
                
                //setting new ID
                newTutorialPromoVideo.id = Guid.NewGuid();

                //decleratio of new promovideo
                PromoVideo newPromoVideo = new PromoVideo();
                newPromoVideo.id = Guid.NewGuid();
                newPromoVideo.VideoPath = "/uploads/TutorialPromoVideo/" + file.Name;

                
                //setting promovdeo value
                newTutorialPromoVideo.PromoVideo = newPromoVideo;


                // add new TutorialPromoVideo to Glabal List
                ListOfTutorialPromoVideos.Add(newTutorialPromoVideo);

                //debuging
                Console.WriteLine("photo added to list- "+ newTutorialPromoVideo);
            }

        }

        
        // runs on Photo file sellection
        async Task PromoPhotoSellection(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();

            if (file != null)
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);

                TutorialPromoPhotoContent = new MultipartFormDataContent {
                    { new ByteArrayContent(ms.GetBuffer()), "uploads/TutorialPromoPhoto", file.Name }
                };

                
                //post call to fileUploadConstructer (endpoint)
                await client.PostAsync("FileUpload", TutorialPromoPhotoContent);

                
                //display file upload stats
                PromoPhotoStats = $"Finished loading {file.Size} bytes from {file.Name}";
                ListOfPromoPhotosStats.Add(PromoPhotoStats);


                //decleration of new TutorialPromoPhoto
                TutorialPromoPhoto newTutorialPromoPhoto = new TutorialPromoPhoto();

                //set id value
                newTutorialPromoPhoto.id =Guid.NewGuid();
                
                //decleratio of new newTutorialPromoPhoto
                PromoPhoto newPromoPhoto = new PromoPhoto();
                newPromoPhoto.id = Guid.NewGuid();
                newPromoPhoto.PhotoPath = "/uploads/TutorialPromoPhoto/" + file.Name;

                //Setitng new newTutorialPromoPhoto
                newTutorialPromoPhoto.PromoPhoto = newPromoPhoto;


                // add newTutorialPromoPhoto to glabal list
                ListOfTutorialPromoPhotos.Add(newTutorialPromoPhoto);
                
                //debugging
                Console.WriteLine("photo added to list- "+ newTutorialPromoPhoto);
            }

        }



    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
