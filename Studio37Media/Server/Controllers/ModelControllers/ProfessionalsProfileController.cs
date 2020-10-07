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
    public class ProfessionalProfileController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewProfessionalProfile")]
        public ProfesionallsProfile Post(ProfesionallsProfile Model)
        {
            ProfesionallsProfile ReturnProfessionalProfile = APILibrary.APIPost<ProfesionallsProfile>(Model, "ProfesionallsProfiles");
            return ReturnProfessionalProfile;
        }

    }
}