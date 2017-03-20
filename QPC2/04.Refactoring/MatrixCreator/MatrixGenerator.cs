namespace RotatingWalkInMatrix
{
    internal class MatrixGenerator
    {
        internal int MoveForward(int[,] matrix, int matrixSize, int cellIndexX, int cellIndexY, int increaseX, int increaseY, int currentNumber)
        {
            while (CheckIfMoveIsAvailable(matrix, cellIndexX, cellIndexY))
            {
                matrix[cellIndexX, cellIndexY] = currentNumber;

                bool nextCellXIsInRange = cellIndexX + increaseX >= matrixSize || cellIndexX + increaseX < 0;
                bool nextCellYIsInRange = cellIndexY + increaseY >= matrixSize || cellIndexY + increaseY < 0;

                while (nextCellXIsInRange || nextCellYIsInRange || matrix[cellIndexX + increaseX, cellIndexY + increaseY] != 0)
                {
                    SetDirection(ref increaseX, ref increaseY);

                    nextCellXIsInRange = cellIndexX + increaseX >= matrixSize || cellIndexX + increaseX < 0;
                    nextCellYIsInRange = cellIndexY + increaseY >= matrixSize || cellIndexY + increaseY < 0;
                }

                cellIndexX += increaseX;
                cellIndexY += increaseY;
                currentNumber++;
                matrix[cellIndexX, cellIndexY] = currentNumber;
            }

            return currentNumber;
        }

        internal int ChangeDirection(int[,] matrix, int matrixSize, int cellIndexX, int cellIndexY, int increaseX, int increaseY, int currentNumber)
        {
            if (cellIndexX != 0 && cellIndexY != 0)
            {
                MoveForward(matrix, matrixSize, cellIndexX, cellIndexY, increaseX, increaseY, currentNumber);
            }

            return currentNumber;
        }

        private static void SetDirection(ref int directionX, ref int directionY)
        {
            int[] ListOfXDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] ListOfYDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int directionIndex = 0;

            for (int count = 0; count < 8; count++)
            {
                if (ListOfXDirections[count] == directionX && ListOfYDirections[count] == directionY)
                {
                    directionIndex = count;
                    break;
                }
            }

            if (directionIndex == 7)
            {
                directionX = ListOfXDirections[0];
                directionY = ListOfYDirections[0];
                return;
            }

            directionX = ListOfXDirections[directionIndex + 1];
            directionY = ListOfYDirections[directionIndex + 1];
        }

        private static bool CheckIfMoveIsAvailable(int[,] arr, int cellIndexX, int cellIndexY)
        {
            const int DirectionsLength = 8;
            int[] ListOfXDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] ListOfYDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (cellIndexX + ListOfXDirections[i] >= arr.GetLength(0) || cellIndexX + ListOfXDirections[i] < 0)
                {
                    ListOfXDirections[i] = 0;
                }

                if (cellIndexY + ListOfYDirections[i] >= arr.GetLength(0) || cellIndexY + ListOfYDirections[i] < 0)
                {
                    ListOfYDirections[i] = 0;
                }
            }

            for (int i = 0; i < DirectionsLength; i++)
            {
                if (arr[cellIndexX + ListOfXDirections[i], cellIndexY + ListOfYDirections[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
