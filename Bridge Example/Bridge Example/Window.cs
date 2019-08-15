using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Example
{

    //This is the abstractor 
    public abstract class Window
    {
        protected iWindowImp windowImp;

        public Window(iWindowImp w)
        {
            windowImp = w;
        }

       public abstract void drawRect();
       public abstract void drawText();
    }
}
