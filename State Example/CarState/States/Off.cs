using System;

namespace CarState.States
{
    public class Off : State
    {
        public Off(Car car) : base(car) { }
        public override void TurnKeyClockwise()
        {
            Console.WriteLine("The engine has started");
            Console.WriteLine();
            _car.ChangeState(new Stopped(_car));
        }
    }
}
