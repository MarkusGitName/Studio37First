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
    public class ClassRatingController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewClassRating")]
        public ClassRating Post(ClassRating Model)
        {
            ClassRating ReturnClassRating = APILibrary.APIPost<ClassRating>(Model, "ClassRatings");
            return ReturnClassRating;
        }
    }
}