using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name is too short!");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value.HasValue && (value < 0 || value > 150))
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than 0 or more than 150!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendFormat("Name: {0}, ", this.Name);
            if (this.Age.HasValue)
            {
                st.AppendFormat("Age: {0}", this.Age);
            }

            else
            {
                st.AppendFormat("Age: not specified");
            }

            return st.ToString();
        }
    }
}
