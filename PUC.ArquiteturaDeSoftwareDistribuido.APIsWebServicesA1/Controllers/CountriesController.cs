using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public CountriesController()
        {

        }

        [HttpGet]
        public ActionResult Get ()
        {
            try
            {
                return new OkResult();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
