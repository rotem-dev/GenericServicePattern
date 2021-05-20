using GenericServicePattern.Implementations.Clients;
using GenericServicePattern.Implementations.Yaya.Requesters;
using GenericServicePattern.Interfaces;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Implementations.Yaya
{
    public class CarServiceYaya : CarService<IServiceClient<SomeWcfSoapClient>>
    {
        public CarServiceYaya()
        {
            FixCarRequester = new FixCarRequesterYaya();
            GetCarRequester = new GetCarRequesterYaya();
        }
    }
}
