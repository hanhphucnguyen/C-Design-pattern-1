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

        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');
            IDocumentFactory currentFactory = null;
            IDocument currentDocument = null;
            IElement currentElement = null;
   
            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');
          
                switch (commandList[0])
                {
                    case "Document":
                        {
                            var temp = commandList[1].Split(';');
                            switch (temp[0])
                            {
                                case "Html":                                   
                                     currentFactory = HTMLFactory.GetInstance();
                                     currentDocument = currentFactory.CreateDocument(temp[1]);
                                     break;
                                case "Markdown":
                                    currentFactory = MDFactory.GetInstance();
                                    currentDocument = currentFactory.CreateDocument(temp[1]);
                                    break;
                                default:
                                    break;
                            }
                        }
                        // Your document creation code goes here
                        break;
                    case "Element":
                        {                           
                            currentElement = currentFactory.CreateElement(commandList[1], commandList[2]);
                            currentDocument.AddElement(currentElement);
                        }

                        // Your element creation code goes here
                        break;
                    case "Run":
                        currentDocument.RunDocument();                   
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
