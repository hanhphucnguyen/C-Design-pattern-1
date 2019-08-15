using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Exercise_Solution
{
    public class EmptyCircle : Shape
    {
        public EmptyCircle(DrawAPI api) : base(api)
        {
            
        }

        public override void Draw()
        {
            Console.WriteLine("Pretend this shape is empty");
            api.DrawCircle();
        }
    }
}
