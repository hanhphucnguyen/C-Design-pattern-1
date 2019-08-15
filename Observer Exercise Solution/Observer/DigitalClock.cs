using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class DigitalClock : IObserver
    {
        private ClockTimer _subject;

        public DigitalClock(ClockTimer subject)
        {
            _subject = subject;
        }

        public void Update(Subject subject)
        {
            if(!(subject == _subject))
            {
                return;
            }
            Console.WriteLine($"The current time is {_subject.Hour.ToString("00")}:{_subject.Minute.ToString("00")}:{_subject.Second.ToString("00")}");
        }
    }
}
