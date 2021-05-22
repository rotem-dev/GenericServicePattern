using GenericServicePattern.Implementations.Amadeus;
using GenericServicePattern.Implementations.Yaya;
using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Requesters;
using Requesters.Enums;
using Requesters.Interfaces;
using Requesters.RequestServices;

namespace GenericServicePattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*CarServiceAmadues carsService = new CarServiceAmadues();
            carsService.GetCar(new CarQuery { Id = 4, SearchString = "lalal" });

            CarServiceYaya wcf = new CarServiceYaya();
            wcf.FixCar(new Car { CarName = "Boten" });
            */
            var allServices = new List<IRequester<Car>>
            {
                new AmadeusRequester<Car>()
            };
            var car = new Car {Id = 1, CarName = "Somename", CarColor = ConsoleColor.Red};
            var requesters = new RequesterBuilder<Car>()
                .WithTargetServices(ExternalServices.Amadeus)
                .WithRequestObject(new {CarColor = car.CarColor.ToString()})
                .Build();
            foreach (var requester in requesters)
            {
                var result = await requester.GetCarInfo();
                foreach (var carResult in result)
                {
                    Console.WriteLine($"Response - Id = {carResult.Id}, Name = {carResult.CarName}, Color = {carResult.CarColor}");
                }
                
            }

            requesters = new RequesterBuilder<Car>()
                .WithTargetServices(ExternalServices.Amadeus)
                .Build();
            foreach (var requester in requesters)
            {
                var result = await requester.GetCarInfo();
                foreach (var carResult in result)
                {
                    Console.WriteLine($"Response - Id = {carResult.Id}, Name = {carResult.CarName}, Color = {carResult.CarColor}");
                }

            }
        }
    }
}
