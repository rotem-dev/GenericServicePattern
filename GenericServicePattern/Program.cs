using GenericServicePattern.Models;
using System;

namespace GenericServicePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarServiceAmadues carsService = new CarServiceAmadues();
            carsService.GetCar(new CarQuery { Id = 4, SearchString = "lalal" });

            CarServiceYaya wcf = new CarServiceYaya();
            wcf.FixCar(new Car { CarName = "Boten" });
        }
    }
}
