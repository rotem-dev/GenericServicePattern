using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Models
{
    public class GetCarRequesterWcf : IRequester<Car, CarQuery, IServiceClient<SomeWcfSoapClient>>
    {
        public IServiceClient<SomeWcfSoapClient> Service { get; private set; }

        public GetCarRequesterWcf()
        {
            Service = new ServiceClientWcf();
        }

        public CarQuery ConvertRequest(object request)
        {
            // Some Conversions
            return new CarQuery();
        }

        public Car ConvertResponse(object response)
        {
            // Some conversions...
            return new Car();
        }

        public object Execute(object request)
        {
            return ConvertResponse(Service.Client.GetCars(ConvertRequest(request)).FirstOrDefault());
        }
    }
}
