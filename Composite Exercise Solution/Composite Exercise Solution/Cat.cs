using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Exercise_Solution
{
    //This is a leaf class
    public class Cat : Animal
    {
        private string name;
        private int age;
        private string furColour;
        public Cat(string n, int a, string f)
        {
            name = n;
            age = a;
            furColour = f;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name: '{name}'");
            Console.WriteLine($"Age: '{age}'");
            Console.WriteLine($"Fur colour: '{furColour}'");
        }
    }
}
