using System;
using System.Diagnostics;

namespace CompareAdvancedMaths
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Write a program to compare the performance of:
            // square root, natural logarithm, sinus
            // for the values:
            // float, double and decimal

            const float Float = 3.1415926f;
            const double Double = 3.14159265358979;
            const decimal Decimal = 3.1415926m;
            const int iterations = 1000000;

            // Tests with float

            // Square root
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = (float)Math.Sqrt(Float);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Sqrt with float: {0}", st.Elapsed);
            st.Reset();

            // Tests with natural logarithm
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = (float)Math.Log(Float);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Log with float: {0}", st.Elapsed);
            st.Reset();

            // Tests with sinus
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = (float)Math.Sin(Float);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Sin with float: {0}", st.Elapsed);
            st.Reset();
            Console.WriteLine();

            // Tests with double

            // Square root
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = Math.Sqrt(Double);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Sqrt with double: {0}", st.Elapsed);
            st.Reset();

            // Tests with natural logarithm
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = Math.Log(Double);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Log with double: {0}", st.Elapsed);
            st.Reset();

            // Tests with sinus
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = Math.Sin(Double);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Sin with double: {0}", st.Elapsed);
            st.Reset();
            Console.WriteLine();

            // Tests with decimal

            // Square root
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = (decimal)Math.Sqrt((double)Decimal);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Sqrt with decimal: {0}", st.Elapsed);
            st.Reset();

            // Tests with natural logarithm
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = (decimal)Math.Log((double)Decimal);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Log with decimal: {0}", st.Elapsed);
            st.Reset();

            // Tests with sinus
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = (decimal)Math.Sin((double)Decimal);
            }
            st.Stop();
            Console.WriteLine("Performance of Math.Sin with decimal: {0}", st.Elapsed);
            st.Reset();
            Console.WriteLine();
        }
    }
}
