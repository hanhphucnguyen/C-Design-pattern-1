using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public class Director : IDirector
    {
        private IBuilder builder;
        List<string> dataIn;
        public Director(String type, List<string> data)
        {
            if (type.Equals("json"))
            {
                builder = new JSONBuilder();
            }
            else if (type.Equals("xml"))
            {
                builder = new XMLBuilder();
            }
            dataIn = data;
        }
        public void BuildDoc()
        {
            foreach (string d in dataIn)
            {
                if (d.Contains(":"))
                {
                    string[] temp = d.Split(":");
                    builder.BuildLeaf(temp[0], temp[1]);
                }
                else if (d.Equals("close")) builder.CloseBranch();

                else
                {
                    builder.BuildBranch(d);
                }
            }
            var readyToPrint = builder.GetDocument();
            readyToPrint.Print(0);
        }
        public void BuildBranch()
        {
        }

        public void BuildLeaf()
        {
        }

        public void CloseBranch()
        {
        }
    }
}
