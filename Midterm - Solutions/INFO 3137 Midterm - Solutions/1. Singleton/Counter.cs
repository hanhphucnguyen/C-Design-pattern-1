using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton
{
    public class Counter
    {
        private static Counter _instance;
        private int _count;

        private Counter()
        {
            _count = 0;
        }

        public static Counter GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Counter();
            }
            return _instance;
        }

        public int Count()
        {
            return ++_count;
        }
    }
}
