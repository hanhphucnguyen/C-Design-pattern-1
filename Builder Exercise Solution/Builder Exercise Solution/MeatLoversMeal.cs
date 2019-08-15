using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Exercise_Solution
{
    //This class is a concrete builder
    public class MeatLoversMeal : IMeal
    {
        private Meal meatLoversMeal;

        public void BuildMeal()
        {
            meatLoversMeal = new Meal();
        }
        public void BuildDrink()
        {
            meatLoversMeal.drink = "Cow blood";
        }

        public void BuildMain()
        {
            meatLoversMeal.main = "Beef burger";
        }

        public void BuildSide()
        {
            meatLoversMeal.side = "Pepperoni stick";
        }

        public void BuildToy()
        {
            meatLoversMeal.toy = "Meat cleaver";
        }

        public Meal getMeal()
        {
            return meatLoversMeal;
        }
    }
}
