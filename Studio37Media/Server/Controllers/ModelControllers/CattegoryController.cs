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
    [Route("[controller]")]
    [ApiController]
    public class CattegoryController : ControllerBase
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        [HttpPost("{apiname}", Name = "NewCategory")]
        public Category Post(Category Model)
        {
            //Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Category ReturnCattegory = APILibrary.APIPost<Category>(Model, "Categories");
            return ReturnCattegory;
        }
    }
}