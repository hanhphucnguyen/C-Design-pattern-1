using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorFanExample
{
    public class Fan
    {
        private Mediator _mediator;
        public bool IsOn;

        public Fan(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void TurnOn()
        {
            _mediator.Start();
            IsOn = true;
        }

        public void TurnOff()
        {
            _mediator.Stop();
            IsOn = false;
        }
    }
}