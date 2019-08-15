using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Example
{
    public class Data : Subject
    {
        private int Value;

        public Data(int value)
        {
            this.Value = value;
        }

        public void SetData(int value)
        {
            this.Value = value;
            Console.WriteLine("Data:");
            Console.WriteLine("\tSet my value to " + value);
            Console.WriteLine();
            Notify();
        }

        public int GetData()
        {
            return this.Value;
        }
    }
}
