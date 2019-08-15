using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient_Project2
{
    public interface IComposite
    {
        void AddChild(IComposite child);
        string Print(int depth);
    }
}
