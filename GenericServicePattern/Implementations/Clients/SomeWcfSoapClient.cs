using GenericServicePattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericServicePattern.Implementations.Clients
{
    public class SomeWcfSoapClient
    {
        public SomeWcfSoapClient()
        {

        }

        public List<Car> GetCars(object c)
        {
            return new List<Car>();
        }

        public void FixCars(Car c)
        {
            Console.WriteLine("Car fixed.");
        }
    }
}
