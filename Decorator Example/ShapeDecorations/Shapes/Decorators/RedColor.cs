using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecorations.Shapes.Decorators
{
    public class RedColor : ShapeDecorator
    {
        /// <summary>
        /// Public ctor. Calls the base class with the passed IShape, thus decorating it.
        /// Implementation is left empty, as the base class does all the work needed.
        /// </summary>
        /// <param name="decorated"></param>
        public RedColor(IShape decorated) : base(decorated) { }

        /// <summary>
        /// Performs the actual drawing logic, but first calls the decorated member, 
        /// adding its own logic afterwards.
        /// </summary>
        public override void Draw()
        {
            // First calls decorated member
            _decorated.Draw();

            // Then adds additional drawing logic
            Console.WriteLine("\tWhich is red in color");
        }
    }
}
