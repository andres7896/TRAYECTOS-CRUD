using DataLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trayectos_CRUD.Pages.Vehiculos
{
    public partial class Index : System.Web.UI.Page
    {
        private readonly VehiculosLogica lg = new VehiculosLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var vehiculos = lg.GetAll();
                gvVehiculos.DataSource = vehiculos;
                gvVehiculos.DataBind();
            }
        }
        protected void Delete(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int id = int.Parse(((GridViewRow)btn.NamingContainer).Cells[0].Text);
            bool eliminado = lg.Delete(id);
            if (eliminado)
            {
                var vehiculos = lg.GetAll();
                gvVehiculos.DataSource = vehiculos;
                gvVehiculos.DataBind();
            }
            else
            {
                Response.Redirect("~/Pages/Index.aspx");
            }
        }
        protected void RedirectTo(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.ID)
            {
                case "btnAdd":
                    Response.Redirect("~/Pages/Vehiculos/Form.aspx");
                    break;
                case "btnUpdate":
                    Response.Redirect($@"~/Pages/Vehiculos/Form.aspx?id={((GridViewRow)btn.NamingContainer).Cells[0].Text}");
                    break;
                default:
                    Response.Redirect("~/Pages/Index.aspx");
                    break;
            }
        }
        protected void Volver(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Index.aspx");
        }
    }
}