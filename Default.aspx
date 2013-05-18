<!--Assignment 5 Summary:
    This website displays a login form asking for a user name and password. 
    After the login information is entered, it uses the CustomerLogin class 
    to verify the entered information against the Customer.RegisteredCustomer 
    table in the Automart database. If the login information is valid, 
    the site redirects to page Default2.aspx and uses the GetCustomer class 
    to retrieve the first and last name of the customer associated with the entered login information. 
    The user's full name is then displayed in a welcome message on page Default2.aspx.

    Sonya Ortis, 5/17/2013
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- This code displays a login form in which the user can enter their user name and password. -->
        <h1>Customer Login</h1>
        <table>
            <tr>
                <td>User Name</td>
                <td><asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click" /></td>
                <td><asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
