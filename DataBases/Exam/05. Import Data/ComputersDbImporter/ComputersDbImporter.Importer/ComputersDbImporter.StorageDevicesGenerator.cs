namespace ComputersDbImporter.Importer
{
    using System;
    using Data;

    public class StorageDevicesGenerator
    {
        internal readonly string[] StorageDeviceVendors =
            { "Blue Coat Systems", "EMC", "SanDisk", "Toshiba", "Lenovo", "Maxtor", "Samsung",
            "Quantum", "Hitachi", "Dataram" };
        internal readonly string[] StorageDeviceModels =
            { "ADATA S596 Turbo", "Corsair CSSD-F60GB2", "Intel NVMe", "EVO M.2",
                "KINGSTON SNVP325S264GB", "Patriot Inferno", "SAMSUNG MMCQE28G8MUP-0VA",
                "SD400DM000", "MD04ABA500V" };
        internal readonly string[] StorageDeviceTypes =  {"SSD", "HDD", "HDD", "HDD" };
        internal readonly string[] StorageDevceSizes =
            { "60 GB", "80 GB", "120 GB", "300 GB", "500 GB", "1 TB", "2 TB", "4 TB" };

        [ThreadStatic]
        private static Random random = new Random();

        public StorageDevice Generate()
        {
            return new StorageDevice
            {
                Vendor = StorageDeviceVendors[random.Next(0, StorageDeviceVendors.Length)],
                Model = StorageDeviceModels[random.Next(0, StorageDeviceModels.Length)],
                Type = StorageDeviceTypes[random.Next(0, StorageDeviceTypes.Length)],
                Size = StorageDevceSizes[random.Next(0, StorageDevceSizes.Length)]
            };
        }
    }
}
