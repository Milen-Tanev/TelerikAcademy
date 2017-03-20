using Problem3_Animals.Fauna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Animals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>() {
                new Dog("Sharo", 6, Sex.male),
                new Dog("Rex", 12, Sex.male),
                new Dog("Ginger", 9, Sex.female),
                new Dog("Bear", 2, Sex.male),
                new Dog("Rosie", 4, Sex.female),
                new Dog("Annie", 7, Sex.female)
            };
            Console.WriteLine("Dogs average age:");
            Console.WriteLine(Animals.AverageAge(dogs));
            Console.WriteLine();

            List<Cat> cats = new List<Cat>() {
                new Cat("Tom", 5, Sex.male),
                new Kitten("Rocky", 1),
                new Kitten("Lola", 1),
                new Cat("Coco", 14, Sex.female),
                new Tomcat("Buster", 2),
                new Cat("Lucky", 14, Sex.male),
                new Tomcat("Winston", 1)
            };

            Console.WriteLine("Cats average age:");
            Console.WriteLine(Animals.AverageAge(cats));
            Console.WriteLine();

            List<Frog> frogs = new List<Frog>() {
                new Frog("Jack", 3, Sex.male),
                new Frog("Daisy", 4, Sex.female),
                new Frog("Harley", 5, Sex.male),
                new Frog("Alex", 7, Sex.male),
                new Frog("Gracie", 4, Sex.female)
            };

            Console.WriteLine("Frogs average age:");
            Console.WriteLine(Animals.AverageAge(frogs));
            Console.WriteLine();

            List<Kitten> kittens = new List<Kitten>() {
                new Kitten("Rocky", 1),
                new Kitten("Lola", 1),
                new Kitten("Abby", 2),
                new Kitten("Bailey", 2)
            };

            Console.WriteLine("Kittens average age:");
            Console.WriteLine(Animals.AverageAge(kittens));
            Console.WriteLine();

            List<Tomcat> tomcats = new List<Tomcat>() {
                new Tomcat("Buster", 2),
                new Tomcat("Winston", 1),
                new Tomcat("Sam", 2),
                new Tomcat("Oscar", 2)
            };

            Console.WriteLine("Tomcats average age:");
            Console.WriteLine(Animals.AverageAge(tomcats));
            Console.WriteLine();

            List<Animals> animals = new List<Animals>();
            animals.AddRange(dogs);
            animals.AddRange(cats);
            animals.AddRange(frogs);
            animals.AddRange(kittens);
            animals.AddRange(tomcats);


            Console.WriteLine("Animals average age:");
            Console.WriteLine(Animals.AverageAge(animals));
            Console.WriteLine();
        }
    }
}
