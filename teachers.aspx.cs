using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class teachers : System.Web.UI.Page
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
            var st = from s in db.teachers
                     select s;

            GridView1.DataSource = st;
            GridView1.DataBind();

            ListBox1.DataSource = st;
            ListBox1.DataTextField = "cat_name";
            ListBox1.DataValueField = "cat_id";
            ListBox1.DataBind();
        }
    }


    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("dashboard.aspx");
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            teacher tc = new teacher()
            {
                cat_name = TeachName.Text,
                t_email = TeachEmail.Text,
                t_address = TeachAddress.Text,
                t_gender = TeachGender.Text,
                t_dob = TeachDOB.Text,
                t_salary = Convert.ToInt32(TeachSalary.Text)
            };

            db.teachers.InsertOnSubmit(tc);
            db.SubmitChanges();
        }

        TeachName.Text = TeachEmail.Text = TeachDOB.Text = TeachAddress.Text = TeachGender.Text = TeachSalary.Text = "";
        UpdateGrid();
    }

    protected void btnUp_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);
            teacher st = db.teachers.First(s => s.cat_id == selectedid);

            st.cat_name = TeachName.Text;
            st.t_email = TeachEmail.Text;
            st.t_address = TeachAddress.Text;
            st.t_gender = TeachGender.Text;
            st.t_dob = TeachDOB.Text;
            st.t_salary = Convert.ToInt32(TeachSalary.Text);
            
            db.SubmitChanges();
        }

        TeachName.Text = TeachEmail.Text = TeachDOB.Text = TeachAddress.Text = TeachGender.Text = TeachSalary.Text = "";
        UpdateGrid();

        btnAdd.Visible = true;
        btnUp.Visible = false;
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);
            teacher st = db.teachers.First(s => s.cat_id == selectedid);

            db.teachers.DeleteOnSubmit(st);
            db.SubmitChanges();
        }

        TeachName.Text = TeachEmail.Text = TeachDOB.Text = TeachAddress.Text = TeachGender.Text = TeachSalary.Text = "";
        UpdateGrid();

        btnAdd.Visible = true;
        btnUp.Visible = false;

    }
    

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

        using (var db = new LogUserDataContext())
        {
            int selectedid = Convert.ToInt32(ListBox1.SelectedValue);

            //var st = from s in db.Students
            //         where s.Id == selectedid
            //         select s;

            teacher st = db.teachers.First(s => s.cat_id == selectedid);

            TeachName.Text = st.cat_name;
            TeachAddress.Text = st.t_address;
            TeachDOB.Text = st.t_dob;
            TeachEmail.Text = st.t_email;
            TeachGender.Text = st.t_gender;
            TeachSalary.Text = st.t_salary.ToString();

            btnAdd.Visible = false;
            btnUp.Visible = true;

        }

    }
}