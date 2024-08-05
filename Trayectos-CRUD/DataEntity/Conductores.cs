using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class Conductores
    {
        [Key]
        public int IdConductor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Documento { get; set; }
        public long NumeroCelular { get; set; }
    }
}
