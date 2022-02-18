using ISBNServiceReference;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcoreWebapiWSConsumer.Services
{
    public class ISBNService
    {
        public IConfiguration Configuration { get; set; }
        public ISBNService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<bool> IsValidISBN13(string sISBN)
        {
            SBNServiceSoapTypeClient client = new SBNServiceSoapTypeClient(SBNServiceSoapTypeClient.EndpointConfiguration.ISBNServiceSoap);
            var result = await client.IsValidISBN13Async(sISBN);
            return result.Body.IsValidISBN13Result;
        }
    }
}
