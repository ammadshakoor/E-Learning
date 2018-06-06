using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Threading;

public partial class dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");

            PagesSection pages = (PagesSection)config.GetSection("system.web/pages");

            ddlTheme.SelectedValue = ddlTheme.Items.FindByText(pages.Theme).Value;

        }
        if (Session["id"] != null)
        {
            LblName.Text = Session["id"].ToString();
        }
        else
        {
            Session.RemoveAll();
            
        }
        try
        {
            Label lbl = this.Master.FindControl("LblMasterPage") as Label;
            lbl.Text = Session["id"].ToString();
        }
        catch (NullReferenceException ex)
        {
            LblName.Text = ex.ToString();
        }
    }

    protected override void OnPreInit(EventArgs e)
    {
        if (Request["ddlTheme"] != null)
        {
            string theme = Request["ddlTheme"].ToString();
            Page.Theme = theme;
        }
        base.OnPreInit(e);
    }

    protected override void InitializeCulture()
    {
        if (Request["DropDownList1"] != null)
            {

            string lang = Request["DropDownList1"].ToString();
            
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

             
            }
        base.InitializeCulture();
    }


    protected void BtnLogout_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("Index.aspx");
    }

    protected void ddlTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");

        PagesSection pages = (PagesSection)config.GetSection("system.web/pages");

        pages.Theme = ddlTheme.SelectedItem.Text.ToString();

        if (!pages.SectionInformation.IsLocked)
        {
            config.Save();
            Response.Redirect("dashboard.aspx");
        }
        else
        {
            Response.Write("<script>alert('Could not save configuration')</script>");
        }
        using (var db = new LogUserDataContext())
        {
            LogUser lu = new LogUser()
            {
                Theme = pages.Theme.ToString(),
                Language = DropDownList1.SelectedValue.ToString()
            };
            db.SubmitChanges();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        using (var db = new LogUserDataContext())
        {
            LogUser lu = new LogUser()
            {
                Language = DropDownList1.SelectedValue.ToString()
            };

            db.SubmitChanges();
        }
    }
}
