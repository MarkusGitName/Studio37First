#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2c50e8b4c42de40f8946773d1574e222df890c"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid my-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 10 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
         if (profile == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.AddMarkupContent(7, "<p>\r\n                Loading...\r\n            </p>\r\n");
#nullable restore
#line 15 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
        }
        else
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "clearfix col-4");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 20 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                 try
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                    ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 22 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                               profile.ProfilePhoto

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-fluid rounded-circle px-4 float-right");
            __builder.AddAttribute(16, "alt", "Haha");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 23 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                }
                catch { }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-4");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "h2");
            __builder.AddMarkupContent(27, "<a class=\"nav-link text-dark px-5 pt-5 pb-3\" href=\"#\">followers</a>");
            __builder.AddContent(28, 
#nullable restore
#line 28 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                                                                                            profile.Profiles.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "h2");
            __builder.AddMarkupContent(31, "<a class=\"nav-link text-dark px-5 pt-5 pb-3\" href=\"#\">following</a>");
            __builder.AddContent(32, 
#nullable restore
#line 29 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                                                                                            profile.Profile1.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "h4");
            __builder.AddAttribute(36, "class", "pl-5");
            __builder.AddContent(37, 
#nullable restore
#line 31 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                                  profile.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " ");
            __builder.AddContent(39, 
#nullable restore
#line 31 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                                                     profile.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "h6");
            __builder.AddAttribute(42, "class", "pl-5");
            __builder.AddContent(43, 
#nullable restore
#line 32 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                                  profile.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "h6");
            __builder.AddAttribute(47, "class", "pl-5");
            __builder.AddContent(48, 
#nullable restore
#line 33 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
                                  profile.Website

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.AddMarkupContent(51, "<div class=\"clearfix col-4\">\r\n                <button class=\"btn btn-outline-secondary mx-5 my-5 w-25\" href=\"#\">Edit Profile</button>\r\n            </div>\r\n");
#nullable restore
#line 39 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(55, "<div class=\"container-fluid py-4\">\r\n    <button class=\"btn btn-block btn-outline-danger \">Follow</button>\r\n</div>\r\n<div class=\"dropdown-divider\"></div>\r\n\r\n\r\n");
            __builder.OpenComponent<Studio37Media.Client.Components.ProfileComponents.TabControl>(56);
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.OpenComponent<Studio37Media.Client.Components.ProfileComponents.TabPage>(59);
                __builder2.AddAttribute(60, "Text", "Timeline");
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(62, "\r\n        ");
                    __builder3.OpenComponent<Studio37Media.Client.Components.ProfileComponents.ProfileTimelineComponent>(63);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.OpenComponent<Studio37Media.Client.Components.ProfileComponents.TabPage>(66);
                __builder2.AddAttribute(67, "Text", "Tutorials");
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(69, "\r\n        ");
                    __builder3.OpenComponent<Studio37Media.Client.Components.ProfileComponents.ProfileTutorialsComponent>(70);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n    ");
                __builder2.OpenComponent<Studio37Media.Client.Components.ProfileComponents.TabPage>(73);
                __builder2.AddAttribute(74, "Text", "Workshops");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "\r\n        ");
                    __builder3.OpenComponent<Studio37Media.Client.Components.ProfileComponents.ProfileWorkshopsComponent>(77);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\ProfileComponents\ProfileViewComponent.razor"
       
    private Profile profile;

    public string view = "TimeLine";


    protected override async Task OnInitializedAsync()
    {
        try
        {
            profile = await Http.GetFromJsonAsync<Profile>("Profile/GetProfileById/0");
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
