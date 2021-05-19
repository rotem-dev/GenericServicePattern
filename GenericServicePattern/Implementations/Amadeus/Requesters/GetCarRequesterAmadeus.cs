using GenericServicePattern.Interfaces;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Implementations.Amadeus.Requesters
{
    public class GetCarRequesterAmadeus : IRequester<Car, CarQuery, IServiceClient<HttpClient>>
    {
        public IServiceClient<HttpClient> Service { get; private set; }

        public GetCarRequesterAmadeus(IServiceClient<HttpClient> service)
        {
            Service = service;
        }

        public CarQuery ConvertRequest(object request)
        {
            CarQuery query = new CarQuery();
            // Get something from RawRequet and convert it to CarQuery
            return query;
        }

        public Car ConvertResponse(object response)
        {
            Car c = new Car();
            // Convert from object Raw response and return Car.
            return c;
        }

        public object Execute(object request)
        {
            return ConvertResponse(Service.Client.PostAsync("url", new StringContent(ConvertRequest(request).ToString())).Result);
        }
    }
}
