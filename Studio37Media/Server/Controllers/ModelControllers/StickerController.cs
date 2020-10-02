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
    public class StickerController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewSticker")]
        public Sticker Post(Sticker Model)
        {
            Sticker ReturnSticker = APILibrary.APIPost<Sticker>(Model, "Stickers");
            return ReturnSticker;
        }

    }
}