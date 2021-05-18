using GenericServicePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Models
{
    public class CarServiceWcf : ICarService<IServiceClient<SomeWcfSoapClient>>
    {
        public CarServiceWcf()
        {
            FixCarRequester = new FixCarRequesterWcf();
            GetCarRequester = new GetCarRequesterWcf();
        }

        public IRequester<bool, Car, IServiceClient<SomeWcfSoapClient>> FixCarRequester { get; private set; }

        public IRequester<Car, CarQuery, IServiceClient<SomeWcfSoapClient>> GetCarRequester { get; private set; }

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
