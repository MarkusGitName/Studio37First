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
    [Route("[controller]")]
    [ApiController]
    public class ProfesionalProfileController : ControllerBase
    {
        // GET: api/Profesional
        [HttpGet]
        public IEnumerable<ProfesionallsProfile> Get()
        {
            IEnumerable<ProfesionallsProfile> profiles = APILibrary.APIGetALL<IEnumerable<ProfesionallsProfile>>("ProfesionallsProfiles");
            return profiles;
        }

        // GET: api/Profesional/5
        [HttpGet("{id}")]
        public ProfesionallsProfile Get(string id)
        {
            //Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile profiles = APILibrary.APIGet<ProfesionallsProfile>(id, "ProfesionallsProfiles");
            return profiles;
        }

        // POST: api/Profesional
        [HttpPost]
        public void Post(ProfesionallsProfile Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfile = APILibrary.APIPost<ProfesionallsProfile>(Model, "ProfesionallsProfiles");
            
        }

        // PUT: api/Profesional/5
        [HttpPut("{id}")]
        public void Put(string id, ProfesionallsProfile Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfile = APILibrary.APIPut<ProfesionallsProfile>(Model, Model.UserID, "ProfesionallsProfiles");
           
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete()
        {

            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfile = APILibrary.APIDelete<ProfesionallsProfile>(id, "ProfesionallsProfiles");
            
        }
    }
}
