using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class HtmlImage : HtmlElement
    {
        private ImageProperties _props;

        public HtmlImage(ImageProperties props)
        {
            _props = props;
        }

        public override string ToString()
        {
            return $"<img alt='{_props.AltText}' title='{_props.TitleText}' src='{_props.Uri}' /><br />";
        }
    }
}
