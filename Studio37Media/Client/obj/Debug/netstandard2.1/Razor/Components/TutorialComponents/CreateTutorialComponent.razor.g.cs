#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f978b782afc67c3111d5c37763ac3e6bc7d85be4"
// <auto-generated/>
#pragma warning disable 1591
namespace Studio37Media.Client.Components.TutorialComponents
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
#line 3 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
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
            __builder.AddMarkupContent(0, "<h1>Create Profile</h1>\r\n<hr>\r\n\r\n");
#nullable restore
#line 17 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
 try
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                      newTutorial

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                                                   HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group row");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, "<label for=\"FirstName\" class=\"col-sm-1 col-form-label\">Tutorial Title</label>\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-sm-5");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "FirstName");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "First Name");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                                        newTutorial.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTutorial.Title = __value, newTutorial.Title))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTutorial.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.AddMarkupContent(31, "<label for=\"LastName\" class=\"col-sm-1 col-form-label\">Describsion </label>\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-sm-5");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(35);
                __builder2.AddAttribute(36, "id", "LastName");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "placeholder", "Last Name");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                                            newTutorial.Desctription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTutorial.Desctription = __value, newTutorial.Desctription))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTutorial.Desctription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group  row");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.AddMarkupContent(48, "<label for=\"DateOfBirth\" class=\"col-sm-1 col-form-label\">Price in credits</label>\r\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-sm-5");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __Blazor.Studio37Media.Client.Components.TutorialComponents.CreateTutorialComponent.TypeInference.CreateInputNumber_0(__builder2, 52, 53, "DateOfBirth", 54, "form-control", 55, "0", 56, 
#nullable restore
#line 43 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                                          newTutorial.PriceCredits

#line default
#line hidden
#nullable disable
                , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTutorial.PriceCredits = __value, newTutorial.PriceCredits)), 58, () => newTutorial.PriceCredits);
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n\r\n\r\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group row");
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.AddMarkupContent(65, "<label for=\"ProfilePhoto\" class=\"col-sm-1 col-form-label\">Promo Videos</label>\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-sm-5");
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(69);
                __builder2.AddAttribute(70, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 52 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                                     PromoVideoSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n");
#nullable restore
#line 54 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
             foreach (string filestat in ListOfPromoVideosStat)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(73, "                ");
                __builder2.OpenElement(74, "p");
                __builder2.AddContent(75, 
#nullable restore
#line 56 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                    filestat

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n");
#nullable restore
#line 57 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(77, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n\r\n\r\n\r\n\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group row");
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.AddMarkupContent(82, "<label for=\"WallPhoto\" class=\"col-sm-1 col-form-label\">Promo Photos</label>\r\n            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "col-sm-5");
                __builder2.AddMarkupContent(85, "\r\n\r\n                ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(86);
                __builder2.AddAttribute(87, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 67 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                                     PromoPhotoSellection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n");
#nullable restore
#line 69 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
             foreach (string filestat in ListOfPromoPhotosStats)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(90, "                ");
                __builder2.OpenElement(91, "p");
                __builder2.AddContent(92, 
#nullable restore
#line 71 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                    filestat

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n");
#nullable restore
#line 72 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(94, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n        ");
                __builder2.AddMarkupContent(96, "<button class=\"class=\" btn btn-primary\"\" type=\"submit\">Submit</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 223 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
     
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "    ");
            __builder.OpenElement(99, "label");
            __builder.AddAttribute(100, "for", "firstName");
            __builder.AddContent(101, 
#nullable restore
#line 228 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
                            e.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 229 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\TutorialComponents\CreateTutorialComponent.razor"
           
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
namespace __Blazor.Studio37Media.Client.Components.TutorialComponents.CreateTutorialComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "min", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
