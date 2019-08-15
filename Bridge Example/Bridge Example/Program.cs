using System;

namespace Bridge_Example
{
    class Program
    {
        //In this main method I create some mac icon and transient windows and some windows icon and transient windows
        //Note that at no point have I defined a MacIconWindow class or a WindowsIconWindow class (i.e. the abstraction and implementation aren't bound permanently). Instead, these classes are put together when in instantiate objects in the main method (i.e. they're bound at runtime). 
        static void Main(string[] args)
        {
            Window w1 = new IconWindow(new MacWindow());
            Window w2 = new IconWindow(new WindowsWindow());
            Window w3 = new TransientWindow(new MacWindow());
            Window w4 = new TransientWindow(new WindowsWindow());

            w1.drawRect();
            w1.drawText();

            w2.drawRect();
            w2.drawText();

            w3.drawRect();
            w3.drawText();

            w4.drawRect();
            w4.drawText();

        }
    }
}
