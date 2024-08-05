using DataEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class DbConnection: DbContext
    {
        public DbConnection(): base("name=DbConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public virtual DbSet<Conductores> Conductores { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<Trayectos> Trayectos { get; set; }
    }
}
