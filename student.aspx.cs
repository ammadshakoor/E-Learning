using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class student : System.Web.UI.Page
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

            GridView1.DataSource = st;
            GridView1.DataBind();

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
            catg cg = new catg()
            {
                cat_name = StudName.Text,
                s_address = StudAddress.Text,
                s_dob = StudDOB.Text,
                s_gender = StudGender.Text,
                s_email = StudEmail.Text,
                s_sem = Convert.ToInt32(StudSem.Text)
            };

            db.catgs.InsertOnSubmit(cg);
            db.SubmitChanges();
        }
        StudEmail.Text = StudAddress.Text = StudName.Text = StudGender.Text = StudSem.Text = StudDOB.Text = "";
        UpdateGrid();
    }

    protected void btnUp_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);
            catg st = db.catgs.First(s => s.cat_id == selectedid);

            st.cat_name = StudName.Text;
            st.s_email = StudEmail.Text;
            st.s_address = StudAddress.Text;
            st.s_gender = StudGender.Text;
            st.s_dob = StudDOB.Text;
            st.s_sem = Convert.ToInt32(StudSem.Text);

            db.SubmitChanges();
        }

        StudName.Text = StudEmail.Text = StudDOB.Text = StudAddress.Text = StudGender.Text = StudSem.Text = "";
        UpdateGrid();

        btnAdd.Visible = true;
        btnUp.Visible = false;
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);
            catg st = db.catgs.First(s => s.cat_id == selectedid);

            db.catgs.DeleteOnSubmit(st);
            db.SubmitChanges();
        }

        StudName.Text = StudEmail.Text = StudDOB.Text = StudAddress.Text = StudGender.Text = StudSem.Text = "";
        UpdateGrid();

        btnAdd.Visible = true;
        btnUp.Visible = false;

    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("dashboard.aspx");

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
            StudAddress.Text = st.s_address;
            StudDOB.Text = st.s_dob;
            StudEmail.Text = st.s_email;
            StudGender.Text = st.s_gender;
            StudSem.Text = st.s_sem.ToString();

            btnAdd.Visible = false;
            btnUp.Visible = true;

        }

    }
}