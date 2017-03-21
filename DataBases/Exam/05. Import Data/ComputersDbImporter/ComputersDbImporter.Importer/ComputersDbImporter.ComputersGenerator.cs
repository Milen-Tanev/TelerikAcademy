namespace ComputersDbImporter.Importer
{
    using System;
    using System.Linq;
    using Data;

    public class ComputersGenerator
    {
        internal readonly string[] ComputerTypes = { "Ultrabook", "Notebook", "Desktop PC" };
        internal readonly string[] ComputerVendors = { "Lenovo", "Samsung", "Fujitsu", "Dell", "Toshiba", "Apple", "Acer", "Asus" };
        internal readonly string[] ComputerModels = { "Macintosh 128K", "PowerEdge R620", "pSeries 615Mod6E3",
            "R630 G7", "ThinkPad T60", "Express5800/120E", "iMac Core i7" };
        internal readonly int[] ComputerRAMList = { 1 , 2, 4, 8, 16, 32, 64 };

        [ThreadStatic]
        private static Random random = new Random();

        public Computer Generate()
        {
            var db = new ComputersDbEntities();
            var cpuIds = db.CPUs
                .Select(c => c.Id)
                .ToArray();
            var storageDevices = db.StorageDevices.ToArray();
            var gpus = db.GPUs.ToArray();

            var computer = new Computer
            {
                Type = ComputerTypes[random.Next(0, ComputerTypes.Length)],
                Vendor = ComputerVendors[random.Next(0, ComputerVendors.Length)],
                Model = ComputerModels[random.Next(0, ComputerModels.Length)],
                CPUId = cpuIds[random.Next(0, cpuIds.Length)],
                RAM = ComputerRAMList[random.Next(0, ComputerRAMList.Length)],
            };

            db.SaveChanges();
            db.Dispose();

            for (int i = 0; i < 2; i++)
            {
                computer.StorageDevices.Add(storageDevices[random.Next(0, storageDevices.Length)]);
                computer.GPUs.Add(gpus[random.Next(0, gpus.Length)]);
            }

            return computer;            
        }
    }
}
