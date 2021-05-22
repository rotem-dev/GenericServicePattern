using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using Requesters.Enums;
using Requesters.Interfaces;

namespace Requesters.RequestServices
{
    public abstract class AbstractRequester<TResponse> : IRequester<TResponse>
    {
        protected Uri BaseUrl { get; }
        protected Dictionary<string, string> _queryDictionary;
        public ExternalServices ServiceType { get; }

        protected AbstractRequester(string baseUrl, ExternalServices serviceType)
        {
            BaseUrl = new Uri(baseUrl);
            ServiceType = serviceType;
        }

        public void SetQueryDictionary(Dictionary<string, string> queryDictionary)
        {
            _queryDictionary = queryDictionary;
        }

        public abstract Task<IEnumerable<TResponse>> GetCarInfo();

        public abstract Task<TResponse> FixCar();
    }
}