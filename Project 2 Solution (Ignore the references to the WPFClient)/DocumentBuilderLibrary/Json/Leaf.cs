using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Json
{
    public class Leaf : IComposite
    {
        private string _name;
        private string _content;
        private bool _hasSibling;

        public Leaf(string name, string content)
        {
            _name = name;
            _content = content;
            _hasSibling = false;
        }

        public Leaf(Leaf leaf)
        {
            _name = leaf._name;
            _content = leaf._content;
            _hasSibling = true;
        }

        public void AddChild(IComposite child) { }

        public string Print(int depth)
        {
            string value = "";

            value += new string(' ', depth * 4);
            value += $"'{_name}' : '{_content}'";

            value += _hasSibling ? ",\n" : "\n";

            return value;
        }
    }
}
