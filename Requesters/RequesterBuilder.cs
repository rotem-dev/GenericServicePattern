using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Requesters.Enums;
using Requesters.Interfaces;
using Requesters.RequestServices;

namespace Requesters
{
    public class RequesterBuilder<TResponse>
    {
        private IReadOnlyList<IRequester<TResponse>> _services;
        private List<IRequester<TResponse>> _selectedServices;
        private Dictionary<string, string> _queryDictionary;

        public RequesterBuilder()
        {
            // Replace this line with a provider to maintain open/closed principle
            _services = new List<IRequester<TResponse>> {new AmadeusRequester<TResponse>()};
            _queryDictionary = new Dictionary<string, string>();
        }

        public RequesterBuilder<TResponse> WithTargetServices(ExternalServices service)
        {
            _selectedServices = _services.Where(x => x.ServiceType.HasFlag(service)).ToList();
            return this;
        }

        public RequesterBuilder<TResponse> WithRequestObject(object requestObject)
        {
            if (requestObject == null || _queryDictionary.Count > 0)
                return this;
            var props = requestObject.GetType().GetProperties();
            foreach (var propertyInfo in props)
            {
                var value = propertyInfo.GetValue(requestObject, new object[] { }).ToString();
                _queryDictionary.Add(propertyInfo.Name, value);
            }
            return this;
        }

        public List<IRequester<TResponse>> Build()
        {
            _selectedServices ??= new List<IRequester<TResponse>>(_services); // If not services selected, select all services
            if (_queryDictionary.Count > 0)
                foreach (var service in _selectedServices)
                {
                    service.SetQueryDictionary(_queryDictionary);
                }
            return _selectedServices;
        }
    }
}
