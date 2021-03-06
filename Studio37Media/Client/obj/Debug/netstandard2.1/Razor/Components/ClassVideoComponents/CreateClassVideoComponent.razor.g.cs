#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ad2a52bf0946557a7e17bc19e9643512cbc89d"
// <auto-generated/>
#pragma warning disable 1591
namespace Studio37Media.Client.Components.ClassVideoComponents
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
#line 3 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TutorialClass/create")]
    public partial class CreateClassVideoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"conatiner col-4 py-3 mx-auto\">\r\n    <button class=\"btn btn-block font-weight-bold text-muted\" data-toggle=\"modal\" data-target=\"#selectVideoFile\">\r\n        <span class=\"oi oi-plus\"></span>\r\n        Select Video\r\n    </button>\r\n</div>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                  newClassVideo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                 HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row col-11");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "container");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group col-8 mx-auto");
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "VideoTitle");
                __builder2.AddAttribute(21, "class", "form-control my-2");
                __builder2.AddAttribute(22, "placeholder", "Video Title");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                        newClassVideo.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newClassVideo.Title = __value, newClassVideo.Title))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newClassVideo.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(27);
                __builder2.AddAttribute(28, "id", "VideoDescription");
                __builder2.AddAttribute(29, "class", "form-control my-2");
                __builder2.AddAttribute(30, "rows", "5");
                __builder2.AddAttribute(31, "placeholder", "Video Description");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                            newClassVideo.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newClassVideo.Description = __value, newClassVideo.Description))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newClassVideo.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __Blazor.Studio37Media.Client.Components.ClassVideoComponents.CreateClassVideoComponent.TypeInference.CreateInputNumber_0(__builder2, 36, 37, "VideoCredits", 38, "form-control my-2", 39, "Credits", 40, 
#nullable restore
#line 32 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                          newClassVideo.PriceCredits

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newClassVideo.PriceCredits = __value, newClassVideo.PriceCredits)), 42, () => newClassVideo.PriceCredits);
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "custom-file my-2");
                __builder2.AddAttribute(46, "id", "customFile4");
                __builder2.AddAttribute(47, "lang", "es");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(49);
                __builder2.AddAttribute(50, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 34 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                         ThumbnailSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(51, "type", "file");
                __builder2.AddAttribute(52, "class", "custom-file-input");
                __builder2.AddAttribute(53, "id", "thumbnailImage");
                __builder2.AddAttribute(54, "aria-describedby", "fileHelp");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.AddMarkupContent(56, "<label class=\"custom-file-label\" for=\"thumbnailImage\">\r\n                        Upload Thumbnail...\r\n                    </label>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n              \r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.AddMarkupContent(59, "<button type=\"submit\" class=\"btn btn-light btn-block\">Save Changes</button>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "container col-3");
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "card my-2");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "embed-responsive mx-0 my-0 embed-responsive-16by9");
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.OpenElement(70, "video");
                __builder2.AddAttribute(71, "src", 
#nullable restore
#line 49 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                 newClassVideo.VideoPath

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(72, "controls", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "card-footer");
                __builder2.AddMarkupContent(77, "\r\n                    ");
                __builder2.OpenElement(78, "small");
                __builder2.OpenElement(79, "p");
                __builder2.AddAttribute(80, "class", "text-muted");
                __builder2.AddContent(81, 
#nullable restore
#line 52 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                  newClassVideo.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.OpenElement(83, "p");
                __builder2.AddContent(84, 
#nullable restore
#line 53 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                        newClassVideo.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.OpenElement(86, "small");
                __builder2.OpenElement(87, "p");
                __builder2.AddAttribute(88, "class", "text-muted");
                __builder2.AddContent(89, 
#nullable restore
#line 54 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                  VideoUploudStats

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.OpenElement(91, "p");
                __builder2.AddContent(92, 
#nullable restore
#line 55 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                        newClassVideo.VideoPath

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "modal");
                __builder2.AddAttribute(100, "id", "selectVideoFile");
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "modal-dialog modal-dialog-centered");
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "modal-content");
                __builder2.AddMarkupContent(107, "\r\n                ");
                __builder2.AddMarkupContent(108, "<div class=\"modal-header\">\r\n                    <h4 class=\"modal-title\">Upload Video</h4>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n                </div>\r\n                ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "modal-body");
                __builder2.AddMarkupContent(111, "\r\n                    ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group");
                __builder2.AddMarkupContent(114, "\r\n                        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "custom-file my-2");
                __builder2.AddAttribute(117, "id", "customFile");
                __builder2.AddAttribute(118, "lang", "es");
                __builder2.AddMarkupContent(119, "\r\n                            ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(120);
                __builder2.AddAttribute(121, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 72 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                 VideoSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(122, "type", "file");
                __builder2.AddAttribute(123, "class", "custom-file-input");
                __builder2.AddAttribute(124, "id", "photoPost");
                __builder2.AddAttribute(125, "aria-describedby", "fileHelp");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n\r\n                            if(");
                __builder2.AddContent(127, 
#nullable restore
#line 74 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                VideoUploudStats

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(128, " != null)\r\n                            {\r\n                        ");
                __builder2.OpenElement(129, "label");
                __builder2.AddAttribute(130, "class", "custom-file-label");
                __builder2.AddAttribute(131, "for", "photoPost");
                __builder2.AddContent(132, 
#nullable restore
#line 76 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                                          VideoUploudStats

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n\r\n                            }\r\n                            else{\r\n\r\n                            ");
                __builder2.AddMarkupContent(134, "<label class=\"custom-file-label\" for=\"photoPost\">\r\n                                Select file...\r\n                            </label>\r\n                                }\r\n\r\n                           \r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                    ");
                __builder2.AddMarkupContent(137, "<button type=\"submit\" class=\"btn btn-light btn-block\" data-dismiss=\"modal\">Upload</button>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
       

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
        newClassVideo.id = Guid.NewGuid();
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
namespace __Blazor.Studio37Media.Client.Components.ClassVideoComponents.CreateClassVideoComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
