using GenericServicePattern.Implementations.Amadeus.Requesters;
using GenericServicePattern.Implementations.Clients;
using GenericServicePattern.Interfaces;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Implementations.Amadeus
{
    public class CarServiceAmadues : ICarService<IServiceClient<HttpClient>>
    {
       

        public CarServiceAmadues()
        {
            var service = new ServiceClientHttpClient();
            FixCarRequester = new FixCarRequesterAmadues(service);
            GetCarRequester = new GetCarRequesterAmadeus(service);
        }

        public IRequester<bool, Car, IServiceClient<HttpClient>> FixCarRequester { get; private set; }

        public IRequester<Car, CarQuery, IServiceClient<HttpClient>> GetCarRequester { get; private set; }

        public bool FixCar(Car car)
        {
            return (bool)FixCarRequester.Execute(car);
        }

        public Car GetCar(CarQuery query)
        {
            return (Car)GetCarRequester.Execute(query);
        }
    }
}
