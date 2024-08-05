using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trayectos_CRUD.Pages.Conductores
{
    public partial class Form : System.Web.UI.Page
    {
        private readonly ConductoresLogica lg = new ConductoresLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Request.QueryString["id"];
                if (id != null)
                {
                    btnUpdate.Visible = true;
                    GetById(int.Parse(id));
                }
                else
                {
                    btnCreate.Visible = true;
                }
            }
        }
        protected void GetById(int id)
        {
            var conductor = lg.GetById(id);
            if (conductor == null)
            {
                Response.Redirect("~/Pages/Conductores/Index.aspx");
            }
            inputNombre.Text = conductor.Nombre;
            inputApellido.Text = conductor.Apellido;
            inputDocumento.Text = conductor.Documento.ToString();
            inputCelular.Text = conductor.NumeroCelular.ToString();
        }
        protected void Post(object sender, EventArgs e)
        {
            DataEntity.Conductores conductor = new DataEntity.Conductores();
            conductor.Nombre = inputNombre.Text;
            conductor.Apellido = inputApellido.Text;
            conductor.Documento = int.Parse(inputDocumento.Text);
            conductor.NumeroCelular = long.Parse(inputCelular.Text);
            var creado = lg.Post(conductor);
            if (creado == null)
                Response.Redirect("~/Pages/Index.aspx");
            Response.Redirect("~/Pages/Conductores/Index.aspx");
        }
        protected void Put(object sender, EventArgs e)
        {
            DataEntity.Conductores conductor = new DataEntity.Conductores();
            conductor.IdConductor = int.Parse(Request.QueryString["id"]);
            conductor.Nombre = inputNombre.Text;
            conductor.Apellido = inputApellido.Text;
            conductor.Documento = int.Parse(inputDocumento.Text);
            conductor.NumeroCelular = int.Parse(inputCelular.Text);
            var editado = lg.Put(conductor);
            if (editado == null)
                Response.Redirect("~/Pages/Index.aspx");
            Response.Redirect("~/Pages/Conductores/Index.aspx");
        }
        protected void Volver(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Conductores/Index.aspx");
        }
    }
}