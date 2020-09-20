using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Studio37Media.Server.Controllers.FileController
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TutorialController : ControllerBase
    {

        private readonly ILogger<ProfileController> logger;

        public TutorialController(ILogger<ProfileController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("{apiname}", Name = "GetTutorials")]
        public IEnumerable<Tutorial> Get()
        {

            IEnumerable<Tutorial> tutorials = APILibrary.APIGetALL<IEnumerable<Tutorial>>("Tutorials");
            return tutorials;
        }
        [HttpGet("{apiname}/{id}", Name = "GetTutorialsById")]
        public Tutorial Get(string id)
        {

            Tutorial tutorial = APILibrary.APIGet<Tutorial>(id, "Tutorials");
            return tutorial;
        }

        [HttpPost("{apiname}", Name = "PostTutorial")]
        public void Post(Tutorial Model)
        {
            Model.ProfesionalID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            APILibrary.APIPost<Tutorial>(Model, "tutorials");
            
        }
        [HttpPut("{apiname}/{id}", Name = "PutTutorial")]
        public Tutorial Edit(Tutorial Model, string id)
        {
            Model.ProfesionalID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Tutorial ReturnTutorial = APILibrary.APIPut<Tutorial>(Model, id, "Tutorials");
            return ReturnTutorial;
        }
        [HttpPut("{apiname}/{id}", Name = "DeleteTutorial")]
        public Tutorial Delete(Tutorial Model, string id)
        {
            Model.ProfesionalID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Tutorial ReturnTutorial = APILibrary.APIDelete<Tutorial>(id, "Tutorials");
            return ReturnTutorial;
        }
    }

}
