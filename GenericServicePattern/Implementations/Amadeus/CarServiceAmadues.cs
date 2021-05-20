using GenericServicePattern.Implementations.Amadeus.Requesters;
using GenericServicePattern.Implementations.Clients;
using GenericServicePattern.Interfaces;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Implementations.Amadeus
{
    public class CarServiceAmadues : CarService<IServiceClient<HttpClient>>
    {
        public CarServiceAmadues()
        {
            var service = new ServiceClientHttpClient();
            FixCarRequester = new FixCarRequesterAmadues(service);
            GetCarRequester = new GetCarRequesterAmadeus(service);
        }
    }
}
