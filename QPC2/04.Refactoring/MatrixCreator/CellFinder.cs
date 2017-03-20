namespace RotatingWalkInMatrix
{
    internal class CellFinder
    {
        internal void FindEmptyCell(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        this.AvailableX = i;
                        this.AvailableY = j;
                        break;
                    }
                }
            }
        }

        internal int AvailableX { get; set; }
        internal int AvailableY { get; set; }
    }
}
