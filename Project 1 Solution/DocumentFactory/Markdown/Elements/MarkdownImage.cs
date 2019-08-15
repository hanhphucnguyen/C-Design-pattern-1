using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownImage : MarkdownElement
    {
        private ImageProperties _props;

        public MarkdownImage(ImageProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            return $"![{_props.AltText}]({_props.Uri} \"{_props.TitleText}\")\n";
        }
    }
}
