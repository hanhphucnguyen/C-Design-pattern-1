using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Exercise_Solution
{
    class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside rectangle's draw method");
        }
    }
}
