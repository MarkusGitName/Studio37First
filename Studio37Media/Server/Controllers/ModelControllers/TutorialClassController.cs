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
    public class TutorialClassController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewTutorialClass")]
        public TutorialClass Post(TutorialClass Model)
        {
            TutorialClass ReturnTutorialClass = APILibrary.APIPost<TutorialClass>(Model, "TutorialClasses");
            return ReturnTutorialClass;
        }

    }
}