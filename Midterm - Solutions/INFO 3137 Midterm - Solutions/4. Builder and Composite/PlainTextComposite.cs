using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public class PlainTextComposite : IComposite
    {
        private string _name;
        private List<IComposite> _children;

        public PlainTextComposite(string name)
        {
            _name = name;
            _children = new List<IComposite>();
        }

        public void Add(IComposite composite)
        {
            _children.Add(composite);
        }

        public void Print(int depth)
        {
            for (int index = 0; index < depth; index++)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"{_name}:");

            foreach (var child in _children)
            {
                child.Print(depth + 1);
            }
        }
    }
}
