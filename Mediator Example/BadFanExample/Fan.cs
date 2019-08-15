using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadFanExample
{
    public class Fan
    {
        public PowerSupplier PowerSupplier;
        public bool IsOn;

        public Fan(PowerSupplier powerSupplier)
        {
            PowerSupplier = powerSupplier;
        }

        public void TurnOn()
        {
            PowerSupplier.TurnOn();
            IsOn = true;
        }

        public void TurnOff()
        {
            PowerSupplier.TurnOff();
            IsOn = false;
        }
    }
}