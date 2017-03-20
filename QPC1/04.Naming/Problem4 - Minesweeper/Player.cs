namespace Minesweeper
{
    using System;

    internal class Player
    {
        private string name;
        private int points;

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(Constants.NameCannotBeNullError);
                }

                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Constants.PointsCannotBeLessThanZero);
                }

                this.points = value;
            }
        }
    }
}
