using GenericServicePattern.Models;
using System;

namespace GenericServicePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService carsService = new CarService();
            carsService.GetCar(new CarQuery { Id = 4, SearchString = "lalal" });

            CarServiceWcf wcf = new CarServiceWcf();
            wcf.FixCar(new Car { CarName = "Boten" });
        }
    }
}
