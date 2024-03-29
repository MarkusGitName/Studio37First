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
    public class ShareController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewShare")]
        public Share Post(Share Model)
        {
            Share ReturnShare = APILibrary.APIPost<Share>(Model, "Shares");
            return ReturnShare;
        }

    }
}