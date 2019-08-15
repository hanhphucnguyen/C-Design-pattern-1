using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class HtmlList : HtmlElement
    {
        private ListProperties _props;

        public HtmlList(ListProperties props)
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
            string list = "<ol>";
            foreach (var item in _props.Items)
            {
                list += $"<li>{item}</li>";
            }
            list += "</ol>";
            return list;
        }

        private string UnorderedToString()
        {
            string list = "<ul>";
            foreach (var item in _props.Items)
            {
                list += $"<li>{item}</li>";
            }
            list += "</ul>";
            return list;
        }
    }
}
