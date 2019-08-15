using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecorations.Shapes.Decorators
{
    public class HugeSize : ShapeDecorator
    {
        /// <summary>
        /// See the RedColor class for details on the implementation
        /// </summary>
        /// <param name="decorated">The IShape (whtether concrete IShape or concrete ShapeDecorator) to be decorated</param>
        public HugeSize(IShape decorated) : base(decorated) { }
        public override void Draw()
        {
            _decorated.Draw();
            Console.WriteLine("\tThat is enourmous in size");
        }
    }
}
