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
    public class CountriesController : ControllerBase
    {
        public CountriesService service { get; set; }

        public CountriesController()
        {

        }

        [HttpGet]
        public async Task<ActionResult> Get ()
        {
            try
            {
                var countries = await this.service.ListOfCurrenciesByName();

                return new OkObjectResult(countries);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
