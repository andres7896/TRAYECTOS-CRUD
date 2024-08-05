using DataAccess.Context;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class VehiculosMetodos
    {
        private readonly DbConnection ctx = new DbConnection();
        public List<Vehiculos> GetAll()
        {
            try
            {
                return ctx.Vehiculos.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Vehiculos GetById(int id)
        {
            try
            {
                return ctx.Vehiculos.FirstOrDefault(v => v.IdVehiculo == id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Post(Vehiculos vehiculo)
        {
            try
            {
                ctx.Vehiculos.Add(vehiculo);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Put(Vehiculos vehiculo)
        {
            try
            {
                var encontrado = ctx.Vehiculos.FirstOrDefault(v => v.IdVehiculo == vehiculo.IdVehiculo);
                if (encontrado == null)
                    return false;
                encontrado.Placa = vehiculo.Placa;
                encontrado.Marca = vehiculo.Marca;
                encontrado.Modelo = vehiculo.Modelo;
                ctx.Entry(encontrado).State = System.Data.Entity.EntityState.Modified;
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
                var encontrado = ctx.Vehiculos.FirstOrDefault(v => v.IdVehiculo == id);
                if (encontrado == null)
                    return false;
                ctx.Vehiculos.Remove(encontrado);
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
