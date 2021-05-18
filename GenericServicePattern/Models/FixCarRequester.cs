using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Models
{
    public class FixCarRequester : IRequester<bool, Car, IServiceClient<HttpClient>>
    {
        public IServiceClient<HttpClient> Service { get; private set; }

        public FixCarRequester(IServiceClient<HttpClient> service)
        {
            Service = service;
        }

        public Car ConvertRequest(object request)
        {
            Car c = new Car();
            // Convert RawRequest to Car operations...
            return c;
        }

        public bool ConvertResponse(object response)
        {
            bool result = false;
            // Do needed operations to know about result from RawResponse
            return result;
        }

        public object Execute(object request)
        {
            return ConvertResponse(Service.Client.PostAsync("url", new StringContent(ConvertRequest(request).ToString())).Result);
        }
    }
}
