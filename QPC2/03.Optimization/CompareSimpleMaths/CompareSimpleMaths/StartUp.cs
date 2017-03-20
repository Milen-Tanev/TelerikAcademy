using System;
using System.Diagnostics;

namespace CompareSimpleMaths
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // Write a program to compare the performance of:
            // add, subtract, increment, multiply, divide
            // for the values:
            // int, long, float, double and decimal
            const int Integer = 42;
            const long Long = 10000000000L;
            const float Float = 3.1415926f;
            const double Double = 3.14159265358979;
            const decimal Decimal = 3.1415926m;
            const int iterations = 10000000;

            // Tests with int

            // Add
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                int result = int.MinValue;
                result += Integer;
            }
            st.Stop();
            Console.WriteLine("Performance of adding with int: {0}", st.Elapsed);
            st.Reset();

            // Subtract
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                int result = int.MaxValue;
                result -= Integer;
            }
            st.Stop();
            Console.WriteLine("Performance of subtracting with int: {0}", st.Elapsed);
            st.Reset();

            // Increment
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                int result = int.MinValue;
                result ++;
            }
            st.Stop();
            Console.WriteLine("Performance of incrementing an int: {0}", st.Elapsed);
            st.Reset();

            // Multiply
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                int result = 1;
                result *= Integer;
            }
            st.Stop();
            Console.WriteLine("Performance of multiplying with int: {0}", st.Elapsed);
            st.Reset();

            // Divide
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                int result = int.MaxValue;
                result /= Integer;
            }
            st.Stop();
            Console.WriteLine("Performance of dividing with int: {0}", st.Elapsed);
            st.Reset();

            Console.WriteLine();

            // Tests with long

            // Add
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                long result = long.MinValue;
                result += Long;
            }
            st.Stop();
            Console.WriteLine("Performance of adding with long: {0}", st.Elapsed);
            st.Reset();

            // Subtract
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                long result = long.MaxValue;
                result -= Long;
            }
            st.Stop();
            Console.WriteLine("Performance of subtracting with long: {0}", st.Elapsed);
            st.Reset();

            // Increment
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                long result = long.MinValue;
                result++;
            }
            st.Stop();
            Console.WriteLine("Performance of incrementing a long integer: {0}", st.Elapsed);
            st.Reset();

            // Multiply
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                long result = 1L;
                result *= Long;
            }
            st.Stop();
            Console.WriteLine("Performance of multiplying with long: {0}", st.Elapsed);
            st.Reset();

            // Divide
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                long result = long.MaxValue;
                result /= Long;
            }
            st.Stop();
            Console.WriteLine("Performance of dividing with long: {0}", st.Elapsed);
            st.Reset();

            Console.WriteLine();

            // Tests with float

            // Add
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = float.MinValue;
                result += Float;
            }
            st.Stop();
            Console.WriteLine("Performance of adding with float: {0}", st.Elapsed);
            st.Reset();

            // Subtract
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = float.MaxValue;
                result -= Float;
            }
            st.Stop();
            Console.WriteLine("Performance of subtracting with float: {0}", st.Elapsed);
            st.Reset();

            // Increment
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = float.MinValue;
                result++;
            }
            st.Stop();
            Console.WriteLine("Performance of incrementing a float: {0}", st.Elapsed);
            st.Reset();

            // Multiply
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = 1f;
                result *= Float;
            }
            st.Stop();
            Console.WriteLine("Performance of multiplying with float: {0}", st.Elapsed);
            st.Reset();

            // Divide
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                float result = float.MaxValue;
                result /= Float;
            }
            st.Stop();
            Console.WriteLine("Performance of dividing with float: {0}", st.Elapsed);
            st.Reset();

            Console.WriteLine();

            // Tests with double

            // Add
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = double.MinValue;
                result += Double;
            }
            st.Stop();
            Console.WriteLine("Performance of adding with double: {0}", st.Elapsed);
            st.Reset();

            // Subtract
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = double.MaxValue;
                result -= Double;
            }
            st.Stop();
            Console.WriteLine("Performance of subtracting with double: {0}", st.Elapsed);
            st.Reset();

            // Increment
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = double.MinValue;
                result++;
            }
            st.Stop();
            Console.WriteLine("Performance of incrementing a double: {0}", st.Elapsed);
            st.Reset();

            // Multiply
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = 1;
                result *= Double;
            }
            st.Stop();
            Console.WriteLine("Performance of multiplying with double: {0}", st.Elapsed);
            st.Reset();

            // Divide
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                double result = double.MaxValue;
                result /= Double;
            }
            st.Stop();
            Console.WriteLine("Performance of dividing with double: {0}", st.Elapsed);
            st.Reset();

            Console.WriteLine();

            // Tests with decimal

            // Add
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = decimal.MinValue;
                result += Decimal;
            }
            st.Stop();
            Console.WriteLine("Performance of adding with decimal: {0}", st.Elapsed);
            st.Reset();

            // Subtract
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = decimal.MaxValue;
                result -= Decimal;
            }
            st.Stop();
            Console.WriteLine("Performance of subtracting with decimal: {0}", st.Elapsed);
            st.Reset();

            // Increment
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = decimal.MinValue;
                result++;
            }
            st.Stop();
            Console.WriteLine("Performance of incrementing a decimal: {0}", st.Elapsed);
            st.Reset();

            // Multiply
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = 1m;
                result *= Decimal;
            }
            st.Stop();
            Console.WriteLine("Performance of multiplying with decimal: {0}", st.Elapsed);
            st.Reset();

            // Divide
            st.Start();
            for (int i = 0; i < iterations; i++)
            {
                decimal result = decimal.MaxValue;
                result /= Decimal;
            }
            st.Stop();
            Console.WriteLine("Performance of dividing with decimal: {0}", st.Elapsed);
            st.Reset();
        }
    }
}
