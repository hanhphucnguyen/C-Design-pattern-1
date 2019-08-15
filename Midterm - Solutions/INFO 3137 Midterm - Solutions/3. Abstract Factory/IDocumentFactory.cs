using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Abstract_Factory
{
    public interface IDocumentFactory
    {
        IDocument CreateDocument();
        IElement CreateElement();
    }
}
