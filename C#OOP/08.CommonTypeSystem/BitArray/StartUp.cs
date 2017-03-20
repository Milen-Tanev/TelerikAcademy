namespace BitArray
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ulong number = 12123154151234;

            BitArray64 array = new BitArray64(number);
            BitArray64 newArray = new BitArray64(81724);

            Console.WriteLine(array.GetIndexValue(33));
            Console.WriteLine(array == newArray);
            Console.WriteLine(array.Equals(newArray));
            Console.WriteLine(newArray.GetHashCode());
            // This will throw an exception, because there are less than 33 bits in 81724:
            // Console.WriteLine(newArray.GetIndexValue(33));
        }
    }
}
