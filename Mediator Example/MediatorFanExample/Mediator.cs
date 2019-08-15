using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MediatorFanExample
{
    public class Mediator
    {
        // button, fan, and mediator no longer communicate directly
        // meaning that adding more components to work with the button
        // is trivial
        private Fan _fan;
        private PowerSupplier _powerSupplier;

        public void SetFan(Fan fan)
        {
            _fan = fan;
        }

        public void SetPowerSupplier(PowerSupplier powerSupplier)
        {
            _powerSupplier = powerSupplier;
        }

        public void Press()
        {
            if (_fan.IsOn)
            {
                _fan.TurnOff();
            }
            else
            {
                _fan.TurnOn();
            }
        }

        public void Start()
        {
            _powerSupplier.TurnOn();
        }

        public void Stop()
        {
            _powerSupplier.TurnOff();
        }
    }
}
