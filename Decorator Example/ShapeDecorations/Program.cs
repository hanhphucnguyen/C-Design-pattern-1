using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeDecorations.Shapes;
using ShapeDecorations.Shapes.Decorators;

namespace ShapeDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            // scoped to allow for re-use of variable names
            {
                // First create a concrete shape, since we need one to be able to decorate anything
                var circle = new Circle();
                circle.Draw();

                Console.WriteLine();

                // Now we decorate the shape with a red color
                var red = new RedColor(circle);
                red.Draw();

                Console.WriteLine();

                // Since the decorator itself is an IShape, we can further decorate it
                var blueBorder = new BlueBorder(red);
                blueBorder.Draw();

                Console.WriteLine();

                // And can continue to decorate each ShapeDecorator with as many decorator classes as we like
                var huge = new HugeSize(blueBorder);
                huge.Draw();

                Console.WriteLine();
            }

            {
                // Always must start with a concrete IShape implementation
                var rect = new Rectangle();
                rect.Draw();

                Console.WriteLine();

                // Note that the order in which we decorate doesn't matter
                var blueBorder = new BlueBorder(rect);
                blueBorder.Draw();

                Console.WriteLine();

                var huge = new HugeSize(blueBorder);
                huge.Draw();

                Console.WriteLine();

                var red = new RedColor(huge);
                red.Draw();

                Console.WriteLine();
            }
        }
    }
}
