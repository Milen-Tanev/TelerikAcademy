using System;

namespace Problem3_Animals.Fauna
{
    public class Cat : Animals
    {
        public Cat(string name, int age, Sex sex) : base (name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("miaw");
        }
    }
}
