using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Exercise_Solution
{
    //This class is a concrete builder
    public class LowCalorieMeal : IMeal
    {
        private Meal lowCalMeal;

        public void BuildMeal()
        {
            lowCalMeal = new Meal();
        }
        public void BuildDrink()
        {
            lowCalMeal.drink = "Diet coke";
        }

        public void BuildMain()
        {
            lowCalMeal.main = "Portobello burger";
        }

        public void BuildSide()
        {
            lowCalMeal.side = "Cucumbers";
        }

        public void BuildToy()
        {
            lowCalMeal.toy = "Measuring Tape";
        }

        public Meal getMeal()
        {
            return lowCalMeal;
        }
    }
}
