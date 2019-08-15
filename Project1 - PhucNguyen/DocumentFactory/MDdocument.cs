using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    public class MDdocument :IDocument
    {
        private string _props;
        private string content = "";
        public MDdocument(string props)
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
