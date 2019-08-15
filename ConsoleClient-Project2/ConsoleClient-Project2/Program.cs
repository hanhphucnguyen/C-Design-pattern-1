using System;
using System.Collections.Generic;

namespace ConsoleClient_Project2
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Document Builder Console Client\n");
            printhelp();
            Boolean flag = true;
            string docType = null;
            List<string> dataInput = new List<string>();
            while (flag)
            {
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "mode:json":
                        docType = "json";
                        Console.Write(">");
                        break;
                    case "mode:xml":
                        docType = "xml";
                        Console.Write(">");
                        break;
                    case "help":
                        printhelp();
                        break;
                    case "print":
                        if (docType == null) Console.Write("Error. Mode has not been set. For usage, type 'Help'\n>");
                        else
                        {
                            var director = new Director(docType, dataInput);
                            director.BuildDoc();
                            Console.Write(">");
                        }
                        break;
                    case "exit":
                        flag = false;
                        break;
                    default:
                        {
                            string inputCut = input;

                            if (inputCut.ToLower().StartsWith("branch:"))
                            {
                                inputCut = inputCut.Substring(7);
                                if (docType == null) Console.Write("Error. Mode has not been set. For usage, type 'Help'\n>");
                                else
                                {
                                    if (inputCut.Contains(":")) Console.Write("Invalid input. For usage, type 'help' \n>");
                                    else
                                    {
                                        dataInput.Add(inputCut); Console.Write(">");
                                    }                                   
                                }
                            }
                            else if (inputCut.ToLower().StartsWith("leaf:"))
                            {
                                inputCut = inputCut.Substring(5);
                                if (docType == null) Console.Write("Error. Mode has not been set. For usage, type 'Help'\n>"); else { dataInput.Add(inputCut); Console.Write(">"); }
                            }
                            else if (inputCut.ToLower().Equals("close"))
                            {
                                if (docType == null) Console.Write("Error. Mode has not been set. For usage, type 'Help'\n>"); else dataInput.Add("close");
                            }
                            else
                                Console.Write("Invalid input. For usage, type 'help' \n>");
                        }
                        break;
                }
            }
        }

        public static void printhelp()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine($"   help                  -Prints Usage (this page).");
            Console.WriteLine($"   mode:<JSON|XML>       -Sets mode to JSON or XML. Must be set before creating or closing.");
            Console.WriteLine($"   branch:<name>         -Creates a new branch, assinging it the passed name.");
            Console.WriteLine($"   leaf:<name>:<content> -Creates a new leaf, assigning the passed name and content.");
            Console.WriteLine($"   close                 -Closes the current branch, as long as it is not the root.");
            Console.WriteLine($"   print                 -Prints the doc in its current state to the console.");
            Console.Write($"   exit                  -Exits the application.\n>");
        }
    }
}
