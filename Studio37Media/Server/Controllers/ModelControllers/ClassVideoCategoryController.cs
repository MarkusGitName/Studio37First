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
    public class ClassVideoCategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewClassVideoCategory")]
        public ClassVideoCategory Post(ClassVideoCategory Model)
        {
            ClassVideoCategory ReturnClassVideoCategory = APILibrary.APIPost<ClassVideoCategory>(Model, "ClassVideoCattegories");
            return ReturnClassVideoCategory;
        }
    }
}