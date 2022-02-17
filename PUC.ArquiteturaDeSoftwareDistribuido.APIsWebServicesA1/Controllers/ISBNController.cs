using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ISBNController : ControllerBase
    {
        public ISBNService Service { get; set; }
        public ISBNController(ISBNService service)
        {
            Service = service;
        }

        /// <summary>
        /// Validação de número ISBN 13.
        /// </summary>
        /// <param name="sISBN">Número ISBN 13.</param>
        /// <returns>Booleano.</returns>
        [HttpGet("validationISBN13")]
        public async Task<ActionResult> IsValidISBN13([FromQuery] string sISBN)
        {
            try
            {
                bool isValid = await Service.IsValidISBN13(sISBN);
                return new OkObjectResult(isValid);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
