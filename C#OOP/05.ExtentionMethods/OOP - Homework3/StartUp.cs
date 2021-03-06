﻿namespace OOP___Homework3
{
    using Extentions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            // Test task1
            var str = "Hello, this is the test for task 1";
            Console.WriteLine(str.Substring(7));
            Console.WriteLine();
            
            // Test task2
            int[] nums = new int [] { 1, 12, 38, 56, 21, 42, 96, 84 };
            Console.WriteLine($"Sum of numbers = {nums.Sum()}");
            Console.WriteLine($"Product of numbers = {nums.Product()}");
            Console.WriteLine($"Min of numbers = {nums.Min()}");
            Console.WriteLine($"Max of numbers = {nums.Max()}");
            Console.WriteLine($"Average number = {nums.Average()}");
            Console.WriteLine();

            // Test task 3 & task 4 & task 5
            Students[] students = new Students[5];
            students[0] = new Students("Georgi", "Ivanov", 22, 111306, "02/5531823", "5ar_ivanov@abv.bg", new List<int>() { 5, 2, 4, 6, 3, 4 }, 2);
            students[1] = new Students("Ivan", "Petrov", 16, 111108, "084/1235156", "ivanivanov@gmail.com", new List<int>() { 4, 3, 3, 6, 2, 5 }, 1);
            students[2] = new Students("Petar", "Dimitrov", 34, 11192, "02/4214142", "petar.dimitrov@yahoo.com", new List<int>() { 6, 2, 2, 5, 3, 4 }, 2);
            students[3] = new Students("Dimitar", "Todorov", 17, 11106, "02/8678746", "mitkotodorov@abv.bg", new List<int>() { 2, 5, 4, 2, 3, 2 }, 3);
            students[4] = new Students("Todor", "Georgiev", 19, 11112, "012/54535345", "tg@abv.bg", new List<int>() { 3, 2, 5, 6, 2, 4 }, 2);

            var firstNameBeforeLastName = students.FirstBeforeLast();

            Console.WriteLine("Students whose first name is before their last name alphabetically:");
            foreach (var item in firstNameBeforeLastName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var studentsBetween18And24 = students.AgeBetween18And24();
            Console.WriteLine("Students at the age between 18 and 24:");

            foreach (var item in studentsBetween18And24)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var orderedByFirstName = students.OrderBy();
            var orderedByLastName = students.ThenBy();

            Console.WriteLine("Students ordered by first name:");
            foreach (var item in orderedByFirstName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Students ordered by last name:");
            foreach (var item in orderedByLastName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Test task 6
            Console.WriteLine("Integers divisible by 7 and 3: ");
            PrintDivisibleBy7And3.Print(nums);
            Console.WriteLine();
            Console.WriteLine();

            //Test task 7 - uncomment to view
            /*
            Timer timer = new Timer(1);
            timer.Invoke();*/

            //Test task 9
            Console.WriteLine("Students from group 2:");
            var studentsFromGroup2 = students.GroupSelect();
            foreach (var item in studentsFromGroup2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Test task 11
            Console.WriteLine("Students with email in abv.bg:");
            var studentsWithEmailInAbv = students.ExtractEmail();
            foreach (var item in studentsWithEmailInAbv)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Test task 12
            Console.WriteLine("Students with phone number from Sofia:");
            var studentsFromSofia = students.ExtractPhone();
            foreach (var item in studentsFromSofia)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Task 13

            var excellentStudents = students.Where(x => x.Marks.Contains(6))
    .OrderBy(x => x.FirstName).ToList();


            var ExcellentStudent = new
            {
                FullName = excellentStudents.Select(x => x.Fullname),
                Marks = excellentStudents.Select(x => x.Marks)
            };


            Console.WriteLine("Students with mark 6:");
            foreach (var item in excellentStudents)
            {
                Console.WriteLine($"Name: {item.Fullname}");
            }

            //Task 14
            Console.WriteLine();
            Console.WriteLine("Students with exactly two marks 2: ");
            var poorStudents = students.ExtractPoorStudents();
            foreach (var item in poorStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Task 15
            Console.WriteLine("Marks of the students, who enrolled in 2006:");
            students.ExtractMarks();
            Console.WriteLine();

            //Task 17
            string[] array = { "surreal", "ambition", "detonator", "sonic", "elsewhere", "distinct" };
            Console.WriteLine("Longest string:");
            Console.WriteLine(array.LongestString());
            Console.WriteLine();

            //Task 18
            Console.WriteLine("Students by group:");
            students.GroupByGroupNumber();

        }
    }
}
