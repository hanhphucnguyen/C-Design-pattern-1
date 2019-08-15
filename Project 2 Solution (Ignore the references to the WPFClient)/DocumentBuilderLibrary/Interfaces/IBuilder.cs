using System.Reflection;

namespace DocumentBuilderLibrary.Interfaces
{
    public interface IBuilder
    {
        void BuildBranch(string name);
        void BuildLeaf(string name, string content);
        void CloseBranch();
        IComposite GetDocument();
    }
}
