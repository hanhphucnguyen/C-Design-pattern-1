using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Exercise_Solution
{
    public abstract class Shape
    {
        protected DrawAPI api;

        protected Shape(DrawAPI a)
        {
            api = a;
        }

        public abstract void Draw();

    }
}
