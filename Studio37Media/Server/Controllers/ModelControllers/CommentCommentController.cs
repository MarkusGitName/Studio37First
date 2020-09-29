﻿using System;
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
    public class CommentCommentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewCommentComment")]
        public CommentComment Post(CommentComment Model)
        {
            CommentComment ReturnCommentComment = APILibrary.APIPost<CommentComment>(Model, "CommentComments");
            return ReturnCommentComment;
        }

    }
}