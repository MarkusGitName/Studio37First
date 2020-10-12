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
    public class LiveShowSaleController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewLiveShowSale")]
        public LiveShowSale Post(LiveShowSale Model)
        {
            LiveShowSale ReturnLiveShowSale = APILibrary.APIPost<LiveShowSale>(Model, "LiveShowSales");
            return ReturnLiveShowSale;
        }

    }
}