namespace Problem1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] digits = new int[3];

            for (int i = 0; i < input.Length; i++)
            {
                digits[i] = (int)Char.GetNumericValue(input[i]);
            }

            decimal result = 0;
            if (digits[1] % 2 == 0)
            {
                result = (decimal)(digits[0] + digits[1]) * digits[2];
            }
            else
            {
                result = (decimal)(digits[0] * digits[1]) / digits[2];
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
