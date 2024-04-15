using MySqlConnector;
namespace ConnectToDatabaseAndQueryCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serverDetails = "server=172.16.11.131;uid=astone;pwd=BPmXzkau;database=astone_test";
            MySqlConnection con = new MySqlConnection(serverDetails);

        }
    }
}
