using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //var factory = new CarFactory();
            //factory.CreateCar("Car");
            //factory.CreateCar("Truck");
            //factory.CreateCar("Van");
            //factory.CreateCar("Coupe");

            var factory = new CarAndMotorcycleFactory();
            factory.CreateCar("Car");
            factory.CreateCar("Truck");
            factory.CreateCar("Van");
            factory.CreateCar("Coupe");
            factory.CreateCar("Motorcycle");
        }
    }
}
