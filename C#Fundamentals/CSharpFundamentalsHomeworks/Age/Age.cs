using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

            var difference = (today - birthDay);
            var currentAge = difference.Days / 365;
            Console.WriteLine(currentAge);
            Console.WriteLine(currentAge + 10);
        }
    }
}