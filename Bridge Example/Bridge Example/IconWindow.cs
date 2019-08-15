using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Example
{
    //This is one of the refined abstraction classes. Note that it can make use of windowImp since it inherits it from its superclass. Note also that since MacWindow and WindowsWindow implement iWindowImp, their specific drawLine() and drawText() methods will be called, depending on what's passed into the constructor (see the main method)
    public class IconWindow : Window
    {
        public IconWindow(iWindowImp w) : base(w)
        {

        }
        public override void drawRect()
        {
            Console.WriteLine("Pretend this is on an icon window: ");
            windowImp.DrawLine();
            windowImp.DrawLine();
            windowImp.DrawLine();
            windowImp.DrawLine();
        }
        public override void drawText()
        {
            Console.WriteLine("Pretend this is on an icon window: ");
            windowImp.DrawText();
        }
    }
}
