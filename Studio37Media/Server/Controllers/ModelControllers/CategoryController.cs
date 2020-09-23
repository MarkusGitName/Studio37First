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
    public class CategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewCategory")]
        public Category Post(Category Model)
        {
            Category ReturnProfile = APILibrary.APIPost<Category>(Model, "Categories");
            return ReturnProfile;
        }

    }
}