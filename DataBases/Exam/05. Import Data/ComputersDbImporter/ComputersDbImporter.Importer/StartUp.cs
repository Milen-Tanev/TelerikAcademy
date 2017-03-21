namespace ComputersDbImporter.Importer
{
    using Data;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var gpuGenerator = new GPUsGenerator();
            var cpuGenerator = new CPUsGenerator();
            var sdGenerator = new StorageDevicesGenerator();
            var computerGenerator = new ComputersGenerator();
            var db = new ComputersDbEntities();

            for (int i = 0; i < 15; i++)
            {
                db.GPUs.Add(gpuGenerator.Generate());
                Console.Write(".");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                db.CPUs.Add(cpuGenerator.Generate());
                Console.Write(".");
            }
            Console.WriteLine();

            for (int i = 0; i < 30; i++)
            {
                db.StorageDevices.Add(sdGenerator.Generate());
                Console.Write(".");
            }
            Console.WriteLine();

            db.SaveChanges();

            for (int i = 0; i < 50; i++)
            {
                db.Computers.Add(computerGenerator.Generate());
                Console.Write(".");
            }
            Console.WriteLine();

            db.SaveChanges();
        }
    }
}
