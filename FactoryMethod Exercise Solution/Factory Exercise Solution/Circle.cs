using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Exercise_Solution
{
    class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle's draw method");
        }
    }
}
