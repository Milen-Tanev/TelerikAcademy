namespace AdoNetHomework
{
    using System;
    using System.Data.SqlClient;

    class AddProduct
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");
            con.Open();

            using (con)
            {
                SqlCommand addCommand = new SqlCommand("CREATE PROC dbo.uspInsertInProducts(@productName nvarchar(40), @discontinued bit) AS INSERT INTO Products(ProductName, Discontinued) VALUES(@productName, @discontinued)", con);

                // Test
                SqlCommand executeAddCommand = new SqlCommand("EXEC dbo.uspInsertInProducts 'Zaio Baio', 0", con);
                executeAddCommand.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("SELECT ProductName FROM Products", con);
                var productsInCategories = command.ExecuteReader();
                using (productsInCategories)
                {
                    while (productsInCategories.Read())
                    {
                        Console.WriteLine(productsInCategories["ProductName"]);
                    }
                }
            }
        }
    }
}
