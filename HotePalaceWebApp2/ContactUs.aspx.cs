using HotePalaceWebApp2;
using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact_Us : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GLatLng mainLocation = new GLatLng(37.86, 23.75);
            GMap1.setCenter(mainLocation, 15);

            XPinLetter xpinLetter = new XPinLetter(PinShapes.pin_star, "H", Color.Blue, Color.White, Color.Chocolate);
            GMap1.Add(new GMarker(mainLocation, new GMarkerOptions(new GIcon(xpinLetter.ToString(), xpinLetter.Shadow()))));

            List<HotelMaster> hotels = new List<HotelMaster>();
            using (p3120038Entities dc = new p3120038Entities())
            {
               
                hotels = dc.HotelMaster.Where(a => a.HotelArea.Equals("Athens")).ToList();
            }

            PinIcon p;
            GMarker gm;
            GInfoWindow win;
            foreach (var i in hotels)
            {
                try
                {
                    p = new PinIcon(PinIcons.home, Color.Cyan);
                    gm = new GMarker(new GLatLng(Convert.ToDouble(i.LocLat), Convert.ToDouble(i.LocLong)),
                        new GMarkerOptions(new GIcon(p.ToString(), p.Shadow())));

                    win = new GInfoWindow(gm, i.HotelName + " <a href='" + i.ReadMoreUrl + "'>Read more...</a>", false, GListener.Event.mouseover);
                    GMap1.Add(win);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}