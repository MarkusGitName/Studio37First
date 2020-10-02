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
    public class TutorialRatingController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewTutorialRating")]
        public TutorialRating Post(TutorialRating Model)
        {
            TutorialRating ReturnTutorialRating = APILibrary.APIPost<TutorialRating>(Model, "TutorialRatings");
            return ReturnTutorialRating;
        }

    }
}