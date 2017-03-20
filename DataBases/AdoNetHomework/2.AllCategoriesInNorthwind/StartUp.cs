namespace AdoNetHomework
{
    using System;
    using System.Data.SqlClient;

    class AllCategoriesInNortwind
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");
            con.Open();

            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", con);
                var categories = command.ExecuteReader();
                using (categories)
                {
                    while (categories.Read())
                    {
                        Console.WriteLine("{0}: {1}", categories["CategoryName"], categories["Description"]);
                    }
                }
            }
        }
    }
}
