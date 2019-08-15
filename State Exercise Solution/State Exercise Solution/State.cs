using System;
using System.Collections.Generic;
using System.Text;

namespace State_Exercise_Solution
{
    //Note that the exercise asks you to make an interface for the concrete states
    //Normally, interfaces, regular superclasses, and abstract classes are typically considered interchangeable in design patterns
    //However, in c# specifically (not in all programming languages), interfaces can't have instance variables
    //So this time I'll make State a class, instead of an interface
    //Also it mentions making an interface for the context - in this case we don't really need it, since we have just one context
    public class State
    {
        protected Computer computer;
        public State(Computer c)
        {
            computer = c;
        }

        public virtual void TurnOn() { }
    }
}
