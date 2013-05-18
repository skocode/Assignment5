using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// This class connects to the Automart database and validates the user-entered user name and password
/// with the information in the Customer.RegisteredCustomer table. 
/// It then returns the person key of the user that is logging in.
/// </summary>
public class CustomerLogin
{
    private SqlConnection connect;

    public CustomerLogin()
    {
        connect = new SqlConnection(@"Data Source=localhost;initial catalog=Automart;user=CustomerLogin;password=P@ssw0rd1");
    }

    public int Login(string userName, string password)
    {
        int pKey = 0;
        string sql = "Select PersonKey, Email,  CustomerPassword From Customer.RegisteredCustomer Where Email=@user and CustomerPassword=@password";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@user", userName);
        cmd.Parameters.AddWithValue("@password", password);
        SqlDataReader reader = null;

        connect.Open();
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (reader["personKey"] != null)
            {
                pKey = (int)reader["personKey"];
            }
        }
        reader.Close();
        connect.Close();

        return pKey;
    }
}