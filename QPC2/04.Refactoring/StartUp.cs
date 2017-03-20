namespace RotatingWalkInMatrix
{
    class WalkInMatrica
    {

        static void Main(string[] args)
        {
            var writer = new ConsoleWriter();
            writer.WriteToConsole(Messages.AskUserForMatrixSize);

            var reader = new ConsoleReader();
            string input = reader.ReadFromConsole();

            var checker = new InputChecker();
            int matrixSize = checker.CheckInput(input);
            
            int[,] matrix = new int[matrixSize, matrixSize];
            int currentNumber = 1;
            int cellIndexX = 0;
            int cellIndexY = 0;
            int increaseX = 1;
            int increaseY = 1;

            var matrixGenerator = new MatrixGenerator();
            currentNumber = matrixGenerator.MoveForward(matrix, matrixSize, cellIndexX, cellIndexY, increaseX, increaseY, currentNumber);

            var cellFinder = new CellFinder();
            cellFinder.FindEmptyCell(matrix);
            cellIndexX = cellFinder.AvailableX;
            cellIndexY = cellFinder.AvailableY;
            currentNumber += 1;
            currentNumber = matrixGenerator.ChangeDirection(matrix, matrixSize, cellIndexX, cellIndexY, increaseX, increaseY, currentNumber);

            writer.PrintMatrix(matrix, matrixSize);
        }
    }
}