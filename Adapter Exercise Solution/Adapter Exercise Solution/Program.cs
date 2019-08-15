using System;

namespace Adapter_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat catOne = new ObjectAdapter();
            Cat catTwo = new ClassAdapter();

            catOne.makeSound();
            catTwo.makeSound();
            
        }
    }
}
