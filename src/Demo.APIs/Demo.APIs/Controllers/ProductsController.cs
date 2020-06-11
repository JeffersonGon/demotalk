using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.APIs.Infra.Interfaces;
using Demo.APIs.Infra.Model.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<ProductsModels> Get([FromServices] IProductsModels products)
        {
            return products.Values();
        }

        [HttpGet]
        [Route("")]
        public ProductsModels GetFirst([FromServices] IProductsModels products)
        {
            return products.Values().FirstOrDefault();
        }
    }
}