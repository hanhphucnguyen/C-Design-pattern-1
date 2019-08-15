using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Json
{
    public class Branch : IComposite
    {
        private List<IComposite> _children;
        private string _name;
        private bool _isRoot;
        private bool _hasSibling;

        public Branch(string name, bool isRoot = false)
        {
            _name = name;
            _children = new List<IComposite>();
            _isRoot = isRoot;
            _hasSibling = false;
        }

        public Branch(Branch composite)
        {
            _name = composite._name;
            _children = composite._children;
            _isRoot = composite._isRoot;
            _hasSibling = true;
        }

        public void AddChild(IComposite child)
        {
            if(_children.Any())
            {
                if (_children.Last() is Branch)
                {
                    _children[_children.Count - 1] = new Branch(_children[_children.Count - 1] as Branch);
                }
                else
                {
                    _children[_children.Count - 1] = new Leaf(_children[_children.Count - 1] as Leaf);
                }
            }
            _children.Add(child);
        }

        public string Print(int depth)
        {
            string value = "";

            if (_isRoot)
            {

                value += new string(' ', depth * 4);
                value += "{\n";

                foreach (var child in _children)
                {
                    value += child.Print(depth + 1);
                }

                value += new string(' ', depth * 4);
                value += "}";

                return value;
            }

            value += new string(' ', depth * 4);
            value += $"'{_name}' :\n";
            value += new string(' ', depth * 4);
            value += "{\n";

            foreach (var child in _children)
            {
                value += child.Print(depth + 1);
            }

            value += new string(' ', depth * 4);
            value += "}";

            value += _hasSibling ? ",\n" : "\n";

            return value;
        }
    }
}
