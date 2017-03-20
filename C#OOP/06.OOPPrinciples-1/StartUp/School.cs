
using System.Collections.Generic;

namespace StartUp
{
    public class School
    {
        private List<Class> classesInSchool;

        public List<Class> ClassesInSchool
        {
            get
            {
                return this.classesInSchool;
            }

            set
            {
                this.classesInSchool = value;
            }
        }

        public void AddClass(Class _class)
        {
            this.classesInSchool.Add(_class);
        }

        public void RemoveClass(Class _class)
        {
            this.classesInSchool.Remove(_class);
        }
    }
}
