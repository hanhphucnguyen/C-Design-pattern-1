using System;
using System.Collections.Generic;

namespace Builder_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var meals = new List<Meal>();
            meals.Add(director.BuildMeal(new VeganMeal()));
            meals.Add(director.BuildMeal(new MeatLoversMeal()));
            meals.Add(director.BuildMeal(new LowCalorieMeal()));

            foreach (var meal in meals)
            {
                Console.WriteLine($"Main:    {meal.main}");
                Console.WriteLine($"Side:  {meal.side}");
                Console.WriteLine($"Drink:   {meal.drink}");
                Console.WriteLine($"Toy:   {meal.toy}");
                Console.WriteLine();
            }
        }
    }
}
