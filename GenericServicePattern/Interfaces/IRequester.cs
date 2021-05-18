using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Interfaces
{
    // Req is the Request needed for the service (after convert)
    // Res is the response returned from the service (after convert)
    public interface IRequester<Res, Req, T> : IRequest<Req>, IResponse<Res> where T: IServiceClient
    {
        T Service { get; }
        object Execute(object request);
    }
}
