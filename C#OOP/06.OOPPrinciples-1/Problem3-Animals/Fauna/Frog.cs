using System;

namespace Problem3_Animals.Fauna
{
    public class Frog : Animals
    {
        public Frog(string name, int age, Sex sex) : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Croak");
        }
    }
}
