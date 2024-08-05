using DataAccess.Context;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConductoresMetodos
    {
        private readonly DbConnection ctx = new DbConnection();
        public List<Conductores> GetAll()
        {
            try
            {
                return ctx.Conductores.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Conductores GetById(int id)
        {
            try
            {
                return ctx.Conductores.FirstOrDefault(c => c.IdConductor == id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Conductores Post(Conductores conductor)
        {
            try
            {
                string query = $"EXEC GuardarConductor '{conductor.Nombre}', '{conductor.Apellido}', '{conductor.Documento}', {conductor.NumeroCelular}";
                return ctx.Database.SqlQuery<Conductores>(query).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(Conductores conductor)
        {
            try
            {
                var encontrado = ctx.Conductores.FirstOrDefault(c => c.IdConductor == conductor.IdConductor);
                if (encontrado == null)
                    return false;
                encontrado.Nombre = conductor.Nombre;
                encontrado.Apellido = conductor.Apellido;
                encontrado.Documento = conductor.Documento;
                encontrado.NumeroCelular = conductor.NumeroCelular;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var encontrado = ctx.Conductores.FirstOrDefault(c => c.IdConductor == id);
                if (encontrado == null)
                    return false;
                ctx.Conductores.Remove(encontrado);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
