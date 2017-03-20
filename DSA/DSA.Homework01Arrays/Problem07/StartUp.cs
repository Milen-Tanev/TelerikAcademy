using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var numbersOccuranceCount = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!numbersOccuranceCount.Keys.Contains(array[i]))
                {
                    numbersOccuranceCount.Add(array[i], 1);
                }
                else
                {
                    int value = numbersOccuranceCount[array[i]] + 1;
                    numbersOccuranceCount[array[i]] = value;
                }
            }

            var items = from pair in numbersOccuranceCount
                        orderby pair.Key ascending
                        select pair;

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
