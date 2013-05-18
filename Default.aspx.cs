using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// When the button is clicked, this code uses the CustomerLogin class to validate the entered user name and password. If they are valid, it redirects to Default2.aspx. If they are invalid, it will display an invalid login message.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Button1_Click(object sender, EventArgs e)
    {
        CustomerLogin cl = new CustomerLogin();
        int pk = cl.Login(txtuser.Text, txtpassword.Text);
        if (pk != 0)
        {
            Session["person"] = pk;
            Response.Redirect("Default2.aspx");
        }
        else
        {
            lblmsg.Text = "Invalid Login";
        }
    }
}