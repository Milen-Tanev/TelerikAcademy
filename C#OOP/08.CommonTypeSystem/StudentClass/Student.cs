namespace StudentClass
{
    using System;
    using Enumerations;
    using System.Text;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string _SSN;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private byte course;

        public Student(string firstName, string middleName, string lastName, string _SSN,
            string permanentAddress, string mobileNumber,string email, byte course,
            Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = _SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobileNumber;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Please, enter first name");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Please, enter middle name");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Please, enter last name");
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this._SSN;
            }

            set
            {
                if (value.Length != 9)
                {
                    throw new ArgumentException("SSN is always a 9-digit number");
                }
                this._SSN = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Please, enter your address");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Please, enter your real phone number");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value.Length < 10 || !value.Contains("@"))
                {
                    throw new ArgumentException("Email is not in valid format!");
                }

                this.email = value;
            }
        }

        public byte Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Invalid course!");
                }

                this.course = value;
            }
        }

        public Specialty Specialty { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Student st = obj as Student;
            if (this.FirstName == st.FirstName && this.MiddleName == st.MiddleName && this.LastName == st.LastName
                && this.SSN == st.SSN && this.PermanentAddress == st.PermanentAddress && this.MobilePhone == st.MobilePhone
                && this.Email == st.Email && this.Course == st.Course && this.Specialty == st.Specialty && this.University == st.University)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append($"Name: {this.FirstName} {this.MiddleName} {this.LastName}\nAddress: {this.PermanentAddress}\nEmail: {this.Email}\nPhone number: {this.MobilePhone}\nSocial security number: {this.SSN}\nStudies {this.Specialty} in the {this.Faculty} faculty in {this.University} University");
            return st.ToString();
        }

        public static bool operator ==(Student st1, Student st2)
        {
            if (Object.ReferenceEquals(st1, st2))
            {
                return true;
            }

            if ((object)st1 == null || (object) st2 == null)
            {
                return false;
            }

            if (st1.FirstName == st2.FirstName && st1.MiddleName == st2.MiddleName && st1.LastName == st2.LastName
                && st1.SSN == st2.SSN && st1.PermanentAddress == st2.PermanentAddress && st1.MobilePhone == st2.MobilePhone
                && st1.Email == st2.Email && st1.Course == st2.Course && st1.Specialty == st2.Specialty && st1.University == st2.University)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !(st1 == st2);
        }

        public override int GetHashCode()
        {
            return (int.Parse(this.MobilePhone)) - (int)((long.Parse(MobilePhone)) / 529) + 12345678;
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.MobilePhone, this.Email, this.Course, this.Specialty, this.Faculty, this.University);
        }

        public int CompareTo(Student other)
        {
            if (this.LastName != other.LastName)
            {
                return string.Compare(this.LastName, other.LastName);
            }

            else
            {
                if (this.FirstName != other.FirstName)
                {
                    return string.Compare(this.FirstName, other.FirstName);
                }
                else
                {
                    if (int.Parse(this.SSN) < int.Parse(other.SSN))
                    {
                        return -1;
                    }

                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
