using System;

namespace Decorator_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Mean meanBird = new Mean(bird);
            meanBird.printAnimal();

            Console.WriteLine();

            Dog dog = new Dog();
            Fluffy fluffyDog = new Fluffy(dog);
            Fat fatFluffyDog = new Fat(fluffyDog);
            fatFluffyDog.printAnimal();

            Console.WriteLine();

            Cat cat = new Cat();
            Fat meanFatFluffyCat = new Fat(new Fluffy(new Mean(cat))); //doing essentially the same thing as above, except in one line with anonymous objects
            meanFatFluffyCat.printAnimal(); 

        }
    }
}
