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
    public class VideoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewVideo")]
        public Video Post(Video Model)
        {
            Video ReturnVideo = APILibrary.APIPost<Video>(Model, "Videos");
            return ReturnVideo;
        }

    }
}