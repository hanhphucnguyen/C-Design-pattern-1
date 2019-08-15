using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Exercise_Solution
{
    public class Mean : AnimalDecorator
    {
        public Mean(iAnimal decorated) : base(decorated) { }
        public override void printAnimal()
        {
            Console.WriteLine("This is a mean animal");
            decorated.printAnimal();
        }
    }
}
