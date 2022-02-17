using CountryInfoServiceReference;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUC.ArquiteturaDeSoftwareDistribuido.APIsWebServicesA1.Services
{
    public class CountriesService
    {
        private readonly IConfiguration Configuration;

        public CountriesService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<tCountryInfo[]> FullCountryInfoAllCountriesAsync()
        {
            CountryInfoServiceSoapTypeClient client = new CountryInfoServiceSoapTypeClient(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
            var result = await client.FullCountryInfoAllCountriesAsync();
            return result.Body.FullCountryInfoAllCountriesResult;
        }
    }
}
