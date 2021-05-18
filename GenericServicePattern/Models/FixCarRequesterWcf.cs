using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Models
{
    class FixCarRequesterWcf : IRequester<bool, Car, IServiceClient<SomeWcfSoapClient>>
    {
        public IServiceClient<SomeWcfSoapClient> Service { get; private set; }

        public FixCarRequesterWcf()
        {
            Service = new ServiceClientWcf();
        }

        public Car ConvertRequest(object request)
        {
            // Some conversion
            return new Car();
        }

        public bool ConvertResponse(object response)
        {
            // Some Conversions
            return true;
        }

        public object Execute(object request)
        {
            Service.Client.FixCars(ConvertRequest(request));
            return true;
        }
    }
}
