using System;

namespace Singleton_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try uncommenting this - note how it gives you an error. This is because the constructor is private - with Singletons, you should never be able to do this.
            //Cat badCat = new Cat("Snuffles");

            //Note that c1 and c2 both refer to the same instance of a Cat - I'm not instantiating two different Cat objects here
            //Also note how I call getInstance directly on "Cat" - this is because it's static
            Cat c1 = Cat.getInstance();
            Cat c2 = Cat.getInstance();

            //I didn't ask you to do this in the exercise, but if you wanted to call getName() you'd do it as usual:
            Console.WriteLine(c1.getName());
        }
    }
}
