using System;
using System.Collections.Generic;

namespace Component
{
    public class Meal : Food
    {
        private readonly ICollection<Food> setOfIngredients;

        public Meal(string foodName) : base(foodName)
        {
            this.setOfIngredients = new List<Food>();
        }

        public void Add(Food food)
        {
            this.setOfIngredients.Add(food);
        }

        public void Remove(Food food)
        {
            if (!this.setOfIngredients.Contains(food))
            {
                throw new ArgumentNullException("This ingredient isn't in this meal!");
            }
            else
            {
                this.setOfIngredients.Remove(food);
            }
        }

        public override void Smell(bool isGood)
        {
            if (isGood)
            {
                Console.WriteLine("This {0} smells good!", this.FoodName.ToLower());
            }
            else
            {
                Console.WriteLine("This {0} smells bad!", this.FoodName.ToLower());
            }
        }

        public override void Taste(bool isGood)
        {
            if (isGood)
            {
                Console.WriteLine("This {0} tastes good!", this.FoodName.ToLower());
            }
            else
            {
                Console.WriteLine("This {0} tastes bad!", this.FoodName.ToLower());
            }
        }
    }
}
