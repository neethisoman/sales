using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestApplication3.Connection;

namespace TestApplication3
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionHandler connection = new ConnectionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(Object sender, EventArgs e)
        {
            if (loginName.Text != null && password.Text != null)
            {
                connection.SetConnection();
                var query = "select count(*) from tbl_user where username='" + loginName.Text + "' and password='" + password.Text + "'";
                if (connection.CheckUser(query))
                {
                    Server.Transfer("~/Pages/Home.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box", "<script language = 'javascript'>alert('you entered incorrect password or username')</script>");
                    return;
                }
            }
        }
    }
}