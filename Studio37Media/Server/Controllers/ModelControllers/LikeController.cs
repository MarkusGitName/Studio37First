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
    public class LikeController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewLike")]
        public Like Post(Like Model)
        {
            Like ReturnLike = APILibrary.APIPost<Like>(Model, "Likes");
            return ReturnLike;
        }

    }
}