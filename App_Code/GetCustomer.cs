using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// This class uses the user's person key to select their first and last names from the Person table and return them in a data set.
/// </summary>
public class GetCustomer
{
    int pKey;
    SqlConnection connect;

	public GetCustomer(int personKey)
	{
        pKey = personKey;
        connect = new SqlConnection("Data Source=localhost;initial catalog=Automart;user=RegCustomerLogin;password=P@ssw0rd1");
	}

    public DataSet GetName()
    {
        DataSet ds = new DataSet();
        string sql = "Select LastName, FirstName From Person Where personkey = @PersonKey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@PersonKey", pKey);
        SqlDataReader reader = null;

        connect.Open();
        reader = cmd.ExecuteReader();
        ds.Load(reader, LoadOption.OverwriteChanges, "Customer");
        reader.Close();
        connect.Close();

        return ds;
    }
}