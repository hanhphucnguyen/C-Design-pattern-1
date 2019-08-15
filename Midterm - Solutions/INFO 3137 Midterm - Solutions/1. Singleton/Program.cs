using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < 10; index++)
            {
                var counter = Counter.GetInstance();
                Console.WriteLine($"Current Count: {counter.Count()}");
            }
        }
    }
}
