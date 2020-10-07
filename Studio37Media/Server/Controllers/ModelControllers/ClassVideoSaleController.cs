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
    public class ClassVideoSaleController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewClassVideoSale")]
        public ClassVideoSale Post(ClassVideoSale Model)
        {
            ClassVideoSale ReturnClassVideoSale = APILibrary.APIPost<ClassVideoSale>(Model, "ClassVideoSales");
            return ReturnClassVideoSale;
        }
    }
}