using StartUp.Interfaces;
using System;
using System.Text;

namespace StartUp.People
{
    public abstract class Person: ICommentable
    {
        private string name;
        private char n;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string comment)
        {
            this.Name = name;
            this.Comment = comment;
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
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"Name: {this.name}");
            st.Append("\nComments:");
            return st.ToString();
        }
    }
}
