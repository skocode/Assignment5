using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    
    /// <summary>
    /// This code uses the GetCustomer class to retrieve the first and last name
    /// of the user associated with the entered login information.
    /// It then displays the name in a welcome message on the page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["person"] != null)
        {
            int personKey = (int)Session["person"];
            GetCustomer gc = new GetCustomer(personKey);

            string customerName = null;
            DataSet ds = gc.GetName();

            foreach (DataRow row in ds.Tables["Customer"].Rows)
            {
                customerName = row["FirstName"].ToString() + " " + row["LastName"].ToString();
            }

            lblCustomerName.Text = "Welcome " + customerName + "!";

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

}