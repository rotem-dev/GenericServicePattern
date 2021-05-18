using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern
{
    public class ServiceClientHttpClient : IServiceClient<HttpClient>
    {
        public HttpClient Client { get; }

        object IServiceClient.Client => Client;

        public object SendRequest(object request)
        {
            return "some baa blabl a";
        }

        public ServiceClientHttpClient()
        {
            Client = new HttpClient();
        }
    }
}
