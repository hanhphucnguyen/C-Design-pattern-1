using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class ListProperties : IElementProperties
    {
        public enum ListType
        {
            Ordered, Unordered
        }

        public ListType Type { get; set; }
        public List<string> Items { get; set; }
    }
}
