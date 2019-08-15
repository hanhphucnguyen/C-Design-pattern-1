using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Exercise_Solution
{
    public class Runway
    {
        private Mediator mediator; 

        public Runway(Mediator m)
        {
            mediator = m;
        }

        public void land()
        {
            mediator.setLandingStatus(true);
        }
    }
}
