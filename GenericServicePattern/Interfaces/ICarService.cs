using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Interfaces
{
    public interface ICarService : IGetCar, IFixCar
    {

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
