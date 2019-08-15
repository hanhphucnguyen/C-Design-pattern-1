using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public interface IBuilder
    {
        void BuildComposite(string key);
        void CloseComposite();
        void BuildLeaf(string key, string val);
        void OutputResult();
    }
}
