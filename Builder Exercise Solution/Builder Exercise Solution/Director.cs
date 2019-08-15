using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Exercise_Solution
{
    //This class is the director (obviously)
    public class Director
    {
        public Meal BuildMeal(IMeal builder)
        {
            builder.BuildMeal();
            builder.BuildDrink();
            builder.BuildMain();
            builder.BuildSide();
            builder.BuildToy();
            return builder.getMeal();
        }
    }
}
