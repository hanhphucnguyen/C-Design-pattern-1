using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public class JSONComposite : IComposite
    {
        private string _name;
        private List<IComposite> _children;
        private string temp;

        public JSONComposite(string name)
        {
            _name = name;
            _children = new List<IComposite>();
        }

        public void AddChild(IComposite composite)
        {
            _children.Add(composite);
        }

        public string Print(int depth)
        {
            string temp = "";
            for (int index = 0; index < depth; index++)
            {
                temp += "\t";
                Console.Write("\t");
            }
            if (_name != "root")
            {
                temp += _name + ":{\n";
                Console.WriteLine($"'{_name}':{{ ");
            } else
            {
                temp += _name + "{\n";
                Console.WriteLine($"{{");
            }

            foreach (var child in _children)
            {
                child.Print(depth + 1);
            }

            for (int index = 0; index < depth; index++)
            {
                temp += "\t";
                Console.Write("\t");
            }
            if (_name != "root")
            {
                temp += "\t}";
                Console.WriteLine($"\t}}");
            }
            else
            {
                temp += "}";
                Console.WriteLine($"}}");
            }           
            return temp;
        }
    }
}
