namespace ComputersDbImporter.Importer
{
    using System;
    using Data;

    public class CPUsGenerator
    {
        internal readonly string[] CPUVendors = { "IBM", "AMD", "Fujitsu", "Intel", "Marvell", "Rockchip", "Samsung" };
        internal readonly string[] CPUModels = { "AMD A8-7670K", "Intel Xeon E5-2670", "Intel Core i3-6100", "AMD Sempron 3850",
                "Pentium D", "Core i5-6402P", "Core i7-6700T" };
        internal readonly byte[] CPUCoresNumber = { 1, 2, 4, 8 };
        internal readonly string[] CPUClockCycles = { "2.4 GHz", "2.6 GHz", "2.8 GHz", "3.0 GHz", "3.2 GHz" };

        [ThreadStatic]
        private static Random random = new Random();

        public CPU Generate()
        {
            return new CPU
            {
                Vendor = CPUVendors[random.Next(0, CPUVendors.Length)],
                Model = CPUModels[random.Next(0, CPUModels.Length)],
                NumberOfCores = CPUCoresNumber[random.Next(0, CPUCoresNumber.Length)],
                ClockCycles = CPUClockCycles[random.Next(0, CPUClockCycles.Length)]
            };
        }
    }
}
