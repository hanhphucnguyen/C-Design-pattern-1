using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Xml
{
    public class Leaf : IComposite
    {
        private string _name;
        private string _content;
        public Leaf(string name, string content)
        {
            _name = name;
            _content = content;
        }
        public void AddChild(IComposite child) { }

        public string Print(int depth)
        {
            string value = "";
            value += new string(' ', depth * 4);
            value += $"<{_name}>{_content}</{_name}>\n";
            return value;
        }
    }
}
