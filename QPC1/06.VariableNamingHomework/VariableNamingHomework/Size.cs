namespace VariableNamingHomework
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotaed)
        {
            double absoluteCosineValueOfAngle = Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed));
            double absoluteSineValueOfAngle = Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed));
            double widthOfTheRotatedFigure = (absoluteCosineValueOfAngle * size.Width) + (absoluteSineValueOfAngle * size.Height);
            double heightOfTheRotatedFigure = (absoluteSineValueOfAngle * size.Width) + (absoluteCosineValueOfAngle * size.Height);

            Size rotatedSize = new Size(widthOfTheRotatedFigure, heightOfTheRotatedFigure);
            return rotatedSize;
        }
    }
}
