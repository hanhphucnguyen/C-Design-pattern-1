using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Exercise_Solution
{
    //This class is the builder
    public interface IMeal
    {
        void BuildMeal();
        void BuildMain();
        void BuildSide();
        void BuildToy();
        void BuildDrink();

        Meal getMeal();
    }
}
