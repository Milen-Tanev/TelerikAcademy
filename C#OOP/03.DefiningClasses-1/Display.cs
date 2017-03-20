namespace Gsm_Classes
{
    using System;
    using System.Text;

    public class Display
    {
        private double? size = null;
        private int? numberOfColors = null;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return (double)this.size;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display size must be a positive number");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return (int)this.numberOfColors;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display colors must be a positive integer");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder displayFullInfo = new StringBuilder();
            if (this.size != null)
            {
                displayFullInfo.AppendLine("Display size: " + this.size);
            }

            if (this.numberOfColors != null)
            {
                displayFullInfo.AppendLine("Number of colors: " + this.numberOfColors);
            }
            return displayFullInfo.ToString();
        }
    }
}