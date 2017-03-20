namespace OOP___Homework3.Extentions
{
    using System;
    using System.Diagnostics;

    public class Timer
    {
        private readonly int seconds;

        public delegate void PrintSomething();

        public Timer(int seconds)
        {
            this.seconds = seconds;
        }

        public void Invoke()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var myDelegate = new PrintSomething(Print);

            while (true)
            {
                if (stopwatch.Elapsed.Seconds != this.seconds)
                {
                    continue;
                }

                myDelegate.Invoke();
                stopwatch.Restart();
            }
        }

        private static void Print()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
