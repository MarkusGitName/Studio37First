#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\TempStylingComponents\Pages\UserVideos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8acac0398a70468370f56ac0a4f0159d64352ce"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/videos")]
    public partial class UserVideos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Studio37Media.Client.TempStylingComponents.Pages.TopNavBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container col-10");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-hover");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Video</th>\r\n                <th>Date</th>\r\n                <th>Status</th>\r\n                <th>Sales</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.OpenComponent<Studio37Media.Client.TempStylingComponents.Pages.UserVideoListCard>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.AddMarkupContent(16, "<td>01/09/2020</td>\r\n                ");
            __builder.AddMarkupContent(17, "<td>Public</td>\r\n                ");
            __builder.AddMarkupContent(18, "<td>123</td>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.OpenComponent<Studio37Media.Client.TempStylingComponents.Pages.UserVideoListCard>(23);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.AddMarkupContent(25, "<td>20/08/2020</td>\r\n                ");
            __builder.AddMarkupContent(26, "<td>Private</td>\r\n                ");
            __builder.AddMarkupContent(27, "<td>100</td>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenComponent<Studio37Media.Client.TempStylingComponents.Pages.UserVideoListCard>(32);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<td>10/08/2020</td>\r\n                ");
            __builder.AddMarkupContent(35, "<td>Public</td>\r\n                ");
            __builder.AddMarkupContent(36, "<td>200</td>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenComponent<Studio37Media.Client.TempStylingComponents.Pages.Footer>(41);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
