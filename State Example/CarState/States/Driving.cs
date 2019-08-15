using System;

namespace CarState.States
{
    public class Driving : State
    {
        public Driving(Car car) : base(car) { }

        public override void TurnKeyClockwise()
        {
            Console.WriteLine("You hear a grinding noise...");
            Console.WriteLine();
        }

        public override void TurnKeyCounterClockwise()
        {
            Console.WriteLine("The engine turns off, and the car stops suddenly");
            Console.WriteLine();
            _car.ChangeState(new Off(_car));
        }

        public override void PressBrake()
        {
            Console.WriteLine("The car slows to a stop");
            Console.WriteLine();
            _car.ChangeState(new Stopped(_car));
        }
    }
}
