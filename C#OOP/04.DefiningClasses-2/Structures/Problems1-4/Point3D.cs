namespace Structures
{
    using System.Text;
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0,0,0);

        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public int CoordZ { get; set; }

        //Counstructor
        public Point3D(int coordX, int coordY, int coordZ)
        {
            this.CoordX = coordX;
            this.CoordY = coordY;
            this.CoordZ = coordZ;
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        //ToString

        public override string ToString()
        {
            return string.Format($"Point: {CoordX}, {CoordY}, {CoordX}");
        }
    }
}
