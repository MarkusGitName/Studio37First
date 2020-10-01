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
    public class ProfessionalDocumentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewProfessionalDocument")]
        public ProfesionalsDocument Post(ProfesionalsDocument Model)
        {
            ProfesionalsDocument ReturnProfessionalDocument = APILibrary.APIPost<ProfesionalsDocument>(Model, "ProfesionalsDocuments");
            return ReturnProfessionalDocument;
        }

    }
}