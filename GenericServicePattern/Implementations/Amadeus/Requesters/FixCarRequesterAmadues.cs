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
    public class FixCarRequesterAmadues : Requester<bool, Car, IServiceClient<HttpClient>>
    {
        public FixCarRequesterAmadues(IServiceClient<HttpClient> service)
        {
            Service = service;
        }

        protected override FixCarAmaduesRequest ConvertRequest(Car request)
        {
            FixCarAmaduesRequest c = new();
            //c.Car = request.CarName;
            // Convert RawRequest to Car operations...
            return c;
        }

        protected override bool ConvertResponse(dynamic response)
        {
            bool result = true; //response.CarId == 0;
            // Do needed operations to know about result from RawResponse
            return result;
        }

        public override bool Execute(Car request)
        {
            FixCarAmaduesRequest convertedRequest = ConvertRequest(request);
            var resultFromHttp = Service.Client.PostAsync("url", new StringContent(convertedRequest.ToString())).Result;
            // parse to response or move this logic into the ISerivceClient - Like Amadeus class in their project for example
            FixCarAmaduesReponse rawResponse = new();
            return ConvertResponse(rawResponse);
        }
    }
}
