using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Reserve : System.Web.UI.Page
{

    DataTable roomsAvailable;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Session["LogInFirst"] = "You have to log in first.";
            
            Response.Redirect("Home.aspx");

        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        startDateRV.MinimumValue = DateTime.Now.Date.ToString("dd/MM/yyyy");
        startDateRV.MaximumValue = DateTime.Now.Date.AddYears(200).ToString("dd/MM/yyyy");
    }

    protected void findRoomsB_Click(object sender, EventArgs e)
    {
        DateTime startDate = DateTime.Parse(startDateTB.Text);

        DateTime endtDate = DateTime.Parse(endDateTB.Text);


        roomsAvailable = new DataTable();


        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString))
        {


            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select Rooms.ID, Rooms.Name From Website.Rooms As Rooms left Join  Website.Reserves As Reserves On Rooms.ID = Reserves.RoomID", conn);

                adapter.Fill(roomsAvailable);

                roomsDPL.DataSource = roomsAvailable;
                roomsDPL.DataTextField = "Name";
                roomsDPL.DataValueField = "ID";
                roomsDPL.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }

        }


    }

    protected void sumbitRoomsB_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["p3120038ConnectionString"].ConnectionString))
        {
            try
            {

                conn.Open();

                string insertReserve = "Insert Into Website.Reserves(UserID, RoomID, StartDate, EndDate,Price)"
                    + "values(@Uid, @rid, @sd, @ed ,@p)";

                SqlCommand comm = new SqlCommand(insertReserve, conn);

                comm.Parameters.AddWithValue("@Uid", Session["ID"]);
                comm.Parameters.AddWithValue("@rid", Convert.ToInt32(roomsDPL.SelectedValue));
                comm.Parameters.AddWithValue("@sd", startDateTB.Text);
                comm.Parameters.AddWithValue("@ed", endDateTB.Text);
                comm.Parameters.AddWithValue("@p", 200);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }
    }
}