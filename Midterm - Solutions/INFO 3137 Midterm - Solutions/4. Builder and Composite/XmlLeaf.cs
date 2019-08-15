using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public class XmlLeaf : IComposite
    {
        private string _tagName;
        private string _content;

        public XmlLeaf(string tagName, string content)
        {
            _tagName = tagName;
            _content = content;
        }
        public void Add(IComposite composite)
        {
        }

        public void Print(int depth)
        {
            for(int index = 0; index < depth; index++)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"<{_tagName}>{_content}</{_tagName}>");
        }
    }
}
