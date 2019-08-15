using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public interface IBuilder
    {
        void BuildBranch(string name);
        void BuildLeaf(string name, string content);
        void CloseBranch();
        IComposite GetDocument(); 
    }
}
