namespace Problem2
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int currentIndex = 0;
            char[] directions = input.ToCharArray();
            int length = directions.Length;

            while (true)
            {
                if (directions[currentIndex] >= 'a'
                && directions[currentIndex] <= 'z')
                {
                    currentIndex += directions[currentIndex] - 96;
                }
                else if (directions[currentIndex] >= 'A'
                    && directions[currentIndex] <= 'Z')
                {
                    currentIndex -= directions[currentIndex] - 64;
                }
                else if (directions[currentIndex] == '^')
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", currentIndex);
                    break;
                }

                if (currentIndex < 0 || currentIndex > length)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", currentIndex);
                    break;
                }
            }
        }
    }
}
