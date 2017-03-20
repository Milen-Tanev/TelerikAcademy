namespace RotatingWalkInMatrix
{
    using System;

    class InputChecker
    {
        internal int CheckInput(string input)
        {
            int parsedNumber = 0;

            bool isPositiveNumber = int.TryParse(input, out parsedNumber);

            if (!isPositiveNumber)
            {
                throw new ArgumentException(Messages.InputIsNotAPositiveNumberError);
            }

            if (parsedNumber < 0 || parsedNumber > 100)
            {
                throw new ArgumentOutOfRangeException(Messages.InputIsOutOfRangeError);
            }
            return parsedNumber;
            
        }
    }
}
