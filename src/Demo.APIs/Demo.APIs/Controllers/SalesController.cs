using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.APIs.Infra;
using Demo.APIs.Infra.Model.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<SalesModels> Get([FromServices] ISalesModels sales)
        {
            return sales.Values();
        }
    }
}