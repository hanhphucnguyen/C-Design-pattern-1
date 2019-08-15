using System;

namespace CarState.States
{
    public class Stopped : State
    {
        public Stopped(Car car) : base(car) { }

        public override void PressGas()
        {
            Console.WriteLine("The car begins to drive");
            Console.WriteLine();
            _car.ChangeState(new Driving(_car));
        }

        public override void TurnKeyClockwise()
        {
            Console.WriteLine("You hear a grinding noise...");
            Console.WriteLine();
        }

        public override void TurnKeyCounterClockwise()
        {
            Console.WriteLine("The engine has stopped");
            Console.WriteLine();
            _car.ChangeState(new Off(_car));
        }
    }
}
