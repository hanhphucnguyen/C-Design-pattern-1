using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public interface IDocument
    {
        void AddElement(IElement element);
        void RunDocument();
    }
}
