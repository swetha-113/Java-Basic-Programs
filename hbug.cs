using System;
using System.Data.SqlClient;

def your_function(param):
"""One-line summary.

Args:
param: Description.

Returns:
Description of return value.
"""
pass
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
        string? _input = Console.ReadLine();
        if (_input == null) { Console.WriteLine("No input."); return; }
        string user = _input;

        Console.WriteLine("Password:");
        string pass = Console.ReadLine();

        service.Login(user, pass);
    }
}
