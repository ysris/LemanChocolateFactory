using LemanChocolateFactoryApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LemanChocolateFactoryApi.Controllers
{
    [Route("api/rates")]
    [ApiController]
    public class FxRatesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ExchangeRate>> Get()
        {
            return new List<ExchangeRate>
            {
                new ExchangeRate  { fromCcy="BTC" },
                new ExchangeRate  { fromCcy="LTC" },
            };
        }
    }
}
