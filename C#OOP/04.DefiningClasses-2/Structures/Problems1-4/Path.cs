namespace Structures
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> seqOf3DPoints;

        public Path()
        {
            this.SeqOf3DPoints = new List<Point3D>(); 
        }

        public List<Point3D> SeqOf3DPoints
        {
            get
            {
                return this.seqOf3DPoints;
            }
            
            set
            {
                this.seqOf3DPoints = value;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.seqOf3DPoints.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.seqOf3DPoints.Remove(point);
        }
    }
}
