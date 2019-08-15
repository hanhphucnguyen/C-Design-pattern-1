using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DocumentFactory;

namespace Director
{
    class Program
    {
        private static IDocumentFactory _factory;
        private static IDocument _document;

        static void CreateDocument(string[] command)
        {
            switch (command[0])
            {
                case "Markdown":
                    _factory = MarkdownDocumentFactory.GetInstance();
                    break;
                case "Html":
                    _factory = HtmlDocumentFactory.GetInstance();
                    break;
            }

            _document = _factory.CreateDocument(command[1]);
        }
        static void RunDocument()
        {
            _document.RunDocument();
        }

        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            foreach(var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');
                switch(commandList[0])
                {
                    case "Document":
                        CreateDocument(commandList[1].Split(';'));
                        break;
                    case "Element":
                        _document.AddElement(_factory.CreateElement(commandList[1], commandList[2]));
                        break;
                    case "Run":
                        RunDocument();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
