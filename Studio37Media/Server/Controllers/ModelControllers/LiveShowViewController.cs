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
    [Route("[controller]")]
    [ApiController]
    public class LiveShowViewController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewLiveShowView")]
        public LiveShowView Post(LiveShowView Model)
        {
            LiveShowView ReturnLiveShowView = APILibrary.APIPost<LiveShowView>(Model, "LiveShowViews");
            return ReturnLiveShowView;
        }

    }
}