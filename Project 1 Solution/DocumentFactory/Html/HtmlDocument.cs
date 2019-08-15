using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentFactory
{
    public class HtmlDocument : IDocument
    {
        private string _fileName;
        private List<HtmlElement> _elements;

        public HtmlDocument(string fileName)
        {
            _fileName = fileName;
        }
        public void AddElement(IElement element)
        {
            if (_elements == null)
            {
                _elements = new List<HtmlElement>();
            }
            _elements.Add(element as HtmlElement);
        }

        public void RunDocument()
        {
            using (var writer = new StreamWriter(_fileName))
            {
                writer.WriteLine("<!DOCTYPE html><html><head></head><body>");
                foreach (var element in _elements)
                {
                    writer.WriteLine(element.ToString());
                }
                writer.WriteLine("</body></html>");
            }

            var index = new FileInfo(_fileName);
            System.Diagnostics.Process.Start("chrome.exe", $"--homepage {index.FullName}");
        }
    }
}
