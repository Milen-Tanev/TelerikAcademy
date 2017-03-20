using System;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            List<string> input = new List<string>();

            string currentInput = Console.ReadLine();

            while (currentInput != "end")
            {
                input.Add(currentInput);
                currentInput = Console.ReadLine();
            }
            List<char> chars = new List<char>();


            for (int i = 0; i < input.Count-2; i++)
            {
                int s = int.Parse(input[i]);
                int e = int.Parse(input[i + 1]);
                string text = input[i + 2];
                bool isEven = i % 2 == 0;
                if (s < 0)
                {
                    s = text.Length + s;
                }

                if (e < 0)
                {
                    e = text.Length + e;
                }

                string currentChars;
                int length = e - s + 1;
                //if (length < 0)
                //{
                //    length *= -1;
                //}

                currentChars = text.Substring(s, length);
                for (int j = 0; j < currentChars.Length;)
                {
                    chars.Add(currentChars[j]);

                    if (isEven)
                    {
                        j += 3;
                    }
                    else
                    {
                        j += 4;
                    }
                }
                
                i += 2;
            }

            foreach (var item in chars)
            {
                Console.Write(item);
            }
        }
    }
}
