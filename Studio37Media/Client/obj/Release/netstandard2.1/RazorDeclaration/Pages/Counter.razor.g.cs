#pragma checksum "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a80879a7f8e302e2b98e1ef6812b9f7c5e10ccb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Pages
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
#line 1 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Pages\Counter.razor"
using Studio37Media.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\AuctionProp\AuctionPortal\Studio37FirstCurrent\Studio37Media\Client\Pages\Counter.razor"
       
    private int currentCount = 0;
    public string msg = "";

    private void IncrementCount()
    {
        currentCount++;
        try
        {
            Profile p = new Profile();
                //APILibrary.APIGet<Profile>("7a868787y-02be-4ff-kuyf3-5ad71a98ebef", "profiles");
        }
        catch (Exception e)
        {
            msg = e.ToString();
            Console.WriteLine(e.Message.ToString());
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
