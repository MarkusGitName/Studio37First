#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27eca0c490d90b9242497f837d2bb6ed0b6c4afc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.ProfileComponents
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
#nullable restore
#line 2 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class ProfileViewComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
       
    private Profile[] profiles;

    public string view = "TimeLine";


    protected override async Task OnInitializedAsync()
    {
        try
        {
            //profiles = await Http.GetFromJsonAsync<Profile[]>("");
            //await Http.PostAsJsonAsync();
            //<Profile>("Profile");
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
