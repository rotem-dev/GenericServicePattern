using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Interfaces
{
    public interface ICarService<T> : IGetCar, IFixCar where T: IServiceClient
    {
        IRequester<bool, Car, T> FixCarRequester { get; }
        IRequester<Car, CarQuery, T> GetCarRequester { get; }
    }

    public interface IGetCar
    {        
        Car GetCar(CarQuery query);
    }

    public interface IFixCar
    {
        bool FixCar(Car car);
    }
}
