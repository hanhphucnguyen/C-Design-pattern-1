using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorFanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();
            var fan = new Fan(mediator);
            var button = new Button(mediator);
            mediator.SetFan(fan);
            mediator.SetPowerSupplier(new PowerSupplier());

            // The fan should be off when we start. Debug.Assert will output an error message when I run this if its parameter is false.
            Debug.Assert(!fan.IsOn);

            // The button should turn on when we press the button
            button.Press();
            Debug.Assert(fan.IsOn);

            // The fan should turn off when we hit the button again
            button.Press();
            Debug.Assert(!fan.IsOn);

            // If everything went well, log success
            Console.WriteLine("Fan is working as intended");
        }
    }
}
