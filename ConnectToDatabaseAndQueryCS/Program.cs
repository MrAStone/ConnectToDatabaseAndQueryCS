using MySqlConnector;
namespace ConnectToDatabaseAndQueryCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serverDetails = "server=172.16.11.131;uid=astone;pwd=BPmXzkau;database=astone_test";
            MySqlConnection con = new MySqlConnection(serverDetails);
            MySqlCommand cmd = new MySqlCommand();
            //Simple count query - returns 1 result
            String SQL = "SELECT COUNT(SoftwareID) FROM SoftwareLicence";
            cmd.CommandText = SQL;
            cmd.Connection = con;
            con.Open(); // open connection
            int result = Convert.ToInt32(cmd.ExecuteScalar()); // result is known to be integer
            Console.WriteLine(result);
            con.Close(); // close connection
            SQL = "SELECT * FROM SoftwareLicence";
            cmd.CommandText = SQL;
            con.Open();
            MySqlDataReader results = cmd.ExecuteReader(); // results are going to be multiple
            while(results.Read())
            {
                Console.WriteLine(results[0]); // first column
            }
            con.Close ();

            con.Open ();
            results = cmd.ExecuteReader(); // results are going to be multiple
            while (results.Read())
            {
                for(int i = 0;i<results.FieldCount;i++)
                {
                    Console.Write(results[i] + " ");
                }
                Console.WriteLine();
            }
            con.Close();


        }
    }
}
