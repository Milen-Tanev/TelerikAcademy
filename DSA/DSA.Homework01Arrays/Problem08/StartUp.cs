namespace Problem08
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var majorant = GetMajorantOfArray(array);

            System.Console.WriteLine(majorant);
        }

        public static int GetMajorantOfArray(int[] array)
        {
            int majorantMinCount = array.Length / 2 + 1;
            // If there is no majorant - return -1
            var majorant = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }

                    if (count >= majorantMinCount)
                    {
                        majorant = array[i];
                    }
                }
            }

            return majorant;
        }
    }
}
