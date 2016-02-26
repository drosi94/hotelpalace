using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Hotel : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["ID"] != null)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString);

            conn.Open();

            string findUserDetails = "Select FirstName, Lastname, Age, Gender, Address from Website.UserDetails where ID ='" + Session["ID"] + "'";

            SqlCommand findUserDetailsComm = new SqlCommand(findUserDetails, conn);

            SqlDataReader userDetails = findUserDetailsComm.ExecuteReader();

            if(userDetails.HasRows)
            {
                while (userDetails.Read())
                {
                    Session["Firstname"] = (String)userDetails[0];
                    Session["Lastname"] = (String)userDetails[1];
                    Session["Age"] = (int)userDetails[2];
                    Session["Gender"] = (String)userDetails[3];
                    Session["Address"] = (String)userDetails[4];
                }
            }
            else
            {
                Session["Firstname"] = null;
                Session["Lastname"] = null;
                Session["Age"] = null;
                Session["Gender"] = null;
                Session["Address"] = null;
            }

            userDetails.Close();

            conn.Close();


            if (Session["Firstname"] == null)
                userNameLabel.Text = (String)Session["Username"];
            else
                userNameLabel.Text = (String)Session["Firstname"] + " " + (String)Session["Lastname"];

            registerHL.Visible = false;
            logInHL.Visible = false;

            if ((int)Session["Class"] == 0)
            {
                adminHL.Visible = false;
            }

        }
        else
        {
            userNameLabel.Text = "Guest";
            manageProfileHL.Visible = false;
            adminHL.Visible = false;
        }
    }

}
