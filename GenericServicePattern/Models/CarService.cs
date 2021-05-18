using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Models
{
    public class CarService : ICarService<IServiceClient<HttpClient>>
    {
       

        public CarService()
        {
            var service = new ServiceClientHttpClient();
            FixCarRequester = new FixCarRequester(service);
            GetCarRequester = new GetCarRequester(service);
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
