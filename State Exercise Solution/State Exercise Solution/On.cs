using System;
using System.Collections.Generic;
using System.Text;

namespace State_Exercise_Solution
{
    class On : State
    {
        public On(Computer computer) : base(computer) { }

        public override void TurnOn()
        {
            Console.WriteLine("Turning off...");
            computer.ChangeState(new Off(computer));
        }
    }
}
