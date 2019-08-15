using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Exercise_Solution
{
    class Cat
    {
        //Note that this must be static. Why? Because the point is to have one instance that's easily accessible
        private static Cat c;

        private string name;
        //We need to make the constructor private so that people can't instantiate multiple Cat objects
        private Cat(String n)
        {
            name = n;
        }

        //This method must be static since we're calling it on the class in some main method, rather than on some object (the whole point is that we shouldn't be instantiating objects in the main method in the first place)
        public static Cat getInstance()
        {
            if (c == null)
            {
                c = new Cat("Snuffles"); // Just an arbitrary default name - it doesn't matter what you chose here
                return c;
            }
            else
            {
                return c;
            }
        }

        //This method, however, doesn't have to be static. Presumably, you'd call getInstance on the Cat class somewhere else,
        //assign what it returns to a Cat variable, and then call this instance method on that variable (see Program.cs)
        public string getName()
        {
            return name;
        }


    }
}
