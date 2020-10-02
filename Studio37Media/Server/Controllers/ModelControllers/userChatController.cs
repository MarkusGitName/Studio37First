﻿using System;
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
    public class UserChatController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewUserChat")]
        public UserChat Post(UserChat Model)
        {
            UserChat ReturnUserChat = APILibrary.APIPost<UserChat>(Model, "UserChats");
            return ReturnUserChat;
        }

    }
}