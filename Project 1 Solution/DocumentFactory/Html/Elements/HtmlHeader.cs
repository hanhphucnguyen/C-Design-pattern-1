using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class HtmlHeader : HtmlElement
    {
        private HeaderProperties _props;
        public HtmlHeader(HeaderProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            return $"<h{_props.HeaderLevel}>{_props.Text}</h{_props.HeaderLevel}>";
        }
    }
}
