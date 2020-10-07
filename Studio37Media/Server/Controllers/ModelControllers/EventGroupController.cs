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
    public class EventGroupController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewEventGroup")]
        public EventGroup Post(EventGroup Model)
        {
            EventGroup ReturnEventGroup = APILibrary.APIPost<EventGroup>(Model, "EventGroups");
            return ReturnEventGroup;
        }

    }
}