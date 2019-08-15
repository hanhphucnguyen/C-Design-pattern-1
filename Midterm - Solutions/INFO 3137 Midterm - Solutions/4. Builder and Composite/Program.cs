using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Director.BuildDocument(new XmlBuilder());
            Director.BuildDocument(new PlainTextBuilder());
        }
    }
}
