using System;
using System.Data.SqlClient;

class LoginService
{
    public bool Login(string username, string password)
    {
        string connectionString =
            "Server=localhost;Database=UsersDB;User Id=admin;Password=Admin123!";

        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query =
            "SELECT * FROM Users WHERE Username='" + username +
            "' AND Password='" + password + "'";

        SqlCommand cmd = new SqlCommand(query, conn);

        SqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            Console.WriteLine("Login Successful");
            return true;
        }

        return false;
    }

    static void Main()
    {
        LoginService service = new LoginService();

        Console.WriteLine("Username:");
        string user = Console.ReadLine();

        Console.WriteLine("Password:");
        string pass = Console.ReadLine();

        service.Login(user, pass);
    }
}
