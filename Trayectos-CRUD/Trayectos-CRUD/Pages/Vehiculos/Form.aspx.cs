using DataEntity;
using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trayectos_CRUD.Pages.Vehiculos
{
    public partial class Form : System.Web.UI.Page
    {
        private readonly VehiculosLogica lg = new VehiculosLogica();
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
            var vehiculo = lg.GetById(id);
            if (vehiculo == null)
            {
                Response.Redirect("~/Pages/Vehiculos/Index.aspx");
            }
            inputPlaca.Text = vehiculo.Placa;
            inputMarca.Text = vehiculo.Marca;
            inputModelo.Text = vehiculo.Modelo.ToString();
        }
        protected void Post(object sender, EventArgs e)
        {
            DataEntity.Vehiculos vehiculo = new DataEntity.Vehiculos();
            vehiculo.Placa = inputPlaca.Text;
            vehiculo.Marca = inputMarca.Text;
            vehiculo.Modelo = int.Parse(inputModelo.Text);
            var creado = lg.Post(vehiculo);
            if (creado == null)
                Response.Redirect("~/Pages/Index.aspx");
            Response.Redirect("~/Pages/Vehiculos/Index.aspx");
        }
        protected void Put(object sender, EventArgs e)
        {
            DataEntity.Vehiculos vehiculo = new DataEntity.Vehiculos();
            vehiculo.IdVehiculo = int.Parse(Request.QueryString["id"]);
            vehiculo.Placa = inputPlaca.Text;
            vehiculo.Marca = inputMarca.Text;
            vehiculo.Modelo = int.Parse(inputModelo.Text);
            var editado = lg.Put(vehiculo);
            if (editado == null)
                Response.Redirect("~/Pages/Index.aspx");
            Response.Redirect("~/Pages/Vehiculos/Index.aspx");
        }
        protected void Volver(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Vehiculos/Index.aspx");
        }
    }
}