using System;

namespace Component
{
    class Spice : Food
    {
        public Spice(string foodName) : base(foodName)
        {
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
                Console.WriteLine("This {0} smells good!", this.FoodName.ToLower());
            }
            else
            {
                Console.WriteLine("This {0} smells bad!", this.FoodName.ToLower());
            }
        }
    }
}
