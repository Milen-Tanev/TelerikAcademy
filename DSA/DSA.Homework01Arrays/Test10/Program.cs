using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());

            var lastNumber = M;

            var sequence = new Stack<int>();

            sequence.Push(lastNumber);

            while (N <= lastNumber / 2)
            {
                if (lastNumber == 3 && N == 1)
                {
                    lastNumber = lastNumber - 2;
                }
                else if (lastNumber % 2 == 0)
                {
                    lastNumber = lastNumber / 2;
                }
                else
                {
                    lastNumber = lastNumber - 1;
                }
                sequence.Push(lastNumber);
            }

            while (N < lastNumber)
            {
                var difference = lastNumber - N;

                if (difference % 2 == 0)
                {
                    lastNumber = lastNumber - 2;
                }
                else
                {
                    lastNumber = lastNumber - 1;
                }

                sequence.Push(lastNumber);
            }

            while (sequence.Count > 0)
            {
                Console.Write($"{sequence.Pop()} ");
            }
        }
    }
}
