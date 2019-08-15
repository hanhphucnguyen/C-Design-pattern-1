using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public class JSONLeaf: IComposite
    {
        private string _name;
        private string _content;
        private string temp;
        public JSONLeaf(string name, string content)
        {
            _name = name;
            _content = content;
        }
        public void AddChild(IComposite composite)
        {
        }

        public string Print(int depth)
        {
            for (int index = 0; index < depth; index++)
            {
                temp += "\t";
                Console.Write("\t");
            }
            temp += _name + " : " + _content + ",\n";
            Console.WriteLine($"'{_name}' : '{_content}',");
            return temp;
        }
    }
}
