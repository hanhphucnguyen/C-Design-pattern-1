using System;
using System.Collections.Generic;
using System.Text;


namespace Observer_Example
{
    public interface IObserver
    {
        void Update(); // called when the Subject updates
    }
}

