using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Exercise_Solution
{
    public class Cat : iAnimal
    {
        public void printAnimal()
        {
            Console.WriteLine("This is a cat");
        }
    }
}
