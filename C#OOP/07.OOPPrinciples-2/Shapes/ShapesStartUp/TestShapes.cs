namespace ShapesStartUp
{
    using System;
    using Shapes.Shapes;

    class TestShapes
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.6, 8);
            Console.WriteLine
                ("The sides of the rectangle are: {0:F2}, {1:F2};\nThe surface of the rectangle is: {2:F2}\n",
                rectangle.Width, rectangle.Height, rectangle.CalculateSurface());

            Triangle triangle = new Triangle(6, 13);
            Console.WriteLine
                ("The sides of the triangle are: {0:F2}, {1:F2};\nThe surface of the triangle is: {2:F2}\n",
                triangle.Width, triangle.Height, triangle.CalculateSurface());

            Square notSquare = new Square(9.8);
            Console.WriteLine
                ("The sides of the square are: {0:F2} each;\nThe surface of the square is: {1:F2}\n",
                notSquare.Width, notSquare.CalculateSurface());
        }
    }
}
