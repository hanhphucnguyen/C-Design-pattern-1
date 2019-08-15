using System;

namespace Bridge_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new FilledCircle(new RedCircle());
            Shape s2 = new EmptyCircle(new RedCircle());
            Shape s3 = new FilledCircle(new GreenCircle());
            Shape s4 = new EmptyCircle(new GreenCircle());

            s1.Draw();
            s2.Draw();
            s3.Draw();
            s4.Draw();
        }
    }
}
