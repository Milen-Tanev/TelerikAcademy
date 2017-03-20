namespace NorthwindEF.NorthwindConsoleApp
{
    using System;
    using NorthwindDB;

    public class Program
    {
        static void Main(string[] args)
        {
            // Comment/uncomment tasks for better performance

            //TestSecondTask();

            //TestThirdTask();

            //TestFourthTask();

            //TestFifthTask();
        }

        static void TestSecondTask()
        {
            Console.WriteLine("Second task:");
            DAO.GetAllCustomers();
            var separator = new string('-', 50);
            Console.WriteLine("Peshoooo000o should be missing");
            Console.WriteLine(separator);

            Customer customer = new Customer()
            {
                CustomerID = "ZZZZZ",
                CompanyName = "I will be deleted",
                ContactName = "Peshoooo000o"
            };

            Console.WriteLine("Insert customer");
            DAO.InsertCustomer(customer);
            DAO.GetAllCustomers();
            Console.WriteLine("Peshoooo000o should be right above ^");
            Console.WriteLine(separator);

            Console.WriteLine("Remove customer");
            DAO.RemoveCustomer(customer);
            DAO.GetAllCustomers();
            Console.WriteLine("Peshoooo000o should be missing again");
            Console.WriteLine(separator);
        }

        static void TestThirdTask()
        {
            var customers = DAO.CustomersOrderedInDefinedYearFromCountry(1997, "Canada");

            Console.WriteLine("Third task");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.ContactName} from {customer.Country}");
            }

            Console.WriteLine();
        }

        static void TestFourthTask()
        {
            var customers = DAO.CustomersOrderedInDefinedYearFromCountryWithNativeSQL(1997, "Canada");

            Console.WriteLine("Fourth task");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.ContactName} from {customer.Country}");
            }

            Console.WriteLine();
        }
        
        static void TestFifthTask()
        {
            var orders = DAO.SalesByRegionAndPeriod("SP", new DateTime(1997, 1, 1), new DateTime(1997, 6, 6));
            foreach (var item in orders)
            {
                Console.WriteLine(item.ShipRegion + " " + item.ShippedDate);
            }
        }
    }
}
