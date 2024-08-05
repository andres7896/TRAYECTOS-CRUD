using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class Trayectos
    {
        [Key]
        public int IdTrayecto { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        [ForeignKey("Conductor")]
        public int IdConductor { get; set; }
        public virtual Conductores Conductor { get; set; }
        [ForeignKey("Vehiculo")]
        public int IdVehiculo { get; set; }
        public virtual Vehiculos Vehiculo { get; set; }
        public int ValorReal { get; set; }
        public int ValorCobrado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
