using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Exercise_Solution
{
    public class Fat : AnimalDecorator
    {
        public Fat(iAnimal decorated) : base(decorated) { }
        public override void printAnimal()
        {
            Console.WriteLine("This is a fat animal.");
            decorated.printAnimal();
        }
    }
}
