using Microsoft.Extensions.Configuration;
using NumberConversionServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcoreWebapiWSConsumer.Services
{
    public class NumbersService
    {
        private readonly IConfiguration Configuration;

        public NumbersService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<string> NumberToWords(ulong number)
        {
            NumberConversionSoapTypeClient client = new NumberConversionSoapTypeClient(NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap);
            var result = await client.NumberToWordsAsync(number);
            return result.Body.NumberToWordsResult.ToUpperInvariant().Trim();
        }

        public async Task<string> NumberToDollars(decimal dNum)
        {
            NumberConversionSoapTypeClient client = new NumberConversionSoapTypeClient(NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap);
            var result = await client.NumberToDollarsAsync(dNum);
            return result.Body.NumberToDollarsResult;
        }
    }
}
