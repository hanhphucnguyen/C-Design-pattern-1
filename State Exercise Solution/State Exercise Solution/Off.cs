using System;
using System.Collections.Generic;
using System.Text;

namespace State_Exercise_Solution
{
    public class Off : State
    {
        public Off(Computer computer) : base(computer) { }

        public override void TurnOn()
        {
            Console.WriteLine("Turning on...");
            computer.ChangeState(new On(computer));
        }
    }
}
