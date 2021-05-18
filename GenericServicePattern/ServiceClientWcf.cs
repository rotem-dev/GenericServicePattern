using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern
{
    public class ServiceClientWcf : IServiceClient<SomeWcfSoapClient>
    {
        public SomeWcfSoapClient Client { get; private set; }

        object IServiceClient.Client => Client;

        public ServiceClientWcf()
        {
            Client = new SomeWcfSoapClient();
        }
    }
}
