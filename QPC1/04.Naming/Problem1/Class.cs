namespace Problem1
{
    using System;

    //I couldn't understand the point of this class. I would have named it better.
    internal class Class
    {
        private const int MaxCount = 6;

        public void PrintBool(bool toBePrinted)
        {
            string printString = toBePrinted.ToString();
            Console.WriteLine(printString);
        }
    }
}
