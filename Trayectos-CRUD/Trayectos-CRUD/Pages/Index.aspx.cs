using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trayectos_CRUD.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedirectTo(object sender, EventArgs e)
        {
            string url = "";
            Button btn = (Button)sender;
            var id = btn.ID;
            switch (id)
            {
                case "btnVehiculos":
                    Response.Redirect("~/Pages/Vehiculos/Index.aspx");
                    break;
                case "btnConductores":
                    Response.Redirect("~/Pages/Conductores/Index.aspx");
                    break;
                case "btnTrayectos":
                    Response.Redirect("~/Pages/Trayectos/Index.aspx");
                    break;
                default:
                    Response.Redirect("~/Pages/Index.aspx");
                    break;
            }
        }
    }
}