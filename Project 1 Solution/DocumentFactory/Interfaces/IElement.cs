using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public interface IElement
    {
    }
    public class EmptyElement : IElement
    {
        public override string ToString()
        {
            return string.Empty;
        }
    }
}
