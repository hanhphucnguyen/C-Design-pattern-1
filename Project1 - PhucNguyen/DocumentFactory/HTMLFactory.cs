using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    public class HTMLFactory : IDocumentFactory
    {
        private static HTMLFactory _instance;
        private HTMLFactory() { }

        public static HTMLFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HTMLFactory();
            }
            return _instance;
        }

        public IDocument CreateDocument(string props)
        {
            return new HTMLdocument(props);
        }

        public IElement CreateElement(string elementType, string props)
        {
            var temp = new HTMLelement();
            return temp.MakeMDelement(elementType, props);
        }
    }
}
