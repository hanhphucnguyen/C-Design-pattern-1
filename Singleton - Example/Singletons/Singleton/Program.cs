using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            var singleton3 = Singleton.GetInstance();
            var singleton4 = Singleton.GetInstance();
        }
    }
}
