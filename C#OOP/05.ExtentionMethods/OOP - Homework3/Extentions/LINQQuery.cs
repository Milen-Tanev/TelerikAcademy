namespace OOP___Homework3.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class LINQQuery
    {
        public static IEnumerable<T> FirstBeforeLast<T>(this IEnumerable<T> students) where T : Students
        {
            var result = students.Where(x => (x.FirstName).CompareTo(x.LastName) < 0).ToArray();
            return result;
    }

        public static IEnumerable<T> AgeBetween18And24<T>(this IEnumerable<T> students) where T: Students
        {
            var result = students.Where(x => x.Age > 18 && x.Age < 24).ToArray();
            return result;
        }

        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> students) where T : Students
        {
            var result = students.OrderByDescending(x => x.FirstName);
            return result;
        }

        public static IEnumerable<T> ThenBy<T>(this IEnumerable<T> students) where T : Students
        {
            var result = students.OrderByDescending(x => x.LastName);
            return result;
        }

        public static IEnumerable<T> GroupSelect<T>(this IEnumerable<T> students) where T : Students
        {
            var result = students.Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName).ToList();
            return result;
        }

        public static IEnumerable<T> ExtractEmail<T>(this IEnumerable<T> students) where T : Students
        {
            var result = students.Where(x => x.Email.Substring(x.Email.Length - 6) == "abv.bg")
                .OrderBy(x => x.FirstName).ToList();
            return result;
        }

        public static IEnumerable<T> ExtractPhone<T>(this IEnumerable<T> students) where T : Students
        {
            var result = students.Where(x => x.PhoneNumber.Substring(0, 3) == "02/")
                .OrderBy(x => x.FirstName).ToList();
            return result;
        }

        public static List<Students> ExtractPoorStudents(this Students[] students)
        {
            List<Students> poorStudents = new List<Students>();
            for (int i = 0; i < students.Length; i++)
            {
                int check = 0;

                for (int j = 0; j < students[i].Marks.Count; j++)
                {
                    if (students[i].Marks[j] == 2)
                    {
                        check++;           
                    }
                }

                if (check == 2)
                {
                    poorStudents.Add(students[i]);
                }
            }

            return poorStudents;
        }

        public static void ExtractMarks(this Students[] students)
        {
            var students06 = students.Where(x => x.FN.ToString().Substring(x.FN.ToString().Length - 2) == "06").ToList();

            for (int i = 0; i < students06.Count; i++)
            {
                foreach (var item in students06[i].Marks)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        public static void GroupByGroupNumber(this Students[] students)
        {
            var result = students.OrderBy(x => x.GroupNumber).ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.AppendLine($"Group {item.GroupNumber}: {item.Fullname}");           
            }
            Console.WriteLine(sb);
        }

        public static string LongestString(this string[] array)
        {
            string longest = array.OrderByDescending(s => s.Length).First();
            return longest;
        }
    }
}
