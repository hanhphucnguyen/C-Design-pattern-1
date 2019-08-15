using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBuilder
{
    public class Facade
    {
        public List<Vehicle> buildVehicles()
        {
            var director = new Director();

            var vehicles = new List<Vehicle>();
            vehicles.Add(director.BuildVehicle(new SedanBuilder()));
            vehicles.Add(director.BuildVehicle(new TricycleBuilder()));
            vehicles.Add(director.BuildVehicle(new SevenFortySevenBuilder()));
            
            return vehicles;
        }

        //Note that you could put this in another Facade class or directly in this one (it's up to you). 
        public Vehicle buildVehicle(string type)
        {
            Director director = new Director();
            if (type.Equals("Sedan"))
            {
                return director.BuildVehicle(new SedanBuilder());
            }
            else if (type.Equals("747"))
            {
                return director.BuildVehicle(new SevenFortySevenBuilder());
            }
            else if (type.Equals("Tricycle"))
            {
                return director.BuildVehicle(new TricycleBuilder());
            }
            return null;
        }
    }
}
