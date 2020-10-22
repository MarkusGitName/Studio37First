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
    [Route("[controller]")]
    [ApiController]
    public class ClassVideoCommentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewClassVideoComment")]
        public ClassVideoComment Post(ClassVideoComment Model)
        {
            ClassVideoComment ReturnClassVideoComment = APILibrary.APIPost<ClassVideoComment>(Model, "ClassVideoComments");
            return ReturnClassVideoComment;
        }
    }
}