using GenericServicePattern.Abstracts;
using GenericServicePattern.Implementations.Clients;
using GenericServicePattern.Interfaces;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Implementations.Yaya.Requesters
{
    class FixCarRequesterYaya : Requester<bool, Car, IServiceClient<SomeWcfSoapClient>>
    {
        public FixCarRequesterYaya()
        {
            Service = new ServiceClientWcf();
        }

        protected override object ConvertRequest(Car request)
        {
            FixCarYayaRequest req = new FixCarYayaRequest
            {
                MyProperty1 = 123
            };
            // Some conversion
            return req;
        }

        protected override bool ConvertResponse(object response)
        {
            return true;
        }

        public override bool Execute(Car request)
        {
            // Can use Convert response if needed. here there is no response (just an example)
            Service.Client.FixCars((FixCarYayaRequest)ConvertRequest(request));
            return true;
        }
    }
}
