using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan");
            Person notPerson = new Person("Bai Ivan", 40);
            Console.WriteLine(person);
            Console.WriteLine(notPerson);
        }
    }
}
