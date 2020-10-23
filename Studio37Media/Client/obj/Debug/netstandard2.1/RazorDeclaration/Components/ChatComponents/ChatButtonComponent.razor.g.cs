#pragma checksum "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\Components\ChatComponents\ChatButtonComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ed5fa1efdd358960e0920d41aa11e88a61f1b9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.ChatComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\Components\ChatComponents\ChatButtonComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class ChatButtonComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Kayla\source\repos\Studio37First_5\Studio37Media\Client\Components\ChatComponents\ChatButtonComponent.razor"
       
    Chat newChat = new Chat();

    //This code runs on component load
    protected override async Task OnInitializedAsync()
    {
        newChat.ChatID = Guid.NewGuid();
        newChat.DateCreated = DateTime.Now;


        //post to profile controller
        await Http.PostAsJsonAsync<Chat>("chat/NewChat", newChat);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
