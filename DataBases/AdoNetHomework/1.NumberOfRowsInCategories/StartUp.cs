namespace AdoNetHomework
{
    using System;
    using System.Data.SqlClient;

    public class NumberOfRowsInCategories
    {
        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=Northwind;Integrated Security=true");
            con.Open();

            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM CATEGORIES", con);
                var categoryCount = command.ExecuteScalar();
                Console.WriteLine("The number of rows in the Categories table is {0}", categoryCount);
            }
        }
    }
}
