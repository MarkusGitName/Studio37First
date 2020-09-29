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
    public class TutorialPromoVideoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewTutorialPromoVideo")]
        public TutorialPromoVideo Post(TutorialPromoVideo Model)
        {
            TutorialPromoVideo ReturnTutorialPromoVideo = APILibrary.APIPost<TutorialPromoVideo>(Model, "TutorialPromoVideos");
            return ReturnTutorialPromoVideo;
        }

    }
}