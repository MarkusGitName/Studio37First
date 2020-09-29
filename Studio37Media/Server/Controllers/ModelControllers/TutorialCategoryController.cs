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
    public class TutorialCategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewTutorialCategory")]
        public TutorialCategory Post(TutorialCategory Model)
        {
            TutorialCategory ReturnTutorialCategory = APILibrary.APIPost<TutorialCategory>(Model, "TutorialCattegories");
            return ReturnTutorialCategory;
        }

    }
}