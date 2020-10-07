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
    public class PostPhotoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPostPhoto")]
        public PostPhoto Post(PostPhoto Model)
        {
            PostPhoto ReturnPostPhoto = APILibrary.APIPost<PostPhoto>(Model, "PostPhotoes");
            return ReturnPostPhoto;
        }

    }
}