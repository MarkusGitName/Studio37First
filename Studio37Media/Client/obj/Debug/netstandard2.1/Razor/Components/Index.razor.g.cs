#pragma checksum "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5450483e55e7a5f1a836c5138a3c8a150696b36f"
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
#line 1 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\_Imports.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<Studio37Media.Client.Components.CattegoryComponents.CreateCategoryComponent>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n    <div height=\"50px\"></div>\r\n    ");
            __builder.OpenComponent<Studio37Media.Client.Components.ClassVideoComponents.CreateClassVideoComponent>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
#nullable restore
#line 18 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor"
 if (posts == null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 22 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor"
}
else
{
    foreach (Post post in posts)
    {

    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Components\Index.razor"
      
    List<Post> posts = new List<Post>();


    protected override async Task OnInitializedAsync()
    {
        try
        {
          //  posts = await Http.GetFromJsonAsync<List<Post>>("Post");

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
