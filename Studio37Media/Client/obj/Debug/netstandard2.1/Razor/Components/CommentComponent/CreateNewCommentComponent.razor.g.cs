#pragma checksum "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8504d473119dbaa93200240bb7256625f2941107"
// <auto-generated/>
#pragma warning disable 1591
namespace Studio37Media.Client.Components.CommentComponent
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
#line 1 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
using Studio37Media.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
using System.IO.MemoryMappedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CreateNewCommentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>create comment component</div>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
                  newComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
                                              HandleFormSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"f\" class=\"col-sm-1 col-form-label\">text</label>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-sm-5");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "f");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "First Name");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
                                    newComment.text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newComment.text = __value, newComment.text))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newComment.text));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n    ");
                __builder2.AddMarkupContent(27, "<button class=\"class=\" btn btn-primary\"\" type=\"submit\">Sent</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\WorkingVersionsRepo\Studio37Media\Client\Components\CommentComponent\CreateNewCommentComponent.razor"
       
    Comment newComment = new Comment();

    [Parameter]
    public Guid ObjectId { get; set; }
    [Parameter]
    public string ObjectType { get; set; }
    //This runs on form submit
    async void HandleFormSubmit()
    {
        newComment.id = Guid.NewGuid();
        //post to profile controller
        await Http.PostAsJsonAsync<Comment>("Comment/NewComment", newComment);


        if (ObjectType == "ClassVideo")
        {
            ClassVideoComment newClassVideoComment = new ClassVideoComment();
            newClassVideoComment.ClassVideoID = ObjectId;
            newClassVideoComment.CommentID = newComment.id;

            await Http.PostAsJsonAsync<ClassVideoComment>("ClassVideoComment/NewClassVideoComment", newClassVideoComment);

        }
        if (ObjectType == "Comment")
        {
            CommentComment newCommentComment = new CommentComment();
            newCommentComment.oldComment = ObjectId;
            newCommentComment.newComment = newComment.id;


            await Http.PostAsJsonAsync<CommentComment>("CommentComment/NewCommentComment", newCommentComment);
        }
        if (ObjectType == "LiveShow")
        {

            LiveShowComment newLiveShowComment = new LiveShowComment();
            newLiveShowComment.LiveShowID = ObjectId;
            newLiveShowComment.CommentID = newComment.id;

            await Http.PostAsJsonAsync<LiveShowComment>("LiveShowComment/NewLiveShowComment", newLiveShowComment);
        }
        if (ObjectType == "Post")
        {
            PostComment newPostComment = new PostComment();
            newPostComment.PostID = ObjectId;
            newPostComment.CommentID = newComment.id;

            await Http.PostAsJsonAsync<PostComment>("PostComment/NewPostComment", newPostComment);
        }
        if (ObjectType == "Tutorial")
        {
            TutorialComment newTutorialComment = new TutorialComment();
            newTutorialComment.TutorialID = ObjectId;
            newTutorialComment.CommentID = newComment.id;


            await Http.PostAsJsonAsync<TutorialComment>("TutorialComment/NewTutorialComment", newTutorialComment);
        }

        //await Http.GetFromJsonAsync<Profile>("Profile");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
