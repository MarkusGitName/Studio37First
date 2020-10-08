using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewEvent")]
        public Event Post(Event Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Event ReturnEvent = APILibrary.APIPost<Event>(Model, "Events");
            return ReturnEvent;
        }

    }
}