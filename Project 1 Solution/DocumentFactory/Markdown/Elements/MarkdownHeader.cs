using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownHeader : MarkdownElement
    {
        private HeaderProperties _props;
        public MarkdownHeader(HeaderProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            return $"{new string('#', _props.HeaderLevel)} {_props.Text}\n";
        }
    }
}
