using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Interfaces
{
    public interface IServiceClient<T> : IServiceClient
    {
        new T Client { get; }
    }

    public interface IServiceClient
    {
        object Client { get; }
    }
}
