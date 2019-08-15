using System;

namespace State_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool keepRunning = true;
            var computer = new Computer();
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                Console.WriteLine();
                keepRunning = computer.HandleInput(input);
            } while (keepRunning);
        }
    }
}
