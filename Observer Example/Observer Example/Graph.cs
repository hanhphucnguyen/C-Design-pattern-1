using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Example
{
    public class Graph : IObserver
    {
        private string Type;
        private Data Store;

        public Graph(string type, Data data)
        {
            this.Type = type;
            this.Store = data;
            this.Store.Subscribe(this);
        }

        public void Update()
        {
            Console.WriteLine(this.Type + ":");
            Console.WriteLine("\tGot an update notification");
            Console.WriteLine("\tUpdating my graph with value: " + Store.GetData());
            Console.WriteLine();
        }
    }
}
