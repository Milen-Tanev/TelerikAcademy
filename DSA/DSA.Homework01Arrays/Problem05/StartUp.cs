namespace Problem05
{
    using System;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var sequence = new int[] { 2, 3, 5, -4, 4, 7, -5, 0, 6, -11, 7, -5, 9, -6 };

            sequence = sequence.Where(val => val >= 0).ToArray();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sequence.Length-1; i++)
            {
                sb.Append($"{sequence[i]}, ");
            }

            sb.Append(sequence[sequence.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
