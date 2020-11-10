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
    public class ClassVideoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewClassVideo")]
        public ClassVideo Post(ClassVideo Model)
        {
            ClassVideo ReturnClassVideo = APILibrary.APIPost<ClassVideo>(Model, "ClassVideos");
            return ReturnClassVideo;
        }

        [HttpGet("{apiname}", Name = "GetClassVideos")]
        public IEnumerable<ClassVideo> Get()
        {
            IEnumerable<ClassVideo> classVideo = APILibrary.APIGetALL<IEnumerable<ClassVideo>>("Profiles");
            return classVideo;
        }
    }
}
