using NorthwindEF.NorthwindDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindEF.NorthwindConsoleApp
{
    class DAO
    {
        public static void GetAllCustomers()
        {
            // Used for testing
            List<Customer> allCustomers = new List<Customer>();

            using (var db = new NorthwindEntities())
            {
                allCustomers = db.Customers.ToList();
            }

            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"{customer.ContactName} - {customer.CustomerID}");
            }
        }

        public static void InsertCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Customer cannot be null");
            }

            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void ModifyCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Customer cannot be null");
            }

            using (var db = new NorthwindEntities())
            {
                Customer customerToModify = db.Customers
                    .Where(c => c.CustomerID == customer.CustomerID)
                    .FirstOrDefault();

                if (customerToModify == null)
                {
                    throw new ArgumentException("Customer not found");
                }
                else
                {
                    db.Entry(customerToModify).CurrentValues.SetValues(customer);
                    db.SaveChanges();
                }
            }
        }

        public static void RemoveCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Customer to remove cannot be null");
            }

            using (var db = new NorthwindEntities())
            {
                Customer customerToRemove = db.Customers
                    .Where(c => c.CustomerID == customer.CustomerID)
                    .FirstOrDefault();
                db.Customers.Remove(customerToRemove);
                db.SaveChanges();
            }
        }

        public static IEnumerable<Customer> CustomersOrderedInDefinedYearFromCountry(int year, string country)
        {
            var customers = new List<Customer>();
            using (var db = new NorthwindEntities())
            {
                customers = db.Orders
                    .Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == country)
                    .Select(o => o.Customer)
                    .ToList();
            }
            return customers;
        }

        public static IEnumerable<Customer> CustomersOrderedInDefinedYearFromCountryWithNativeSQL(int year, string country)
        {
            var customers = new List<Customer>();
            string query = string.Format(@"SELECT *
                FROM Customers c
                JOIN Orders o
                    ON o.CustomerID = c.CustomerID
                WHERE YEAR(o.OrderDate) = {0} AND o.ShipCountry = '{1}'", year, country);
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.SqlQuery(query).ToList();
            }
            return customers;
        }

        public static IEnumerable<Order> SalesByRegionAndPeriod(string region, DateTime startPeriod, DateTime endPeriod)
        {
            IEnumerable<Order> orders;
            using (var db = new NorthwindEntities())
            {
                orders = db.Orders
                    .Where(o => o.ShipRegion == region)
                    .Where(o => o.OrderDate > startPeriod && o.OrderDate < endPeriod)
                    .ToList();
            }

            return orders;
        }
    }
}
