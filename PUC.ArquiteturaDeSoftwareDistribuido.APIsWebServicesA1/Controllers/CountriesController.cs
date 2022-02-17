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
        public CountriesService Service { get; set; }

        public CountriesController(CountriesService service)
        {
            Service = service;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var countries = await Service.FullCountryInfoAllCountriesAsync();

                return new OkObjectResult(countries);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
