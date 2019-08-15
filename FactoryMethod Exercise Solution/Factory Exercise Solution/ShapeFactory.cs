using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Exercise_Solution
{
    class ShapeFactory 
    {
        public virtual IShape GetShape(string type)
        {
            switch (type)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                case "Rectangle":
                    return new Rectangle();
                default:
                    // no passed parameter or any non-known parameter returns null
                    return null;
            }
        }
    }
}
