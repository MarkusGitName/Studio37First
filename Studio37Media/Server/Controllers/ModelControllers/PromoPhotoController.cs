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
    public class PromoPhotoController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPromoPhoto")]
        public PromoPhoto Post(PromoPhoto Model)
        {
            PromoPhoto ReturnPromoPhoto = APILibrary.APIPost<PromoPhoto>(Model, "PromoPhotoes");
            return ReturnPromoPhoto;
        }

    }
}