using GenericServicePattern.Abstracts;
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
    public class GetCarRequesterAmadeus : Requester<Car, CarQuery, IServiceClient<HttpClient>>
    {
        public GetCarRequesterAmadeus(IServiceClient<HttpClient> service)
        {
            Service = service;
        }

        protected override GetCarAmaduesRequest ConvertRequest(CarQuery request)
        {
            GetCarAmaduesRequest query = new();
            //query.Car1 = request.SearchString;
            // Get something from RawRequet and convert it to CarQuery
            return query;
        }

        protected override Car ConvertResponse(dynamic response)
        {
            Car c = new();
            // Convert from object Raw response and return Car.
            //c.Id = response.SomeNumber1;
            return c;
        }

        public override Car Execute(CarQuery request)
        {
            GetCarAmaduesRequest convertedRequest = ConvertRequest(request);
            var resultFromHttp = Service.Client.PostAsync("url", new StringContent(convertedRequest.ToString())).Result;
            // parse to response or move this logic into the ISerivceClient - Like Amadeus class in their project for example
            GetCarAmaduesResponse rawResponse = new();
            return ConvertResponse(rawResponse);
        }
    }
}
