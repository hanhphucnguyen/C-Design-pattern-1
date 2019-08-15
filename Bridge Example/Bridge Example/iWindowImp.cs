using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Example
{
    //This class is the implementor. It gets implemented by concrete classes. 
    public interface iWindowImp 
    {
        void DrawText();
        void DrawLine();
    }
}
