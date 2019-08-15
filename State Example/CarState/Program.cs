using System;

namespace CarState
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            string input;
            bool keepRunning = true;

            Console.WriteLine("Welcome to the Driving Simulater");
            Console.WriteLine();
            Console.WriteLine("Usage:");
            Console.WriteLine("    turn-clockwise  -Turns the car's key clockwise");
            Console.WriteLine("    turn-counter    -Turns the car's key counter clockwise");
            Console.WriteLine("    gas             -Presses the gas pedal");
            Console.WriteLine("    brake           -Presses the brake pedal");
            Console.WriteLine("    exit            -Exits the simulator");
            Console.WriteLine();


            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                Console.WriteLine();
                keepRunning = car.HandleInput(input);

            } while (keepRunning);
            Console.WriteLine();
            Console.WriteLine("goodbye");
            Console.WriteLine();
        }
    }
}
