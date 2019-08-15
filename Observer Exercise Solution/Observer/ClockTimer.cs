using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ClockTimer : Subject
    {
        public int Second { get; private set; }
        public int Minute { get; private set; }
        public int Hour { get; private set; }

        public ClockTimer() : base()
        {
            Second = 0;
            Minute = 0;
            Hour = 0;
        }

        public void Tick()
        {
            Second++;
            if(Second == 60)
            {
                Second = 0;
                Minute++;
            }
            if(Minute == 60)
            {
                Hour++;
                Minute = 0;
            }
            if(Hour == 24)
            {
                Hour = 0;
            }

            base.Notify();
        }
    }
}
