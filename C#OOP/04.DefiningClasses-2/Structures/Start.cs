namespace Structures
{
    using System;

    class Start
    {
        static void Main(string[] args)
        {
            Point3D A = new Point3D(17, 6, 5);
            Point3D B = new Point3D(1, 1, 1);

            Console.WriteLine(CalculateDistance.Distance(A, B));
        }

        //За съжаление толкова ми стигна времето, само това ми работи както трябва :)
    }
}
