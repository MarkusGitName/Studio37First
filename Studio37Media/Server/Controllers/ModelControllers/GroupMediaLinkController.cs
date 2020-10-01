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
    public class GroupMediaLinkController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewGroupMediaLink")]
        public GoupMediaLink Post(GoupMediaLink Model)
        {
            GoupMediaLink ReturnGroupMediaLink = APILibrary.APIPost<GoupMediaLink>(Model, "GoupMediaLinks");
            return ReturnGroupMediaLink;
        }

    }
}
