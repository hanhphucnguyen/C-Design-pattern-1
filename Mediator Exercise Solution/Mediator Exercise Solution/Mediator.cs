using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise_Solution
{
    public class Mediator
    {
        public Flight flight;
        public Runway runway;
        public Boolean land = false;

        public void setRunway(Runway r)
        {
            runway = r;
        }
        public void setFlight(Flight f)
        {
            flight = f;
        }

        public void setLandingStatus(Boolean l)
        {
            land = l;
        }
    }
}
