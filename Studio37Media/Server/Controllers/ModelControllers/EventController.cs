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
    public class EventController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewEvent")]
        public Event Post(Event Model)
        {
            Event ReturnEvent = APILibrary.APIPost<Event>(Model, "Events");
            return ReturnEvent;
        }

    }
}