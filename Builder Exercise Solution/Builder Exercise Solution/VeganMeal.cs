using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Exercise_Solution
{
    //This class is a concrete builder
    public class VeganMeal : IMeal
    {
        private Meal veganMeal;
        public void BuildMeal()
        {
            veganMeal = new Meal();
        }
        public void BuildDrink()
        {
            veganMeal.drink = "Coke";
        }

        public void BuildMain()
        {
            veganMeal.main = "Veggie burger";
        }

        public void BuildSide()
        {
            veganMeal.side = "Fries";
        }

        public void BuildToy()
        {
            veganMeal.toy = "Stuffed carrot";
        }

        public Meal getMeal()
        {
            return veganMeal;
        }
    }
}
