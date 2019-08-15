using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Factory_Method
{
    public class CarFactory
    {
        public virtual Car CreateCar(string type)
        {
            switch(type)
            {
                case "Van":
                    return new Van();
                case "Truck":
                    return new Truck();
                case "Coupe":
                    return new Coupe();
                default:
                    return new Car();
            }
        }
    }
}
