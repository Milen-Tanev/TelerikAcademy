namespace Exceptions
{
    using System;
    using Exceptions;


    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.MaxValue;
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid number", 1, 100);
                }
            }
            catch(InvalidRangeException<int> exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                DateTime longTimeAgo = new DateTime(1000, 01, 01);
                if (longTimeAgo < new DateTime(1980, 01, 01) || longTimeAgo > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Invalid date", new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));
                }
            }

            catch (InvalidRangeException<DateTime>exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
