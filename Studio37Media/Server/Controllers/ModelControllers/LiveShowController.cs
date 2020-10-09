using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveShowController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewLiveShow")]
        public LiveShow Post(LiveShow Model)
        {
            
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            LiveShow ReturnLiveShow = APILibrary.APIPost<LiveShow>(Model, "LiveShows");
            return ReturnLiveShow;
        }

    }
}