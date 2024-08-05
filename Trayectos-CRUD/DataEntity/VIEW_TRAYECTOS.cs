using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class VIEW_TRAYECTOS
    {
        [Key]
        public int IdTrayecto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Placa { get; set; }
        public int ValorReal { get; set; }
        public int ValorCobrado { get; set; }
        public DateTime Fecha { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
    }
}
