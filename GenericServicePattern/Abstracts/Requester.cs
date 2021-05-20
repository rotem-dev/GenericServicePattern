using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Abstracts
{    
    // Res is the response returned from the service (after convert)
    // RawReq (is our class) before convert
    public abstract class Requester<Res, RawReq, T> where T : IServiceClient
    {
        protected T Service { get; set; }
        protected abstract dynamic ConvertRequest(RawReq request);
        protected abstract Res ConvertResponse(dynamic response);
        public abstract Res Execute(RawReq request);
    }
}
