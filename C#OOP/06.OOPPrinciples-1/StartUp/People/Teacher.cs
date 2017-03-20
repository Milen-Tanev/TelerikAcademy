using StartUp.Disciplines;
using StartUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.People
{
    public class Teacher: Person, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines) : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, List<Discipline> disciplines, string comment) : base(name, comment)
        {
            this.Disciplines = disciplines;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Teachers must teach disciplines!");
                }
                this.disciplines = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"Name: {this.Name}\n");
            st.Append("Teaches: ");
            for (int i = 0; i < this.Disciplines.Count - 1; i++)
            {
                st.Append($"{this.Disciplines[i].Name}, ");
            }
            st.Append($"{this.Disciplines[this.Disciplines.Count-1].Name}");
            st.Append("\nComments:");
            return st.ToString();
        }
    }
}
