using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{

    int temp = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["ID"] != null){

            Response.Write("You Are Already Log In");
            Response.Redirect("Home.aspx");

        }
        else
        {
            if (IsPostBack)
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString);
                conn.Open();

                string checkUser = "Select count(*) from Website.Users where UserName ='" + userNameTB.Text + "'";

                SqlCommand comm = new SqlCommand(checkUser, conn);
                temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
                if (temp == 1)
                {

                    Response.Write("User Already Exists");
                }

                conn.Close();

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (temp == 0)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString);
                conn.Open();

                string insertUser = "Insert Into Website.Users(UserName, Password, Email, Country) values(@Uname, @password, @email, @country)";

                SqlCommand comm = new SqlCommand(insertUser, conn);

                comm.Parameters.AddWithValue("@Uname", userNameTB.Text);
                comm.Parameters.AddWithValue("@password", passwordTB.Text);
                comm.Parameters.AddWithValue("@email", emailTB.Text);
                comm.Parameters.AddWithValue("@country", countryDDL.SelectedItem.ToString());

                comm.ExecuteNonQuery();
                Response.Redirect("Home.aspx");
               

                conn.Close();
            }
            catch (Exception ex)
            {

                Response.Write("Error: " + ex.ToString());

            }
        }
    }
}