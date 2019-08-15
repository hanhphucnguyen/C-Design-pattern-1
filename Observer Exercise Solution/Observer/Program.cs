using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new ClockTimer();
            var observer = new DigitalClock(subject);
            subject.Attach(observer);

            for(int index = 0; index < 100; index++)
            {
                Thread.Sleep(1000);
                subject.Tick();
            }
        }
    }
}
