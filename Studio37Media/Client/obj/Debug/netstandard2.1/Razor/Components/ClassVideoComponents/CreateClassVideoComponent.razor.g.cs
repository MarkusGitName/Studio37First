#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d727bf2b58c29867b86ed1b8d795b73cdba484d1"
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
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateClassVideoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                  newClassVideo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                 HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.AddMarkupContent(9, @"<div class=""conatiner col-4 py-3 mx-auto"">
        <button class=""btn btn-block font-weight-bold text-muted"" data-toggle=""modal"" data-target=""#selectVideoFile"">
            <span class=""oi oi-plus""></span>
            Select Video
        </button>
    </div>

    ");
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
#line 27 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
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
#line 29 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
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
#line 31 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                          newClassVideo.PriceCredits

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newClassVideo.PriceCredits = __value, newClassVideo.PriceCredits)), 42, () => newClassVideo.PriceCredits);
                __builder2.AddMarkupContent(43, "\r\n                <textarea class=\"form-control my-2\" rows=\"3\" id=\"tags\" placeholder=\"tags\"></textarea>\r\n\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "custom-file my-2");
                __builder2.AddAttribute(46, "id", "customFile4");
                __builder2.AddAttribute(47, "lang", "es");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(49);
                __builder2.AddAttribute(50, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 35 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                         VideoSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(51, "type", "file");
                __builder2.AddAttribute(52, "class", "custom-file-input");
                __builder2.AddAttribute(53, "id", "thumbnailImage");
                __builder2.AddAttribute(54, "aria-describedby", "fileHelp");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.AddMarkupContent(56, "<label class=\"custom-file-label\" for=\"thumbnailImage\">\r\n                            Upload Thumbnail...\r\n                        </label>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-control my-2");
                __builder2.AddAttribute(60, "placeholder", "Video");
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(62);
                __builder2.AddAttribute(63, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 41 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                         VideoSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-control my-2");
                __builder2.AddAttribute(68, "placeholder", "Video");
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(70);
                __builder2.AddAttribute(71, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 44 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                         ThumbnailSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\" class=\"btn btn-light btn-block\">Save Changes</button>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "container col-3");
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "card my-2");
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "embed-responsive mx-0 my-0 embed-responsive-16by9");
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.OpenElement(86, "video");
                __builder2.AddAttribute(87, "src", 
#nullable restore
#line 54 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                 newClassVideo.VideoPath

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(88, "controls", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "card-footer");
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.OpenElement(94, "small");
                __builder2.OpenElement(95, "p");
                __builder2.AddAttribute(96, "class", "text-muted");
                __builder2.AddContent(97, 
#nullable restore
#line 57 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                  newClassVideo.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenElement(99, "p");
                __builder2.AddContent(100, 
#nullable restore
#line 58 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                        newClassVideo.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                    ");
                __builder2.OpenElement(102, "small");
                __builder2.OpenElement(103, "p");
                __builder2.AddAttribute(104, "class", "text-muted");
                __builder2.AddContent(105, 
#nullable restore
#line 59 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                                                  VideoUploudStats

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.OpenElement(107, "p");
                __builder2.AddContent(108, 
#nullable restore
#line 60 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
                        newClassVideo.VideoPath

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\r\n   \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ClassVideoComponents\CreateClassVideoComponent.razor"
       

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
