using GenericServicePattern.Interfaces;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Abstracts
{
    public abstract class CarService<T> : ICarService where T : IServiceClient
    {
        protected Requester<bool, Car, T> FixCarRequester { get; set; }
        protected Requester<Car, CarQuery, T> GetCarRequester { get; set; }

        public virtual bool FixCar(Car car)
        {
            return FixCarRequester.Execute(car);
        }

        public virtual Car GetCar(CarQuery query)
        {
            return GetCarRequester.Execute(query);
        }
    }
}
