#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d6122be1e3f2135b716e2cd444ff37da83fe994"
// <auto-generated/>
#pragma warning disable 1591
namespace Studio37Media.Client.Components.EventsComponents
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
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateEventComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                      newEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                                                HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<label for=\"f\" class=\"col-sm-1 col-form-label\">Event</label>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-5");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "f");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "First Name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                                        newEvent.EventName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newEvent.EventName = __value, newEvent.EventName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newEvent.EventName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group row");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label for=\"f\" class=\"col-sm-1 col-form-label\">sup category</label>\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-sm-5");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "f");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Last Name");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                                        newEvent.EventDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newEvent.EventDescription = __value, newEvent.EventDescription))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newEvent.EventDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.AddMarkupContent(46, "<label for=\"f\" class=\"col-sm-1 col-form-label\">Pick date</label>\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-sm-5");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __Blazor.Studio37Media.Client.Components.EventsComponents.CreateEventComponent.TypeInference.CreateInputDate_0(__builder2, 50, 51, "f", 52, "form-control", 53, "Last Name", 54, 
#nullable restore
#line 37 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                                        newEvent.EventDate

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newEvent.EventDate = __value, newEvent.EventDate)), 56, () => newEvent.EventDate);
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.AddMarkupContent(63, "<label for=\"ProfilePhoto\" class=\"col-sm-1 col-form-label\">Profile Photo</label>\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-5");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(67);
                __builder2.AddAttribute(68, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 43 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                                     ThumbnailSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenElement(71, "p");
                __builder2.AddContent(72, 
#nullable restore
#line 45 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
                ThumbnailStatsStats

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n        ");
                __builder2.AddMarkupContent(75, "<button class=\"class=\" btn btn-primary\"\" type=\"submit\">Submit</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\EventsComponents\CreateEventComponent.razor"
        
     Event newEvent = new Event();

     string ThumbnailStatsStats;



     // file contents declaration
     MultipartFormDataContent ThumbnailContent = new MultipartFormDataContent();

     async void HandleFormSubmit()
     {

         // upload photos
         await Http.PostAsync("FileUpload", ThumbnailContent);

         newEvent.id = Guid.NewGuid();
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
namespace __Blazor.Studio37Media.Client.Components.EventsComponents.CreateEventComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
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
