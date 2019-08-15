using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public class PlainTextBuilder : IBuilder
    {
        private PlainTextComposite _root;
        private Stack<PlainTextComposite> _lastCompositeStack;

        public PlainTextBuilder()
        {
            _root = new PlainTextComposite("planes");
            _lastCompositeStack = new Stack<PlainTextComposite>();
            _lastCompositeStack.Push(_root);
        }

        public void BuildComposite(string key)
        {
            var element = new PlainTextComposite(key);
            _lastCompositeStack.Peek().Add(element);
            _lastCompositeStack.Push(element);
        }

        public void BuildLeaf(string key, string val)
        {
            _lastCompositeStack.Peek().Add(new PlainTextLeaf(key, val));
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
