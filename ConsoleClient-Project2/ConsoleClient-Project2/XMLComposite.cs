using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public class XMLComposite: IComposite
    {
        private string _tagname;
        private List<IComposite> _children;
        private string temp;

        public XMLComposite(string name)
        {
            _tagname = name;
            _children = new List<IComposite>();
        }

        public void AddChild(IComposite composite)
        {
            _children.Add(composite);
        }

        public string Print(int depth)
        {
            for (int index = 0; index < depth; index++)
            {
                temp += "\t";
                Console.Write("\t");
            }
            temp += "<"+_tagname + ">\n";
            Console.WriteLine($"<{_tagname}>");

            foreach (var child in _children)
            {
                child.Print(depth + 1);
            }

            for (int index = 0; index < depth; index++)
            {
                //temp += "\t";
                Console.Write("\t");
            }
            temp += "</" + _tagname + ">\n";
            Console.WriteLine($"</{_tagname}>");
            return temp;
        }
    }
}
