using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownList : MarkdownElement
    {
        private ListProperties _props;

        public MarkdownList(ListProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            switch (_props.Type)
            {
                case ListProperties.ListType.Ordered:
                    return OrderedToString();
                case ListProperties.ListType.Unordered:
                    return UnorderedToString();
                default:
                    return "";
            }
        }

        private string OrderedToString()
        {
            string list = "";
            int count = 1;
            foreach (var item in _props.Items)
            {
                list += $"{count++}. {item}\n";
            }
            return list;
        }

        private string UnorderedToString()
        {
            string list = "";
            foreach (var item in _props.Items)
            {
                list += $"* {item}\n";
            }
            return list;
        }
    }
}
