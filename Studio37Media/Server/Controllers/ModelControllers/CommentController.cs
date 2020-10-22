using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewComment")]
        public Comment Post(Comment Model)
        {
            Model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Comment ReturnComment = APILibrary.APIPost<Comment>(Model, "Comments");
            return ReturnComment;
        }

    }
}