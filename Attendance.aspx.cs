using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Attendance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            UpdateGrid();
    }


    private void UpdateGrid()
    {
        using (var db = new LogUserDataContext())
        {
            var st = from s in db.catgs
                     select s;
            

            ListBox1.DataSource = st;
            ListBox1.DataTextField = "cat_name";
            ListBox1.DataValueField = "cat_id";
            ListBox1.DataBind();
        }
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);
            catg st = db.catgs.First(s => s.cat_id == selectedid);

            st.cat_name = StudName.Text;
            st.s_attend = Convert.ToInt32(StudAttend.Text);

            db.SubmitChanges();
        }

        StudName.Text = StudAttend.Text = "";
        UpdateGrid();
        

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);

            //var st = from s in db.Students
            //         where s.Id == selectedid
            //         select s;

            catg st = db.catgs.First(s => s.cat_id == selectedid);

            StudName.Text = st.cat_name;
            StudAttend.Text = st.s_attend.ToString();
            
        }

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("dashboard.aspx");
    }
}