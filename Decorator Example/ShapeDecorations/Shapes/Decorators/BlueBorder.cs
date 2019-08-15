using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecorations.Shapes.Decorators
{
    /// <summary>
    /// See the RedColor class for details on the implementation
    /// </summary>
    public class BlueBorder : ShapeDecorator
    {
        public BlueBorder(IShape decorated) : base(decorated) { }
        public override void Draw()
        {
            _decorated.Draw();
            Console.WriteLine("\tWith a blue border");
        }
    }
}
