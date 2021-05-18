using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Interfaces
{
    public interface IResponse<T>
    {
        T ConvertResponse(object response);
    }
}
