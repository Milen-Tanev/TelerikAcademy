namespace Minesweeper
{
    internal class Constants
    {
        // Game consts
        internal const int BoardRows = 5;
        internal const int BoardColumns = 10;
        internal const int MaxOpenedFields = 35;
        internal const int CommandLength = 3;
        internal const int MaxNumberOfMines = 15;
        internal const int RandomNumberGenerator = 50;

        // Game commands
        internal const string NewTurn = "turn";
        internal const string DisplayRanking = "top";
        internal const string RestartGame = "restart";
        internal const string ExitGame = "exit";

        // Game messages
        internal const string WelcomeMessage = "Play Minesweeper.\nCommands:\n\t'top' displays ranking,\n\t'restart' starts new game,\n\t'exit' exits the game!";
        internal const string RequestCoordinates = "Input row and column: ";
        internal const string GoodbyeMessage = "Goodbye!";
        internal const string InvalidCommandMessage = "\nInvalid command\n";
        internal const string GameOverMessage = "\nGame over\nYou have {0} points.\nEnter your name: ";
        internal const string YouWinMessage = "\nYou win!";
        internal const string RequestPlayerNameForRanking = "Enter your name: ";
        internal const string RankingHeader = "\nPoints:";
        internal const string RankingPointsString = "{0}. {1} --> {2} points";
        internal const string NoCurrentlyRankedPlayers = "There are no ranked players currently\n";

        // BoardGenerator
        internal const string RowsNumbers = "\n    0 1 2 3 4 5 6 7 8 9";
        internal const string BoardHorizontalBorder = "   ---------------------";
        internal const string BoardVerticalalBorder = "|";
        internal const char FieldWithMine = '*';
        internal const char UnopenedField = '?';
        internal const char GameOverEmptyField = '-';

        // Errors
        internal const string NameCannotBeNullError = "Name cannot be null!";
        internal const string PointsCannotBeLessThanZero = "Points cannot be a negative integer!";
    }
}
