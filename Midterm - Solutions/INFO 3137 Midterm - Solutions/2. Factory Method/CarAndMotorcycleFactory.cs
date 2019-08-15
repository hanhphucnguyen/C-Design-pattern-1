using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Factory_Method
{
    public class CarAndMotorcycleFactory : CarFactory
    {
        public override Car CreateCar(string type)
        {
            switch(type)
            {
                case "Motorcycle":
                    return new Motorcycle();
                default:
                    return base.CreateCar(type);
            }
        }
    }
}
