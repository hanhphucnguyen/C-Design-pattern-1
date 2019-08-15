using System;

namespace BadCarState
{
    public class Car
    {
        private enum State
        {
            Off,
            Stopped,
            Driving
        }
        private State _state;

        public Car()
        {
            _state = State.Off;
        }

        public bool HandleInput(string input)
        {
            switch (input)
            {
                case "turn-clockwise":
                    switch(_state)
                    {
                        case State.Off:
                            Console.WriteLine("The engine has started");
                            Console.WriteLine();
                            _state = State.Stopped;
                            break;
                        case State.Stopped:
                        case State.Driving:
                            Console.WriteLine("You hear a grinding noise...");
                            Console.WriteLine();
                            break;
                    }
                    break;
                case "turn-counter":
                    switch(_state)
                    {
                        case State.Stopped:
                            Console.WriteLine("The engine has stopped");
                            Console.WriteLine();
                            _state = State.Off;
                            break;
                        case State.Driving:
                            Console.WriteLine("The engine turns off, and the car stops suddenly");
                            Console.WriteLine();
                            _state = State.Off;
                            break;
                    }
                    break;
                case "gas":
                    switch(_state)
                    {
                        case State.Stopped:
                            Console.WriteLine("The car begins to drive");
                            Console.WriteLine();
                            _state = State.Driving;
                            break;
                    }
                    break;
                case "brake":
                    switch(_state)
                    {
                        case State.Driving:
                            Console.WriteLine("The car slows to a stop");
                            Console.WriteLine();
                            _state = State.Stopped;
                            break;
                    }
                    break;
                case "exit":
                    return false;
            }
            return true;
        }
    }
}
