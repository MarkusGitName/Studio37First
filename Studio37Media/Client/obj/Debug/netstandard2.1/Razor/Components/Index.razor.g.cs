#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ddb708d8caf6e3ba3f79f51284092ad2f80d0e"
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
#line 4 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
           [Authorize]

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
            __builder.OpenComponent<Studio37Media.Client.Components.ClassVideoComponents.CreateClassVideoComponent>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
 if (CurrentUser == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<button href=\"/profile/create\">Please Create a profile for the full Studio 37 experience</button>\r\n");
#nullable restore
#line 27 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "hi");
            __builder.AddAttribute(9, "href", "/profile/create");
            __builder.AddContent(10, "Welcome ");
            __builder.AddContent(11, 
#nullable restore
#line 30 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
                                        CurrentUser.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 34 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
     if (CurrentProfesional != null)
    {
        
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
     if (posts == null)
    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.AddMarkupContent(14, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 43 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
    }
    else
    {
        foreach (Post post in posts)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "container col-3");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card my-2");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddMarkupContent(22, "<div class=\"embed-responsive mx-0 my-0 embed-responsive-16by9\">\r\n                    </div>\r\n                    ");
            __builder.AddMarkupContent(23, "<div>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-footer");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "small");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-muted");
            __builder.AddContent(30, 
#nullable restore
#line 55 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
                                                      post.Caption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, 
#nullable restore
#line 56 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
                            post.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "small");
            __builder.OpenElement(36, "p");
            __builder.AddAttribute(37, "class", "text-muted");
            __builder.AddContent(38, 
#nullable restore
#line 57 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
                                                      post.Caption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        <p></p>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 64 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\Index.razor"
      
    Profile CurrentUser = new Profile();
    ProfesionallsProfile CurrentProfesional = new ProfesionallsProfile();

    List<Post> posts = new List<Post>();


    protected override async Task OnInitializedAsync()
    {
        try
        {
            Console.WriteLine("Starts Try{}");

            //Load Current Users Profile
            CurrentUser = await Http.GetFromJsonAsync<Profile>("Profile/GetProfileById/0");
            

            
            Console.WriteLine("Successfull");
            
        }
        catch(Exception ex)
        {
            CurrentUser = null;
            Console.WriteLine("exception-----------"+ex.Message);
        }
        try
        {
            
            Console.WriteLine("Starts Try{}");
            //Load Current Users profesional Profile
            CurrentProfesional = await Http.GetFromJsonAsync<ProfesionallsProfile>("ProfessionalProfile/GetProfessionalProfileById/0");
            
            Console.WriteLine("Successfull");

        }
        catch(Exception ex)
        {
            CurrentProfesional = null;
            
            Console.WriteLine("exception-----------"+ex.Message);
        }

        try
        {
            posts = await Http.GetFromJsonAsync<List<Post>>("Post/GetPosts");

        }
        catch (Exception ex)
        {
            
            Console.WriteLine("exception-----------"+ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
