using GenericServicePattern.Models;
using System;

namespace GenericServicePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient service = new ServiceClient();
            CarService carsService = new CarService(service);
            carsService.GetCar(new CarQuery { Id = 4, SearchString = "lalal" });
        }
    }
}
