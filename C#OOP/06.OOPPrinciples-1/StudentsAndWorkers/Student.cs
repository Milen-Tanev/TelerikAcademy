﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade):base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grades must be between 2 and 6!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"First name:....{this.FirstName}\nLast Name:.....{this.LastName}\nGrade:.........{this.Grade}\n");
            return st.ToString();
        }
    }
}
