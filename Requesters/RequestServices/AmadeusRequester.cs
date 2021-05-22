using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Requesters.Enums;
using Requesters.Extensions;
using Requesters.Interfaces;

namespace Requesters.RequestServices
{
    public class AmadeusRequester<TResponse> : AbstractRequester<TResponse>
    {
        private HttpClient _httpClient;

        public AmadeusRequester() : base("https://Amadeus.com:12725", ExternalServices.Amadeus)
        {
            _httpClient = new HttpClient();
        }

        public override async Task<IEnumerable<TResponse>> GetCarInfo()
        {
            var apiPath = "/api/v1/cars" + _queryDictionary.ToQueryParameters();
            var uri = new Uri(BaseUrl, apiPath);
            //var responseString = await _httpClient.GetStringAsync(uri);
            Console.WriteLine($"DEBUG: Sending query '{uri}'");
            await Task.Delay(1000);
            var responseString = MockResponse();
            try
            {
                return JsonConvert.DeserializeObject<IEnumerable<TResponse>>(responseString);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Response was null: {ex.Message}");
            }

            return null;
        }

        public override Task<TResponse> FixCar()
        {
            throw new System.NotImplementedException();
        }

        private string MockResponse()
        {
            if (_queryDictionary == null || _queryDictionary.Count == 0)
                return "[{\"Id\" : 1, \"CarName\" : \"Mercedes\", \"CarColor\" : \"White\"}, {\"Id\" : 2, \"CarName\" : \"Ferrari\", \"CarColor\" : \"Red\"}]";
            else
            {
                return "[{\"Id\" : 2, \"CarName\" : \"Ferrari\", \"CarColor\" : \"Red\"}]";
            }
        }
    }
}