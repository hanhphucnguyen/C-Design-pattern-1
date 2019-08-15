using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Exercise_Solution
{
    public class Fluffy : AnimalDecorator
    {
        public Fluffy(iAnimal decorated) : base(decorated) { }
        public override void printAnimal()
        {
            Console.WriteLine("This is a fluffy animal");
            decorated.printAnimal();
        }
    }
}
