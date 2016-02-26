using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["ID"] != null)
        {
            logoutB.Visible = true;
        }

        if (Session["LogInFirst"] != null)
        {
            
            Response.Write("<script>alert('Log In First');</script>");
            Session["LogInFirst"] = null;
        }

    }

    protected void logoutB_Click(object sender, EventArgs e)
    {
        Session["ID"] = Session["Username"] = Session["Class"] = Session["Email"] = Session["Country"] = Session["Firstname"] =
        Session["Lastname"] = Session["Gender"] = Session["Age"] = Session["Address"] = null;
        Response.Redirect("Home.aspx");

    }
}