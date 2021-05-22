using System.Collections.Generic;
using System.Threading.Tasks;
using Requesters.Enums;

namespace Requesters.Interfaces
{
    public interface IRequester<TResponse>
    {
        public ExternalServices ServiceType { get; }
        void SetQueryDictionary(Dictionary<string, string> queryDictionary);
        Task<IEnumerable<TResponse>> GetCarInfo();
        Task<TResponse> FixCar();
    }
}