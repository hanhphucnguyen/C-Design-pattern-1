using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Abstract_Factory
{
    public class MarkdownDocument : IDocument
    {
        private List<MarkdownElement> _elements;
        public void AddElement(IElement element)
        {
            if(element is MarkdownElement)
            {
                _elements.Add(element as MarkdownElement);
            }
        }

        public int ElementCount()
        {
            return _elements.Count();
        }
    }
}
