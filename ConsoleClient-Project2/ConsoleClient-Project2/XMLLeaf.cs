using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public class XMLLeaf : IComposite
    {
        private string _tagName;
        private string _content;
        private string temp;

        public XMLLeaf(string tagName, string content)
        {
            _tagName = tagName;
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
            temp +="<"+ _tagName + ">" + _content + "</" + _tagName + ">\n";         
            Console.WriteLine($"<{_tagName}>{_content}</{_tagName}>");
            return temp;
        }
    }
}
