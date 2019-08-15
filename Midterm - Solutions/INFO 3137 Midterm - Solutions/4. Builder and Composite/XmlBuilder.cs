using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public class XmlBuilder : IBuilder
    {
        private XmlComposite _root;
        private Stack<XmlComposite> _lastCompositeStack;

        public XmlBuilder()
        {
            _root = new XmlComposite("planes");
            _lastCompositeStack = new Stack<XmlComposite>();
            _lastCompositeStack.Push(_root);
        }

        public void BuildComposite(string key)
        {
            var element = new XmlComposite(key);
            _lastCompositeStack.Peek().Add(element);
            _lastCompositeStack.Push(element);
        }

        public void BuildLeaf(string key, string val)
        {
            _lastCompositeStack.Peek().Add(new XmlLeaf(key, val));
        }

        public void CloseComposite()
        {
            _lastCompositeStack.Pop();
        }

        public void OutputResult()
        {
            _root.Print(0);
        }
    }
}
