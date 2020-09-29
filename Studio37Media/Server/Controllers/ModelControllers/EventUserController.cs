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
    public class EventUserController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewEventUser")]
        public EventUser Post(EventUser Model)
        {
            EventUser ReturnEventUser = APILibrary.APIPost<EventUser>(Model, "EventUsers");
            return ReturnEventUser;
        }

    }
}