using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var facade = new Facade();
            var vehicles = facade.buildVehicles();

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Type:    {vehicle.Type}");
                Console.WriteLine($"Engine:  {vehicle.EngineType}");
                Console.WriteLine($"Seats:   {vehicle.NumberOfSeats}");
                Console.WriteLine($"Doors:   {vehicle.NumberOfDoors}");
                Console.WriteLine($"Wheels:  {vehicle.NumberOfWheels}");
                Console.WriteLine();
            }

            var tricycle = facade.buildVehicle("Tricycle");
            Console.WriteLine($"Type:    {tricycle.Type}");
            Console.WriteLine($"Engine:  {tricycle.EngineType}");
            Console.WriteLine($"Seats:   {tricycle.NumberOfSeats}");
            Console.WriteLine($"Doors:   {tricycle.NumberOfDoors}");
            Console.WriteLine($"Wheels:  {tricycle.NumberOfWheels}");
            Console.WriteLine();

        }
    }
}
