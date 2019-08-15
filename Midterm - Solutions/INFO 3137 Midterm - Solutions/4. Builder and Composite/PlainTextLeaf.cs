using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public class PlainTextLeaf : IComposite
    {
        private string _name;
        private string _content;

        public PlainTextLeaf(string name, string content)
        {
            _name = name;
            _content = content;
        }
        public void Add(IComposite composite)
        {
        }

        public void Print(int depth)
        {
            for (int index = 0; index < depth; index++)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"{_name}: {_content}");
        }
    }
}
