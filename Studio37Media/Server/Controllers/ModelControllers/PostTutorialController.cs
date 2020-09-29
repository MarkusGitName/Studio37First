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
    public class PostTutorialController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPostTutorial")]
        public PostTutorial Post(PostTutorial Model)
        {
            PostTutorial ReturnPostTutorial = APILibrary.APIPost<PostTutorial>(Model, "PostTutorials");
            return ReturnPostTutorial;
        }

    }
}