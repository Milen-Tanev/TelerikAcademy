using Problem3_Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3_Animals
{
    public abstract class Animals : ISound
    {
        private string name;
        private int age;
        private Sex sex;

        public Animals(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name is too short!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 0!");
                }

                this.age = value;
            }
        }

        public Sex Sex { get; set; }

        public static double AverageAge(IEnumerable<Animals> animals)
        {
            double result = animals.Average(x => x.Age);
            return result;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat($"Name: {this.Name}, age: {this.Age}, gender: {this.Sex}");
            return st.ToString();
        }
    }
}
