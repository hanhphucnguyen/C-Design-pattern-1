using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class HeaderProperties : IElementProperties
    {
        public int HeaderLevel { get; set; }
        public string Text { get; set; }
    }
}
