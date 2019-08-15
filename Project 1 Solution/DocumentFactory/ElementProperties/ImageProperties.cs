using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class ImageProperties : IElementProperties
    {
        public string Uri { get; set; }
        public string AltText { get; set; }
        public string TitleText { get; set; }
    }
}
