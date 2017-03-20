namespace AdoNetHomework
{
    using System;
    using System.Data.SqlClient;

    class CategoriesAndProducts
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");
            con.Open();

            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT c.CategoryName, p.ProductName FROM Categories c JOIN Products p ON c.CategoryID = p.CategoryID ORDER BY c.CategoryName", con);
                var productsInCategories = command.ExecuteReader();
                using (productsInCategories)
                {
                    while(productsInCategories.Read())
                    {
                        Console.WriteLine("{0} - {1}", productsInCategories["CategoryName"], productsInCategories["ProductName"]);
                    }
                }
            }
        }
    }
}
