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
    public class LiveShowCategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewLiveShowCategory")]
        public LiveShowCategory Post(LiveShowCategory Model)
        {
            LiveShowCategory ReturnLiveShowCategory = APILibrary.APIPost<LiveShowCategory>(Model, "LiveShowCattegories");
            return ReturnLiveShowCategory;
        }

    }
}