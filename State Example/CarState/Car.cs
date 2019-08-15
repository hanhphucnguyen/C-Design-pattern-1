using CarState.States;

namespace CarState
{
    public class Car
    {
        private State _state;

        public Car()
        {
            ChangeState(new Off(this));
        }

        public bool HandleInput(string input)
        {
            switch (input)
            {
                case "turn-clockwise":
                    _state.TurnKeyClockwise();
                    break;
                case "turn-counter":
                    _state.TurnKeyCounterClockwise();
                    break;
                case "gas":
                    _state.PressGas();
                    break;
                case "brake":
                    _state.PressBrake();
                    break;
                case "exit":
                    return false;
            }
            return true;
        }

        public void ChangeState(State state)
        {
            _state = state;
        }
    }
}
