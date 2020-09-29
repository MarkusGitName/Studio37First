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
    public class PhotoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPhoto")]
        public Photo Post(Photo Model)
        {
            Photo ReturnPhoto = APILibrary.APIPost<Photo>(Model, "Photos");
            return ReturnPhoto;
        }

    }
}