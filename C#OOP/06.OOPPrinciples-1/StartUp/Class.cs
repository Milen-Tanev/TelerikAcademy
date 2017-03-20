using StartUp.Interfaces;
using StartUp.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    public class Class : ICommentable
    {
        internal List<string> uniqueIDs = new List<string>();
        private string uniqueID;
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string uniqueID)
        {
            this.UniqueID = uniqueID;
            this.Students = students;
            this.Teachers = teachers;
        }

        public Class(string uniqueID, string comment)
        {
            this.UniqueID = uniqueID;
            this.Students = students;
            this.Teachers = teachers;
            this.Comment = comment;
        }
        public string UniqueID
        {
            get
            {
                return this.uniqueID;
            }

            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("This class has no ID");
                }

                if (uniqueIDs.Contains(value))
                {
                    throw new ArgumentException("This class already exists!");
                }

                this.uniqueID = value;
                uniqueIDs.Add(value);
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("This class has no students!");
                }
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("This class has no teachers!");
                }
                this.teachers = value;
            }
        }

        public string Comment { get; set; }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"Class: {this.uniqueID}\nStudents:\n");

            foreach (var item in this.Students)
            {
                st.Append($"{item};\n");
            }

            return st.ToString();
        }
    }
}
