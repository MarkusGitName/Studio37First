#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\TempStylingComponents\Pages\Post.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f70caf965fd52b67b219f3e9f06931174ab0e2f"
// <auto-generated/>
#pragma warning disable 1591
namespace Studio37Media.Client.TempStylingComponents.Pages
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
#line 12 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\WorkingVersionsRepo\Studio37Media\Client\_Imports.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
    public partial class Post : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card my-4 col-7 container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div class=""card-header bg-transparent border-bottom-0"">
        <div class=""media"">
            <img class=""rounded-circle mr-3"" style=""max-width: 64px; height: 64px;"" src=""300px-Leonardo_DiCaprio_Laughing.jpg"" alt=""Avatar"">
            <div class=""my-3""><h5>Username</h5></div>

        </div>
    </div>
    ");
            __builder.AddMarkupContent(4, "<div class=\"card-body\">\r\n        <img src=\"free.jpg\" alt=\"unable to load\" class=\"card-img-top\">\r\n\r\n    </div>\r\n    ");
            __builder.AddMarkupContent(5, @"<div class=""card-footer bg-transparent border-top-0"">
        <button class=""btn"" href=""#"">
            <i class=""far fa-heart fa-2x""></i>
        </button>
        <button class=""btn"" data-toggle=""collapse"" data-target=""#demo"" href=""#"">
            <i class=""far fa-comment fa-2x""></i>
        </button>
        <button class=""btn"" href=""#"">
            <i class=""fas fa-share-alt fa-2x""></i>
        </button>
        <div class=""container-fluid"">
            <h6>likes</h6>
            <h5 class=""card-text my-2"">This is the Caption of this image</h5>
            <small><i>Posted on...</i></small>
        </div>
        <p><a class=""nav-link text-dark"" data-toggle=""collapse"" href=""#demo"">View all Comments</a></p>
       
    </div>
    
    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "demo");
            __builder.AddAttribute(8, "class", "collapse");
            __builder.AddMarkupContent(9, "\r\n        <hr>\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container-fluid");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<Studio37Media.Client.TempStylingComponents.Pages.Comment>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        <hr>\r\n        ");
            __builder.AddMarkupContent(16, @"<div class=""form-group form-inline my-3"">
            <img class=""rounded-circle mr-3"" style=""max-width: 64px;"" src=""300px-Leonardo_DiCaprio_Laughing.jpg"" alt=""Avatar"">
            <input type=""text"" class=""form-control col-11"" id=""comment"" placeholder=""write a comment..."">
        </div>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
