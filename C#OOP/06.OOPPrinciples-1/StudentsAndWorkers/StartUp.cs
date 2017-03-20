using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
            new Student("Ivan", "Georgiev", 5),
            new Student("Petar", "Dimitrov", 4),
            new Student("Dimitar", "Ivanov", 2),
            new Student("Georgi", "Mihaylov", 5.5),
            new Student("Todor", "Petrov", 3.80),
            new Student("Gergana", "Todorova", 4.50),
            new Student("Bilyana", "Nikolova", 6),
            new Student("Stoyan", "Vasilev", 5.20),
            new Student("Asya", "Tsvetkova", 3),
            new Student("Vanya", "Simeonova", 3.80),
            };

            List<Worker> workers = new List<Worker>() {
            new Worker("Kaloyan", "Georgiev", 880, 6.5),
            new Worker("Boris", "Antonov", 750, 4),
            new Worker("Dragan", "Dobrev", 390, 3.5),
            new Worker("Pencho", "Penchev", 1230, 9),
            new Worker("Hristo", "Lyobomirov", 800, 8),
            new Worker("Galina", "Yankova", 760, 7.50),
            new Worker("Tanya", "Hrostova", 320, 3),
            new Worker("Violeta", "Nikolova", 980, 8.5),
            new Worker("Rossitza", "Lyudmilova", 120, 2),
            new Worker("Yoana", "Spasova", 600, 5.5),
            };

            students = students.OrderByDescending(x => x.Grade).ThenBy(x=>x.FirstName).ToList();
            Console.WriteLine("Sorted students:");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            workers = workers.OrderByDescending
                (x => x.MoneyPerHour(x.WeekSalary, x.WorkHoursPerDay)).ThenBy(x => x.FirstName).ToList();
            Console.WriteLine("Sorted workers:");
            foreach (var item in workers)
            {
                Console.WriteLine(item);
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans = humans.OrderByDescending
                (x => x.FirstName).ThenBy(x => x.LastName).ToList();
            Console.WriteLine("Both workers and students:");

            foreach (var item in humans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
