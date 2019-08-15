using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise_Solution
{
    public class Flight
    {
        private Mediator mediator;
        public Flight(Mediator m)
        {
            this.mediator = m;
        }

        public void land()
        {
            if (mediator.land)
            {
                Console.WriteLine("Successfully landed"); 
            }
            else
            {
                Console.WriteLine("Waiting to land");
            }
        }
    }
}
