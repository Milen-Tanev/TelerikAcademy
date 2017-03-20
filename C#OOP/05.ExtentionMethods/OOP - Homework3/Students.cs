

namespace OOP___Homework3
{
    using System.Collections.Generic;
    using System.Text;

    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public string Fullname { get; }

        public Students (string firstName, string lastName, int age, int fN, string phoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fN;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Fullname = this.FirstName + " " + this.LastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string result = sb.Append ($"First name: {this.FirstName}, Last name: {this.LastName}").ToString();
            return result;
        }
    }
}
