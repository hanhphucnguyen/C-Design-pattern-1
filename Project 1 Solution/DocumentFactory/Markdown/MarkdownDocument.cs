using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownDocument : IDocument
    {
        private string _fileName;
        private List<MarkdownElement> _elements;

        public MarkdownDocument(string fileName)
        {
            _fileName = fileName;
        }
        public void AddElement(IElement element)
        {
            if(_elements == null)
            {
                _elements = new List<MarkdownElement>();
            }
            _elements.Add(element as MarkdownElement);
        }

        public void RunDocument()
        {
            using (var writer = new StreamWriter(_fileName))
            {
                foreach(var element in _elements)
                {
                    writer.WriteLine(element.ToString());
                }
            }

            var index = new FileInfo(_fileName);
            System.Diagnostics.Process.Start("chrome.exe", $"--homepage {index.FullName}");
        }
    }
}
