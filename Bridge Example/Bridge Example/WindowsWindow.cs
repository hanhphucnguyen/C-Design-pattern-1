using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Example
{
    //This is one of the concrete implementors, which implements the implementor class
    public class WindowsWindow : iWindowImp
    {
        public void DrawLine()
        {
            Console.WriteLine("Windows: ------");
        }

        public void DrawText()
        {
            Console.WriteLine("Here's some Windows specific text");
        }
    }
}
