using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentBuilderLibrary.Interfaces;

namespace ConsoleClient
{
    public class ConsoleDirector : IDirector
    {
        private IBuilder _builder;

        public string Name { get; set; }
        public string Content { get; set; }

        public ConsoleDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public IComposite GetDocument()
        {
            return _builder.GetDocument();
        }

        public void BuildBranch()
        {
            _builder.BuildBranch(Name);
        }

        public void BuildLeaf()
        {
            _builder.BuildLeaf(Name, Content);
        }

        public void CloseBranch()
        {
            _builder.CloseBranch();
        }

    }
}
