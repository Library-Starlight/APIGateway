using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CatelogApi.Controllers
{
    [ApiController]
    [Route("api/currencies")]
    public class CurreniesController : ControllerBase
    {
        // Get api/currencies
        [HttpGet, Route("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr", "jpy" };
        }
    }
}
