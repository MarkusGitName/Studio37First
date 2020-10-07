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
    public class ChatController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewChat")]
        public Chat Post(Chat Model)
        {
            Chat ReturnChat = APILibrary.APIPost<Chat>(Model, "Chats");
            return ReturnChat;
        }
    }
}