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
    public class SaleController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewSale")]
        public Sale Post(Sale Model)
        {
            Sale ReturnSale = APILibrary.APIPost<Sale>(Model, "Sales");
            return ReturnSale;
        }

    }
}