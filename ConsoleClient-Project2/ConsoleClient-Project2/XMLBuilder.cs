using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public class XMLBuilder :IBuilder
    {
        private XMLComposite _root;
        private Stack<XMLComposite> _lastCompositeStack;
        public XMLBuilder()
        {
            _root = new XMLComposite("root");
            _lastCompositeStack = new Stack<XMLComposite>();
            _lastCompositeStack.Push(_root);
        }

        public void BuildBranch(string key)
        {
            var element = new XMLComposite(key);
            _lastCompositeStack.Peek().AddChild(element);
            _lastCompositeStack.Push(element);
        }

        public void BuildLeaf(string key, string val)
        {
            _lastCompositeStack.Peek().AddChild(new XMLLeaf(key, val));
        }

        public void CloseBranch()
        {
            _lastCompositeStack.Pop();
        }

        public IComposite GetDocument()
        {
            return _root;
        }
    }
}
