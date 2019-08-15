using System.IO;

namespace DocumentFactory
{
    public class HTMLdocument : IDocument
    {
        private string _props;
        private string content = "";
        public HTMLdocument(string props)
        {
            _props = props;
            using (File.Create(_props)) { }
        }
        public void AddElement(IElement element)
        {
            content += element.createMD();
        }
        public void RunDocument()
        {
            File.WriteAllText(_props, content);
        }
    }
}