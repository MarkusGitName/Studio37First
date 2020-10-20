#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ece6f229e94c882054cbf3bc10b440606e8ceae9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Studio37Media.Client.Components.CattegoryComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\_Imports.razor"
using Studio37Media.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
    public partial class SellectCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Kayla\Source\Repos\Studio37First4\Studio37Media\Client\Components\CattegoryComponents\SellectCategoryComponent.razor"
       
    List<Category> CategoryList = new List<Category>();


    //This code runs on component load
    protected override async Task OnInitializedAsync()
    {
        CategoryList = await Http.GetFromJsonAsync<List<Category>>("Cattegory/NewCategory");
    }

    [Parameter]
    public Guid postId { get; set; }
    PostCattegory newPostCattegory = new PostCattegory();
    Category sellectedCategory = new Category();

    //This runs on form submit
    async void HandleFormSubmit() {

        newPostCattegory.PostID = postId;
        newPostCattegory.CategoryID = sellectedCategory.id.ToString();

        
        await Http.PostAsJsonAsync<PostCattegory>("Cattegory/NewPostCategory", newPostCattegory);


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
