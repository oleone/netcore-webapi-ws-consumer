using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetcoreWebapiWSConsumer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcoreWebapiWSConsumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        public NumbersService Service { get; set; }
        public NumbersController(NumbersService service)
        {
            Service = service;
        }

        /// <summary>
        /// Conversão simples de número por extenso.
        /// </summary>
        /// <param name="number">Número.</param>
        /// <returns>Número por extenso.</returns>
        [HttpGet("numberToWords")]
        public async Task<string> NumberToWords([FromQuery] ulong number)
        {
            return await Service.NumberToWords(number);
        }
    }
}
