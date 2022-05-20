using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationOnVisualStudio
{
    public class CrudOperation
    {
        public static void create(string connection)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string query = "select * from Customers";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["CustomerID"]);
                Console.WriteLine(reader["CustomerName"]);
                Console.WriteLine(reader["ContactName"]);
                Console.WriteLine(reader["Address"]);
                Console.WriteLine(reader["City"]);
                Console.WriteLine(reader["PostalCode"]);
                Console.WriteLine(reader["Price"]);
            }
        }
        public static void insert(string connection)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            string query = "insert into Customers (CustomerID,CustomerName,ContactName,Address,City,PostalCode) values(6,'kiran','kb','latur','kc',413512)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("data inserted successfully");
            }
            else
            {
                Console.WriteLine("data not inserted");
            }
        }
        public static void update(string connection)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            string query = "UPDATE Customers SET CustomerName='samuels', CustomerID=2 WHERE CustomerName='kiran'";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("data updated successfully");
            }
            else
            {
                Console.WriteLine("data not updated");
            }
        }
        public static void delete(string connection)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            string query = "DELETE FROM Customers WHERE CustomerID = 5";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("data deleted successfully");
            }
            else
            {
                Console.WriteLine("data not deleted");
            }
        }

    }
}
