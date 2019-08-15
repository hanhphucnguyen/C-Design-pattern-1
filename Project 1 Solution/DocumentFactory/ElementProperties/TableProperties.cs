using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class TableProperties : IElementProperties
    {
        public List<string> Headers;
        public List<List<string>> Rows;
    }
}
