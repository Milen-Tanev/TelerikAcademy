namespace Structures
{
    using System;

    public static class CalculateDistance
    {
        public static double Distance(Point3D A, Point3D B)
        {
            double distance = Math.Sqrt((B.CoordX - A.CoordX) * (B.CoordX - A.CoordX)
                + (B.CoordY - A.CoordY) * (B.CoordY - A.CoordY) + (B.CoordZ - A.CoordZ) * (B.CoordZ - A.CoordZ));

            return distance;
        }
    }
}
