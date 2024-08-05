using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trayectos_CRUD.Pages.Trayectos
{
    public partial class Index : System.Web.UI.Page
    {
        private readonly TrayectosLogica lg = new TrayectosLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var trayectos = lg.GetByFilters();
                gvTrayectos.DataSource = trayectos;
                gvTrayectos.DataBind();
            }
        }
        protected void Delete(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int id = int.Parse(((GridViewRow)btn.NamingContainer).Cells[0].Text);
            bool eliminado = lg.Delete(id);
            if (eliminado)
            {
                var vehiculos = lg.GetByFilters();
                gvTrayectos.DataSource = vehiculos;
                gvTrayectos.DataBind();
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
                    Response.Redirect("~/Pages/Trayectos/Form.aspx");
                    break;
                case "btnUpdate":
                    Response.Redirect($@"~/Pages/Trayectos/Form.aspx?id={((GridViewRow)btn.NamingContainer).Cells[0].Text}");
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