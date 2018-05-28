using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext() )
        {
            var user = TextBoxUser.Text;
            var pass = TextBoxPass.Text;
            //var up = from lp in db.LogUsers
            //         select lp;
            var up = db.LogUsers.SingleOrDefault(y => y.Username == user);

            if (up == null)
            {
                // something error means no data in table
            }

            if (up.Password == pass)
            {
                // do something (correct password)
                Session["id"] = TextBoxUser.Text;
                Response.Redirect("dashboard.aspx");
                Session.RemoveAll();
            }
            else
            {
                // something else (incorrect password)
                LblMsg.Text = " Username and Password is incorrect";
            }
        }
    }
}