using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Exercise_Solution
{
    public abstract class AnimalDecorator : iAnimal
    {
        protected iAnimal decorated;

        public AnimalDecorator(iAnimal decorated)
        {
            this.decorated = decorated;
        }

        public abstract void printAnimal();
    }
}
