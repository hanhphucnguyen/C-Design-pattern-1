using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Example
{
    //This is another concrete implementor class, which implements the implementor interface iWindowImp
    public class MacWindow : iWindowImp
    {
        public void DrawLine()
        {
            Console.WriteLine("Mac: ------");
        }

        public void DrawText()
        {
            Console.WriteLine("Here's some Mac text");
        }
    }
}
