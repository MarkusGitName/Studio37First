#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2041ff99dd78a727c3dc09471ba77e3322d1e395"
// <auto-generated/>
#pragma warning disable 1591
namespace Studio37Media.Client.Components
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
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateNewLiveShowComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
                      newLiveShow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
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
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "\r\n            <label for=\"f\" class=\"col-sm-1 col-form-label\"></label>\r\n            ");
                __builder2.AddMarkupContent(12, "<label for=\"f\" class=\"col-sm-1 col-form-label\">Title</label>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-5");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "f");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "placeholder", "Last Name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
                                        newLiveShow.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newLiveShow.Title = __value, newLiveShow.Title))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newLiveShow.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group row");
                __builder2.AddMarkupContent(28, "\r\n            <label for=\"f\" class=\"col-sm-1 col-form-label\"></label>\r\n            ");
                __builder2.AddMarkupContent(29, "<label for=\"f\" class=\"col-sm-1 col-form-label\">Description</label>\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-sm-5");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "f");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Last Name");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
                                        newLiveShow.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newLiveShow.Description = __value, newLiveShow.Description))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newLiveShow.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "\r\n            <label for=\"f\" class=\"col-sm-1 col-form-label\"></label>\r\n            ");
                __builder2.AddMarkupContent(46, "<label for=\"f\" class=\"col-sm-1 col-form-label\">Start Time</label>\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-sm-5");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __Blazor.Studio37Media.Client.Components.CreateNewLiveShowComponent.TypeInference.CreateInputDate_0(__builder2, 50, 51, "f", 52, "form-control", 53, "Last Name", 54, 
#nullable restore
#line 38 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
                                        newLiveShow.StartTime

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newLiveShow.StartTime = __value, newLiveShow.StartTime)), 56, () => newLiveShow.StartTime);
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "\r\n            <label for=\"f\" class=\"col-sm-1 col-form-label\"></label>\r\n            ");
                __builder2.AddMarkupContent(63, "<label for=\"f\" class=\"col-sm-1 col-form-label\">End Time</label>\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-5");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __Blazor.Studio37Media.Client.Components.CreateNewLiveShowComponent.TypeInference.CreateInputDate_1(__builder2, 67, 68, "f", 69, "form-control", 70, "Last Name", 71, 
#nullable restore
#line 46 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
                                        newLiveShow.EndTime

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newLiveShow.EndTime = __value, newLiveShow.EndTime)), 73, () => newLiveShow.EndTime);
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group row");
                __builder2.AddMarkupContent(79, "\r\n            <label for=\"f\" class=\"col-sm-1 col-form-label\"></label>\r\n            ");
                __builder2.AddMarkupContent(80, "<label for=\"f\" class=\"col-sm-1 col-form-label\">End Time</label>\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-sm-5");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __Blazor.Studio37Media.Client.Components.CreateNewLiveShowComponent.TypeInference.CreateInputNumber_2(__builder2, 84, 85, "f", 86, "form-control", 87, "Last Name", 88, 
#nullable restore
#line 54 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
                                        newLiveShow.PriceCredits

#line default
#line hidden
#nullable disable
                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newLiveShow.PriceCredits = __value, newLiveShow.PriceCredits)), 90, () => newLiveShow.PriceCredits);
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n   \r\n        ");
                __builder2.AddMarkupContent(94, "<button class=\"class=\" btn btn-primary\"\" type=\"submit\">Submit</button>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Kayla\Source\Repos\Studio37First_3\Studio37Media\Client\Components\CreateNewLiveShowComponent.razor"
       
    LiveShow newLiveShow = new LiveShow();

    //This runs on form submit
    async void HandleFormSubmit()
    {
        newLiveShow.id = Guid.NewGuid();

        
        await Http.PostAsJsonAsync<LiveShow>("LiveShow/NewLiveShow", newLiveShow);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Studio37Media.Client.Components.CreateNewLiveShowComponent
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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