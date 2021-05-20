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
    public class GetCarRequesterYaya : Requester<Car, CarQuery, IServiceClient<SomeWcfSoapClient>>
    {
        public GetCarRequesterYaya()
        {
            Service = new ServiceClientWcf();
        }

        public override Car Execute(CarQuery request)
        {
            return ConvertResponse(Service.Client.GetCars((GetCarYayaRequest)ConvertRequest(request)));
        }

        protected override object ConvertRequest(CarQuery request)
        {
            GetCarYayaRequest convertedRequest = new();
            convertedRequest.MyProperty3 = request.Id;
            // Some Conversions
            return convertedRequest;
        }

        protected override Car ConvertResponse(object response)
        {
            Car convertedResponse = new();// response.FirstOrDefault();
            // Some conversions...
            return convertedResponse;
        }
    }
}
