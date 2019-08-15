using System;

namespace Composite_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Snuffles", 10, "Black");
            Dog d = new Dog("Fluffy", 2, "White");
            PetDirectory p = new PetDirectory();
            p.Add(c);
            p.Add(d);

            p.ShowDetails();
        }
    }
}
