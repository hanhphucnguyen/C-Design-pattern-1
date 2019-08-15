using System;

namespace Observer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(2);

            Graph barGraph = new Graph("BarGraph", data);
            Graph pieChart = new Graph("PieChart", data);

            data.SetData(3);
            data.SetData(60);
        }
    }
}
