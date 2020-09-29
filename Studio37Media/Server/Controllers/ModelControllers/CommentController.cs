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
    public class CommentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewComment")]
        public Comment Post(Comment Model)
        {
            Comment ReturnComment = APILibrary.APIPost<Comment>(Model, "Comments");
            return ReturnComment;
        }

    }
}