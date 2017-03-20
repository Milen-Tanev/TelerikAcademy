using System;

namespace Problem3_Animals.Fauna
{
    public class Dog : Animals
    {
        public Dog(string name, int age, Sex sex) : base (name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }
}
