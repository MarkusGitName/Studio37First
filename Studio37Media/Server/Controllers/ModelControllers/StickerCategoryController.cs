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
    public class StickerCategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewStickerCategory")]
        public StickerCategory Post(StickerCategory Model)
        {
            StickerCategory ReturnStickerCategory = APILibrary.APIPost<StickerCategory>(Model, "StickerCattegories");
            return ReturnStickerCategory;
        }

    }
}