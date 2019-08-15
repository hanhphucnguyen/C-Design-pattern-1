using System;

namespace Factory_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            IShape circle = factory.GetShape("Circle");
            IShape rectangle = factory.GetShape("Rectangle");
            IShape square = factory.GetShape("Square");

            circle.draw();
            rectangle.draw();
            square.draw();
           
        }
    }
}
