namespace ComputersDbImporter.Importer
{
    using System;
    using Data;

    public class GPUsGenerator
    {
        // Two external GPUs, so that about 2/3 of the GPUs will be external, according to the task
        internal readonly string[] GPUTypes = { "internal", "external", "external" };
        internal readonly string[] GPUVendors = 
            { "Nvidia", "AMD", "3D Labs", "Intel", "Qualcomm", "SIS" };
        internal readonly string[] GPUModels =
            { "GTX 980M", "GeForce GTX 1060 6GB", "AMD Radeon (TM) R9 Fury Series", "Tahiti",
                "Iris Pro", "Intel(R) HD Graphics 530", "Iris" };
        internal readonly string[] GPUMemory =
            { "1GB", "2GB", "3GB", "4GB", "5GB", "6GB", "7GB", "8GB" };

        [ThreadStatic]
        private static Random random = new Random();

        public GPU Generate()
        {
            return new GPU
            {
                Type = GPUTypes[random.Next(0, GPUTypes.Length)],
                Vendor = GPUVendors[random.Next(0, GPUVendors.Length)],
                Model = GPUModels[random.Next(0, GPUModels.Length)],
                Memory = GPUMemory[random.Next(0, GPUMemory.Length)]
            };
        }
    }
}
