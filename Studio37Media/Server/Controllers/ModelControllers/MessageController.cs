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
    public class MessageController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewMessage")]
        public Message Post(Message Model)
        {
            Message ReturnMessage = APILibrary.APIPost<Message>(Model, "Messages");
            return ReturnMessage;
        }

    }
}