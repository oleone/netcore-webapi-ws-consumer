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
        public async Task<ActionResult<string>> NumberToWords([FromQuery] ulong number)
        {
            try
            {
                var numberWorded = await Service.NumberToWords(number);
                return new OkObjectResult(numberWorded);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Conversão simples de número para dolar.
        /// </summary>
        /// <param name="dNumber">Número decimal.</param>
        /// <returns>Número dolarizado.</returns>
        [HttpGet("numberToDollars")]
        public async Task<ActionResult<string>> NumberToDollars([FromQuery] decimal dNumber)
        {
            try
            {
                var dollar = await Service.NumberToDollars(dNumber);
                return new OkObjectResult(dollar);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
