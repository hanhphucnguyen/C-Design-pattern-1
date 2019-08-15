using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public class XmlComposite : IComposite
    {
        private string _tagName;
        private List<IComposite> _children;

        public XmlComposite(string tagName)
        {
            _tagName = tagName;
            _children = new List<IComposite>();
        }

        public void Add(IComposite composite)
        {
            _children.Add(composite);
        }

        public void Print(int depth)
        {
            for(int index = 0; index < depth; index++)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"<{_tagName}>");

            foreach(var child in _children)
            {
                child.Print(depth + 1);
            }

            for (int index = 0; index < depth; index++)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"</{_tagName}>");
        }
    }
}
