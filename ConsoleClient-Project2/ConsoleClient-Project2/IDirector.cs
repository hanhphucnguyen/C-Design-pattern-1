using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public interface IDirector
    {
        void BuildBranch();
        void BuildLeaf();
        void CloseBranch();
    }
}
