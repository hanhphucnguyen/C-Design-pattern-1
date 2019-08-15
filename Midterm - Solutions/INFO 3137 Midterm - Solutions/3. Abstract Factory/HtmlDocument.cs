using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Abstract_Factory
{
    public class HtmlDocument : IDocument
    {
        private List<HtmlElement> _elements;
        public void AddElement(IElement element)
        {
            if(element is HtmlElement)
            {
                _elements.Add(element as HtmlElement);
            }
        }

        public int ElementCount()
        {
            return _elements.Count();
        }
    }
}
