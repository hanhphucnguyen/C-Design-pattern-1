using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Exercise_Solution
{
    class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Inside square's draw method");
        }
    }
}
