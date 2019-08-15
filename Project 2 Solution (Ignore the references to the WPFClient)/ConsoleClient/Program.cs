using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentBuilderLibrary;

namespace ConsoleClient
{
    class Program
    {
        private static ConsoleDirector _director;
        static void Main(string[] args)
        {
            Console.WriteLine("Document Builder Console Client");
            PrintUsage(new string[1]);
            bool keepRunning = true;
            do
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                var inputList = input.Split(':');
                if (inputList.Length == 0)
                {
                    PrintInvalidInputMessage();
                }
                var command = inputList[0].ToLower();

                switch(command)
                {
                    case "help":
                        PrintUsage(inputList);
                        break;
                    case "mode":
                        SetMode(inputList);
                        break;
                    case "branch":
                        CreateBranch(inputList);
                        break;
                    case "leaf":
                        CreateLeaf(inputList);
                        break;
                    case "close":
                        CloseBranch(inputList);
                        break;
                    case "print":
                        PrintDocument(inputList);
                        break;
                    case "exit":
                        keepRunning = false;
                        break;
                    default:
                        PrintInvalidInputMessage();
                        break;
                }

            } while (keepRunning);
        }

        private static void PrintDocument(string[] inputList)
        {
            if (inputList.Length != 1)
            {
                PrintInvalidInputMessage();
                return;
            }
            if (_director == null)
            {
                PrintModeNotSetMessage();
                return;
            }
            Console.WriteLine(_director.GetDocument().Print(0));
        }

        private static void CloseBranch(string[] inputList)
        {
            if (inputList.Length != 1) {
                PrintInvalidInputMessage();
                return;
            }
            if (_director == null)
            {
                PrintModeNotSetMessage();
                return;
            }
            _director.CloseBranch();
        }

        private static void CreateLeaf(string[] inputList)
        {
            if (inputList.Length != 3)
            {
                PrintInvalidInputMessage();
                return;
            }
            if(_director == null)
            {
                PrintModeNotSetMessage();
                return;
            }

            _director.Name = inputList[1];
            _director.Content = inputList[2];
            _director.BuildLeaf();
            _director.Name = "";
            _director.Content = "";
        }

        private static void CreateBranch(string[] inputList)
        {
            if (inputList.Length != 2)
            {
                PrintInvalidInputMessage();
                return;
            }
            if (_director == null)
            {
                PrintModeNotSetMessage();
                return;
            }

            _director.Name = inputList[1];
            _director.BuildBranch();
            _director.Name = "";
        }

        private static void SetMode(string[] inputList)
        {
            if(inputList.Length != 2)
            {
                PrintInvalidInputMessage();
            }

            var mode = inputList[1].ToLower();
            switch(mode)
            {
                case "json":
                    _director = new ConsoleDirector(new DocumentBuilderLibrary.Json.Builder());
                    break;
                case "xml":
                    _director = new ConsoleDirector(new DocumentBuilderLibrary.Xml.Builder());
                    break;
                default:
                    PrintInvalidInputMessage();
                    break;

            }
        }

        static void PrintInvalidInputMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. For Usage, type 'Help'");
            Console.WriteLine();
        }

        static void PrintModeNotSetMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Error. Mode has not been set. For usage, type 'Help'");
            Console.WriteLine();
        }

        static void PrintUsage(string[] inputList)
        {
            if (inputList.Length != 1)
            {
                PrintInvalidInputMessage();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Usage: ");
            Console.WriteLine("    help                   -Prints Usage (this page).");
            Console.WriteLine("    mode:<JSON|XML>        -Sets mode to JSON or XML. Must be set before creating or closing.");
            Console.WriteLine("    branch:<name>          -Creates a new branch, assinging it the passed name.");
            Console.WriteLine("    leaf:<name>:<content>  -Creates a new leaf, assigning the passed name and content.");
            Console.WriteLine("    close                  -Closes the current branch, as long as it is not the root.");
            Console.WriteLine("    print                  -Prints the doc in its current state to the console.");
            Console.WriteLine("    exit                   -Exits the application.");
            Console.WriteLine();
        }
    }
}
