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
    public class PostLiveShowController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPostLiveShow")]
        public PostLiveShow Post(PostLiveShow Model)
        {
            PostLiveShow ReturnPostLiveShow = APILibrary.APIPost<PostLiveShow>(Model, "PostLiveShows");
            return ReturnPostLiveShow;
        }

    }
}