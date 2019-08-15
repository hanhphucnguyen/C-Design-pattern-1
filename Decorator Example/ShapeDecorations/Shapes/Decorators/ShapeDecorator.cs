using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecorations.Shapes.Decorators
{
    public abstract class ShapeDecorator : IShape
    {
        /// <summary>
        /// Maintains a reference to the shape which it decorates
        /// this allows implementors to add additional steps to the "drawing" process.
        /// 
        /// Marked "protected" so that inheriting classes have access to it.
        /// </summary
        protected IShape _decorated;

        /// <summary>
        /// Acceps a reference to any IShape.
        /// 
        /// Since the ShapeDecorator itself IS an IShape, this
        /// decorator can also decorate other decorators
        /// 
        /// However, since a ShapeDecorator has to be instantiated with an existing IShape, 
        /// at some point in the chain of decoration, there must be a concrete shape
        /// (specifically, a concrete IShape that was createad without having another IShape passed to it)
        /// </summary>
        /// <param name="decorated"></param>
        public ShapeDecorator(IShape decorated)
        {
            _decorated = decorated;
        }

        /// <summary>
        /// Marking this abstract satisfies the implementation of IShape,
        /// but forces inheriting classes to implement their own drawing logic
        /// </summary>
        public abstract void Draw();
    }
}
