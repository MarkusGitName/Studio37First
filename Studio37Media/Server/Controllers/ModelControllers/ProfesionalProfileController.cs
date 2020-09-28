using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfesionalProfileController : ControllerBase
    {
        private readonly ILogger<ProfesionalProfileController> logger;

        public ProfesionalProfileController(ILogger<ProfesionalProfileController> logger)
        {
            this.logger = logger;
        }

        // GET: api/Profesional
        [HttpGet(Name = "GetProfesionals")]
        public IEnumerable<ProfesionallsProfile> Get()
        {
            IEnumerable<ProfesionallsProfile> profiles = APILibrary.APIGetALL<IEnumerable<ProfesionallsProfile>>("ProfesionallsProfiles");
            return profiles;
        }

        // GET: api/Profesional/5
        [HttpGet("{apiname}/{id}", Name = "GetProfesionalById/")]
        public ProfesionallsProfile Get(string id)
        {
            if (id == "0")
            {
               id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
            
            ProfesionallsProfile profiles = APILibrary.APIGet<ProfesionallsProfile>(id, "ProfesionallsProfiles");
            return profiles;
        }

        // POST: api/Profesional
        [HttpPost("{apiname}", Name = "PostProfesional")]
        public void Post(ProfesionallsProfile Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfile = APILibrary.APIPost<ProfesionallsProfile>(Model, "ProfesionallsProfiles");
            
        }

        // PUT: api/Profesional/5
        [HttpPut("{apiname}/{id}", Name = "PutProfesional")]
        public void Put(string id, ProfesionallsProfile Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfile = APILibrary.APIPut<ProfesionallsProfile>(Model, Model.UserID, "ProfesionallsProfiles");
           
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{apiname}", Name = "DeleteProfesional")]
        public void Delete()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfile = APILibrary.APIDelete<ProfesionallsProfile>(id, "ProfesionallsProfiles");
            
        }
    }
}
