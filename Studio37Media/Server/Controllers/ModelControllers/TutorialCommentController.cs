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
    [Route("[controller]")]
    [ApiController]
    public class TutorialCommentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewTutorialComment")]
        public TutorialComment Post(TutorialComment Model)
        {
            TutorialComment ReturnTutorialComment = APILibrary.APIPost<TutorialComment>(Model, "TutorialComments");
            return ReturnTutorialComment;
        }

    }
}