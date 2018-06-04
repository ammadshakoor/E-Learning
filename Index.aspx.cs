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
            // Field values
            var User = TextBoxUser.Text;
            var Pass = TextBoxPass.Text;

            // stored procedure for login
            var s = from d in db.LoginVerify(User, Pass)
                    select d;

            //var q = from p in db.LogUsers
            //        where p.Username == User
            //        && p.Password == Pass
            //        select p;

            if (s.Any())
            {
                // do something (correct password)
                Session["id"] = TextBoxUser.Text;
                Response.Redirect("dashboard.aspx?id" + User);
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
