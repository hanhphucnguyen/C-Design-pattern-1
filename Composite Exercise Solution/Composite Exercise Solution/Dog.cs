using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Exercise_Solution
{
    //This is a leaf class
    public class Dog : Animal
    {
        private string name;
        private int age;
        private string favouriteToy;
        public Dog(string n, int a, string f)
        {
            name = n;
            age = a;
            favouriteToy = f;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name: '{name}'");
            Console.WriteLine($"Age: '{age}'");
            Console.WriteLine($"Favourite toy: '{favouriteToy}'");
        }
    }
}
