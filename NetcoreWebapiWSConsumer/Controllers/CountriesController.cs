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
    public class CountriesController : ControllerBase
    {
        public CountriesService Service { get; set; }

        public CountriesController(CountriesService service)
        {
            Service = service;
        }

        /// <summary>
        /// Buscar informações completas de todos os paises.
        /// </summary>
        /// <returns>Lista de paises.</returns>
        [HttpGet("fullCountryInfoAllCountries")]
        public async Task<ActionResult> FullCountryInfoAllCountries()
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
