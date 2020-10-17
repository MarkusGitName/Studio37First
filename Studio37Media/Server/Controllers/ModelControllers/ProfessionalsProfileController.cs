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
    public class ProfessionalProfileController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewProfessionalProfile")]
        public ProfesionallsProfile Post(ProfesionallsProfile Model)
        {
            ProfesionallsProfile ReturnProfessionalProfile = APILibrary.APIPost<ProfesionallsProfile>(Model, "ProfesionallsProfiles");
            return ReturnProfessionalProfile;
        }
        [HttpGet("{apiname}", Name = "GetProfessionalProfileById")]
        public ProfesionallsProfile GetById()
        {

            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ProfesionallsProfile ReturnProfessionalProfile = APILibrary.APIGet<ProfesionallsProfile>(id,"ProfesionallsProfiles");
            return ReturnProfessionalProfile;
        }

    }
}