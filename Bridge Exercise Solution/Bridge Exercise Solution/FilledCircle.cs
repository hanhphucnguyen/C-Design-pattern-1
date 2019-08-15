using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Exercise_Solution
{
    public class FilledCircle : Shape
    {
        public FilledCircle(DrawAPI api) : base(api)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Pretend this shape is filled");
            api.DrawCircle();
        }
    }
}
