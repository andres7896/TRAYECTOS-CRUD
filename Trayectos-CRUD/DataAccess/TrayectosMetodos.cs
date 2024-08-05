using DataAccess.Context;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TrayectosMetodos
    {
        private readonly DbConnection ctx = new DbConnection();
        public List<VIEW_TRAYECTOS> GetByFilters(int year)
        {
            try
            {
                string query = $"SELECT * FROM VIEW_TRAYECTOS WHERE Modelo > 2014 AND ValorReal < 350000 AND ValorCobrado BETWEEN 350000 AND 550000";
                return ctx.Database.SqlQuery<VIEW_TRAYECTOS>(query).ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public Trayectos GetById(int id)
        {
            try
            {
                return ctx.Trayectos.FirstOrDefault(t => t.IdTrayecto == id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Post(Trayectos trayecto)
        {
            try
            {
                ctx.Trayectos.Add(trayecto);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Put(Trayectos trayecto)
        {
            try
            {
                var encontrado = ctx.Trayectos.FirstOrDefault(t => t.IdTrayecto == trayecto.IdTrayecto);
                if (encontrado == null)
                    return false;
                encontrado.CiudadOrigen = trayecto.CiudadOrigen;
                encontrado.CiudadDestino = trayecto.CiudadDestino;
                encontrado.IdConductor = trayecto.IdConductor;
                encontrado.IdVehiculo = trayecto.IdVehiculo;
                encontrado.ValorReal = trayecto.ValorReal;
                encontrado.ValorCobrado = trayecto.ValorCobrado;
                encontrado.Fecha = trayecto.Fecha;
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
                var encontrado = ctx.Trayectos.FirstOrDefault(c => c.IdTrayecto == id);
                if (encontrado == null)
                    return false;
                ctx.Trayectos.Remove(encontrado);
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
