using DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trayectos_CRUD.Pages.Trayectos
{
    public partial class Form : System.Web.UI.Page
    {
        private readonly TrayectosLogica lg = new TrayectosLogica();
        private readonly VehiculosLogica lgv = new VehiculosLogica();
        private readonly ConductoresLogica lgc = new ConductoresLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var vehiculos = lgv.GetAll();
                var conductores = lgc.GetAll();
                var id = Request.QueryString["id"];

                selectVehiculo.Items.Clear();
                selectVehiculo.DataValueField = "idVehiculo";
                selectVehiculo.DataTextField = "Placa";
                selectVehiculo.DataSource = vehiculos;
                selectVehiculo.DataBind();
                selectVehiculo.Items.Insert(0, new ListItem("-- SELECCIONE UNA OPCIÓN --", "-1"));

                selectConductor.Items.Clear();
                selectConductor.DataValueField = "idConductor";
                selectConductor.DataTextField = "Nombre";
                selectConductor.DataSource = conductores;
                selectConductor.DataBind();
                selectConductor.Items.Insert(0, new ListItem("-- SELECCIONE UNA OPCIÓN --", "-1"));

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
            var trayecto = lg.GetById(id);
            if (trayecto == null)
            {
                Response.Redirect("~/Pages/Trayectos/Index.aspx");
            }
            inputOrigen.Text = trayecto.CiudadOrigen;
            inputDestino.Text = trayecto.CiudadDestino;
            selectConductor.SelectedValue = trayecto.IdConductor.ToString();
            selectVehiculo.SelectedValue = trayecto.IdVehiculo.ToString();
            inputValorReal.Text = trayecto.ValorReal.ToString();
            inputValorCobrado.Text = trayecto.ValorCobrado.ToString();
            inputFecha.Text = trayecto.Fecha.ToString();
        }
        protected void Post(object sender, EventArgs e)
        {
            DataEntity.Trayectos trayecto = new DataEntity.Trayectos();
            trayecto.CiudadOrigen = inputOrigen.Text;
            trayecto.CiudadDestino = inputDestino.Text;
            trayecto.IdConductor = int.Parse(selectConductor.SelectedValue);
            trayecto.IdVehiculo = int.Parse(selectVehiculo.SelectedValue);
            trayecto.ValorReal = int.Parse(inputValorReal.Text);
            trayecto.ValorCobrado = int.Parse(inputValorCobrado.Text);
            trayecto.Fecha = DateTime.Parse(inputFecha.Text);
            var creado = lg.Post(trayecto);
            if (creado == null)
                Response.Redirect("~/Pages/Index.aspx");
            Response.Redirect("~/Pages/Trayectos/Index.aspx");
        }
        protected void Put(object sender, EventArgs e)
        {
            DataEntity.Trayectos trayecto = new DataEntity.Trayectos();
            trayecto.IdTrayecto = int.Parse(Request.QueryString["id"]);
            trayecto.CiudadOrigen = inputOrigen.Text;
            trayecto.CiudadDestino = inputOrigen.Text;
            trayecto.IdConductor = int.Parse(selectConductor.SelectedValue);
            trayecto.IdVehiculo = int.Parse(selectVehiculo.SelectedValue);
            trayecto.ValorReal = int.Parse(inputValorReal.Text);
            trayecto.ValorCobrado = int.Parse(inputValorReal.Text);
            trayecto.Fecha = DateTime.Parse(inputFecha.Text);
            var editado = lg.Put(trayecto);
            if (editado == null)
                Response.Redirect("~/Pages/Index.aspx");
            Response.Redirect("~/Pages/Trayectos/Index.aspx");
        }
        protected void Volver(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Trayectos/Index.aspx");
        }
    }
}