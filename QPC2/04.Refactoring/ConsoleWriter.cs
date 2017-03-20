namespace RotatingWalkInMatrix
{
    using System;

    internal class ConsoleWriter
    {
        internal void WriteToConsole (string message)
        {
            Console.WriteLine(message);
        }

        internal void PrintMatrix(int [,] matrix, int matrixSize)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                for (int rows = 0; rows < matrixSize; rows++)
                {
                    Console.Write("{0,3}", matrix[cols, rows]);
                }

                Console.WriteLine();
            }
        }
    }
}
