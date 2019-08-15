using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BadFanExample
{
    public class Button
    {
        public Fan Fan;

        public Button(Fan fan)
        {
            Fan = fan;
        }

        public void Press()
        {
            if (Fan.IsOn)
            {
                Fan.TurnOff();
            }
            else
            {
                Fan.TurnOn();
            }
        }
    }
}