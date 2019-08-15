using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Abstract_Factory
{
    public class MarkdownDocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocument()
        {
            return new MarkdownDocument();
        }

        public IElement CreateElement()
        {
            return new MarkdownElement();
        }
    }
}
