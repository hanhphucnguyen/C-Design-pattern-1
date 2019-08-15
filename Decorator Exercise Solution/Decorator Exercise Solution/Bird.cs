using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Exercise_Solution
{
    public class Bird : iAnimal
    {
        public void printAnimal()
        {
            Console.WriteLine("This is a bird.");
        }
    }
}
