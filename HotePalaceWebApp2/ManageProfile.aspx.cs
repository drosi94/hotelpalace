using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class ManageProfile : System.Web.UI.Page
{

    String firstName, lastName, gender, address;
    int age = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["ID"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (Session["Firstname"] != null)
        {
            firstNameTB.Text = (String)Session["Firstname"];
            lastNameTB.Text = (String)Session["Lastname"];
            genderDPL.SelectedItem.Text = (String)Session["Gender"];
            addressTB.Text = (String)Session["Address"];

            formT.Visible = false;
            manageProfileL.Visible = true;
            editProfileB.Visible = true;
        }


    }
    protected void submitB_Click(object sender, EventArgs e)
    {
        if (Session["ID"] != null)
        {
            int userID = (int) Session["ID"];
          
            firstName = firstNameTB.Text;
            lastName = lastNameTB.Text;
            gender = genderDPL.SelectedItem.ToString();
            try
                {
                    age = Convert.ToInt32(ageTB.Text);
                }
            catch (Exception ex)
                {
                    Response.Write(ex.Message.ToString());
                }
            address = addressTB.Text;
            

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString);

            conn.Open();

            string insertUserDetails = "Insert Into Website.UserDetails(ID, FirstName, LastName, Gender, Age, Address) values(@id, @FirstName, @LastName, @Gender, @Age, @Address)";

            SqlCommand comm = new SqlCommand(insertUserDetails, conn);

            comm.Parameters.AddWithValue("@id", userID);
            comm.Parameters.AddWithValue("@FirstName", firstName);
            comm.Parameters.AddWithValue("@LastName", lastName);
            comm.Parameters.AddWithValue("@Gender", gender);
            comm.Parameters.AddWithValue("@Age", age);
            comm.Parameters.AddWithValue("@Address", address);


            comm.ExecuteNonQuery();
           

            conn.Close();

            Response.Redirect("ManageProfile.aspx");

        }
    }


    protected void editProfileB_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString);

        conn.Open();

        string deleteUserDetails = "Delete From Website.UserDetails Where ID = " + Session["ID"];
        SqlCommand deleteUserDetailscomm = new SqlCommand(deleteUserDetails, conn);
        deleteUserDetailscomm.ExecuteNonQuery();

        conn.Close();

        Session["Firstname"] = null;
        Session["Lastname"] = null;
        Session["Age"] = null;
        Session["Gender"] = null;
        Session["Address"] = null;

        Response.Redirect("ManageProfile.aspx");
    }
}