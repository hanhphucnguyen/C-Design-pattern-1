using System;

namespace Mediator_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();
            Runway r = new Runway(m);
            Flight f = new Flight(m);

            //r.land();
            f.land();
        }
    }
}
