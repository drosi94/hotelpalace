using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void logInB_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString);
        conn.Open();
        
    
        string checkUser = "Select count(*) from Website.Users where UserName ='" + userNameTB.Text + "'";

        SqlCommand comm = new SqlCommand(checkUser, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        
        conn.Close();

        if (temp == 1)
        {

            conn.Open();

            string checkPassword = "Select Password from Website.Users where UserName ='" + userNameTB.Text + "'";

            SqlCommand passComm = new SqlCommand(checkPassword, conn);
            string password = passComm.ExecuteScalar().ToString();

            conn.Close();
            if (password.Equals(passwordTB.Text))
            {
                conn.Open();

                string findUserID = "Select ID from Website.Users where UserName ='" + userNameTB.Text + "'";

                SqlCommand findUserIDComm = new SqlCommand(findUserID, conn);

                int ID =  Convert.ToInt32(findUserIDComm.ExecuteScalar());

                conn.Close();



                conn.Open();

                string findUserClass = "Select Class from Website.Users where UserName ='" + userNameTB.Text + "'";

                SqlCommand findUserClassComm = new SqlCommand(findUserClass, conn);

                int userClass = Convert.ToInt32(findUserClassComm.ExecuteScalar());

                conn.Close();



                conn.Open();

                string findUserCountry = "Select Country from Website.Users where UserName ='" + userNameTB.Text + "'";

                SqlCommand findUserCountryComm = new SqlCommand(findUserCountry, conn);

                String country = findUserCountryComm.ExecuteScalar().ToString();

                conn.Close();



                conn.Open();

                string findUserEmail = "Select Email from Website.Users where UserName ='" + userNameTB.Text + "'";

                SqlCommand findUserEmailComm = new SqlCommand(findUserEmail, conn);

                String email = findUserCountryComm.ExecuteScalar().ToString();

                conn.Close();


                Session["ID"] = ID;
                Session["Class"] = userClass;
                Session["Username"] = userNameTB.Text;
                Session["Country"] = country;
                Session["Email"] = email; 

                Response.Write("Log In Succesfully");
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Wrong Password");
            }


        }
        else
        {
            Response.Write("User Not Found");
        }


    }
}