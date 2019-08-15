namespace CarState.States
{
    public class State
    {
        protected Car _car;

        public State(Car car)
        {
            _car = car;
        }

        public virtual void TurnKeyClockwise() { }
        public virtual void TurnKeyCounterClockwise() { }
        public virtual void PressGas() { }
        public virtual void PressBrake() { }

    }
}
