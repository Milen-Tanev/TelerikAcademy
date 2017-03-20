namespace OOP___Homework3.Extentions
{
    using System;

    public static class PrintDivisibleBy7And3
    {
        public static void Print(this int[] array)
        {
            foreach (var item in array)
            {
                if (item % 3 == 0 && item % 7 == 0)
                {
                    Console.Write("{0} ", item);
                }
            }
        }
    }
}
