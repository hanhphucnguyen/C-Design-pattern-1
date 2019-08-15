using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Xml
{
    public class Branch : IComposite
    {
        private List<IComposite> _children;
        private string _name;

        public Branch(string name)
        {
            _name = name;
            _children = new List<IComposite>();
        }
        public void AddChild(IComposite child)
        {
            _children.Add(child);
        }

        public string Print(int depth)
        {
            string value = "";

            value += new string(' ', depth * 4);
            value += $"<{_name}>\n";

            foreach (var child in _children)
            {
                value += child.Print(depth + 1);
            }

            value += new string(' ', depth * 4);
            value += $"</{_name}>";

            value += _name == "root" ? "" : "\n";

            return value;
        }
    }
}
