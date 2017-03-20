using StartUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.People
{
    public class Student : Person, ICommentable
    {
        internal static List<int> classNumbers = new List<int>();

        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment) : base(name, comment)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wrong class number!");
                }
                if (classNumbers.Contains(value))
                {
                    throw new ArgumentException("This class number already exists!");
                }
                this.classNumber = value;
                classNumbers.Add(value);
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"№{this.ClassNumber} {this.Name}");
            st.Append("\nComments:");
            return st.ToString();
        }
    }
}
