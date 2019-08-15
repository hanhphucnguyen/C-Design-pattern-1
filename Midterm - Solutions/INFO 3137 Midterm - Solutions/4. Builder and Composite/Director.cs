using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Builder_and_Composite
{
    // document content and structure taken from https://www.cs.utexas.edu/~mitra/csFall2018/cs329/lectures/xml/xslplanes.2.xml.txt
    public static class Director
    {
        public static void BuildDocument(IBuilder builder)
        {
            builder.BuildComposite("plane");
            builder.BuildLeaf("year", "1977");
            builder.BuildLeaf("make", "Cessna");
            builder.BuildLeaf("model", "Skyhawk");
            builder.BuildComposite("colors");
            builder.BuildLeaf("color", "Light blue");
            builder.BuildLeaf("color", "White");
            builder.CloseComposite();
            builder.CloseComposite();
            builder.BuildComposite("plane");
            builder.BuildLeaf("year", "1975");
            builder.BuildLeaf("make", "Piper");
            builder.BuildLeaf("model", "Apache");
            builder.BuildComposite("colors");
            builder.BuildLeaf("color", "White");
            builder.CloseComposite();
            builder.CloseComposite();
            builder.BuildComposite("plane");
            builder.BuildLeaf("year", "1960");
            builder.BuildLeaf("make", "Cessna");
            builder.BuildLeaf("model", "Centurian");
            builder.BuildComposite("colors");
            builder.BuildLeaf("color", "Yellow");
            builder.BuildLeaf("color", "White");
            builder.CloseComposite();
            builder.CloseComposite();
            builder.BuildComposite("plane");
            builder.BuildLeaf("year", "1956");
            builder.BuildLeaf("make", "Piper");
            builder.BuildLeaf("model", "Tripacer");
            builder.BuildComposite("colors");
            builder.BuildLeaf("color", "Blue");
            builder.CloseComposite();
            builder.CloseComposite();
            builder.OutputResult();
        }
    }
}
