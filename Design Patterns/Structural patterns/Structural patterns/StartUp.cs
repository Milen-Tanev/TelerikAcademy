using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Meal("Sandwich");
            sandwich.Smell(false);
            sandwich.Taste(false);

            var pepper = new Spice("Pepper");
            pepper.Smell(true);

            sandwich.Add(pepper);

            sandwich.Smell(true);
            sandwich.Taste(false);

            var cheese = new Meal("Cheese");
            cheese.Taste(true);

            sandwich.Add(cheese);
            sandwich.Taste(true);
        }
    }
}
