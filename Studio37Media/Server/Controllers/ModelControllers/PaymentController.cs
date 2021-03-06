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
    public class PaymentController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPayment")]
        public Payment Post(Payment Model)
        {
            Payment ReturnPayment = APILibrary.APIPost<Payment>(Model, "Payments");
            return ReturnPayment;
        }

    }
}