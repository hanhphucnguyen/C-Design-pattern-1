using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    public interface IComposite
    {
        void Print(int depth);
        void Add(IComposite composite);

    }
}
