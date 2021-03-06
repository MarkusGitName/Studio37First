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
    public class UserCategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewUserCategory")]
        public UserCattegory Post(UserCattegory Model)
        {
            UserCattegory ReturnUserCategory = APILibrary.APIPost<UserCattegory>(Model, "UserCattegories");
            return ReturnUserCategory;
        }

    }
}