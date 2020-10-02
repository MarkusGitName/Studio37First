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
    public class TutorialPromoPhotoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewTutorialPromoPhoto")]
        public TutorialPromoPhoto Post(TutorialPromoPhoto Model)
        {
            TutorialPromoPhoto ReturnTutorialPromoPhoto = APILibrary.APIPost<TutorialPromoPhoto>(Model, "TutorialPromoPhotoes");
            return ReturnTutorialPromoPhoto;
        }

    }
}