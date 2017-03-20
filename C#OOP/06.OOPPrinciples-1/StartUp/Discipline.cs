using StartUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Disciplines
{
    public class Discipline : ICommentable
    {
        internal List<string> names = new List<string>() { "Arts", "Biology", "Chemistry", "Geography", "History",
            "Information technologies", "Literature","Mathematics", "Music", "P.E.", "Philosophy" };

        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!names.Contains(value))
                {
                    throw new ArgumentException("Invalid discipline!");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 4)
                {
                    throw new ArgumentOutOfRangeException("Lectures must be at least 4!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }

            set
            {
                if (value < 4)
                {
                    throw new ArgumentOutOfRangeException("Excercises must be at least 4!");
                }

                this.numberOfExcercises = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"Discipline: {this.Name}, lectures: {this.NumberOfLectures}, excersises: {this.NumberOfExcercises}");
            return st.ToString();
        }
    }
}
