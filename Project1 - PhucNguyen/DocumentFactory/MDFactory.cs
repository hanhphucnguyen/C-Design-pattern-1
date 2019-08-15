using System.IO;

namespace DocumentFactory
{
    public class MDFactory : IDocumentFactory
    {
        private static MDFactory _instance;
        private MDFactory() {}

        public static MDFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MDFactory();
            }
            return _instance;
        }

        public IDocument CreateDocument(string props)
        { 
            return new MDdocument(props);
        }

        public IElement CreateElement(string elementType, string props)
        {
            var temp = new MDelement();
            return temp.MakeMDelement( elementType, props);
        }
    }
}