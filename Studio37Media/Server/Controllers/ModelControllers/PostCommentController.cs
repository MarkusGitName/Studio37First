using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPostComment")]
        public PostComment Post(PostComment Model)
        {
            PostComment ReturnPostComment = APILibrary.APIPost<PostComment>(Model, "PostComments");
            return ReturnPostComment;
        }

    }
}