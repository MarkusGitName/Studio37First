#pragma checksum "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\Components\ProfileComponents\ProfileTimelineComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1cbd282b2cfd8029737f006cab074c2323a35fc"
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
#line 12 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kayla\Source\Repos\Studio37First_5\Studio37Media\Client\_Imports.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
    public partial class ProfileTimelineComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div calss=\"conatiner my-4\">\r\n        <button class=\"btn btn-block font-weight-bold text-muted\" data-toggle=\"modal\" data-target=\"#selectPostType\">\r\n            <span class=\"oi oi-plus\"></span>\r\n            New Post\r\n        </button>\r\n    </div>\r\n\r\n    ");
            __builder.AddMarkupContent(1, @"<div class=""modal"" id=""selectPostType"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header border-0"">
                    <h4 class=""modal-title"">Create a Post</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <button type=""button"" class=""btn btn-info w-25 mx-3"" data-toggle=""modal"" data-target=""#textPostModal"">Text Post</button>
                    <button type=""button"" class=""btn btn-success w-25 mx-3"" data-toggle=""modal"" data-target=""#photoPostModal"">Picture</button>
                    <button tupe=""button"" class=""btn btn-warning w-25 mx-3"" data-toggle=""modal"" data-target=""#videoPostModal"">Video Clip</button>
                </div>
            </div>

        </div>
    </div>

    ");
            __builder.AddMarkupContent(2, @"<div class=""modal"" id=""textPostModal"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header border-0"">
                    <h4 class=""modal-title"">Text Post</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <textarea class=""form-control"" rows=""5"" id=""textPost"" placeholder=""Write post...""></textarea>
                    </div>
                    <button type=""submit"" class=""btn btn-light btn-block"" data-dismiss=""modal"">Upload</button>
                </div>
            </div>
        </div>
    </div>

    ");
            __builder.AddMarkupContent(3, @"<div class=""modal"" id=""photoPostModal"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header border-0"">
                    <h4 class=""modal-title"">Photo</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <div class=""custom-file my-2"" id=""customFile"" lang=""es"">
                            <input type=""file"" class=""custom-file-input"" id=""photoPost"" aria-describedby=""fileHelp"">
                            <label class=""custom-file-label"" for=""photoPost"">
                                Select file...
                            </label>
                        </div>
                        <textarea class=""form-control my-2"" rows=""5"" id=""caption"" placeholder=""caption""></textarea>
                    </div>
                    <button type=""submit"" class=""btn btn-light btn-block"" data-dismiss=""modal"">Upload</button>
                </div>
            </div>
        </div>
    </div>

    ");
            __builder.AddMarkupContent(4, @"<div class=""modal"" id=""videoPostModal"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header border-0"">
                    <h4 class=""modal-title"">Video Clip</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <div class=""custom-file my-2"" id=""customFile2"" lang=""es"">
                            <input type=""file"" class=""custom-file-input"" id=""videoPost"" aria-describedby=""fileHelp"">
                            <label class=""custom-file-label"" for=""videoPost"">
                                Select file...
                            </label>
                        </div>
                        <textarea class=""form-control my-2"" rows=""5"" id=""caption"" placeholder=""caption""></textarea>
                    </div>
                    <button type=""submit"" class=""btn btn-light btn-block"" data-dismiss=""modal"">Upload</button>
                </div>
            </div>
        </div>
    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
