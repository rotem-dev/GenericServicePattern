using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Interfaces
{
    public interface IRequest<T>
    {
        T ConvertRequest(object request);
    }
}
