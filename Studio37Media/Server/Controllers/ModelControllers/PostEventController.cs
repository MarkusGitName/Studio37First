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
    public class PostEventController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPostEvent")]
        public PostEvent Post(PostEvent Model)
        {
            PostEvent ReturnPostEvent = APILibrary.APIPost<PostEvent>(Model, "PostEvents");
            return ReturnPostEvent;
        }

    }
}