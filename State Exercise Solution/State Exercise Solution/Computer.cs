using System;
using System.Collections.Generic;
using System.Text;

namespace State_Exercise_Solution
{
    public class Computer
    {
        private State state;

        public Computer()
        {
            ChangeState(new Off(this));
        }

        public void ChangeState(State s)
        {
            state = s;
        }

        public bool HandleInput(string input)
        {
            switch (input)
            {
                case "press":
                    state.TurnOn();
                    break;
                case "exit":
                    return false;
            }

            return true;
        }
    }
}
