using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadFanExample
{
    class Programwha
    {
        static void Main(string[] args)
        {
            var button = new Button(new Fan(new PowerSupplier()));

            // The fan should be off when we start. Debug.Assert will output an error message when I run this if its parameter is false.
            Debug.Assert(!button.Fan.IsOn);

            // The button should turn on when we press the button
            button.Press();
            Debug.Assert(button.Fan.IsOn);

            // The fan should turn off when we hit the button again
            button.Press();
            Debug.Assert(!button.Fan.IsOn);

            // If everything went well, log success
            Console.WriteLine("Fan is working as intended");

        }
    }
}