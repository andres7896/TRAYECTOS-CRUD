using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class VehiculosLogica
    {
        private readonly VehiculosMetodos mt = new VehiculosMetodos();
        public List<Vehiculos> GetAll()
        {
            return mt.GetAll();
        }
        public Vehiculos GetById(int id)
        {
            return mt.GetById(id);
        }
        public bool Post(Vehiculos conductor)
        {
            return mt.Post(conductor);
        }
        public bool Put(Vehiculos conductor)
        {
            return mt.Put(conductor);
        }
        public bool Delete(int id)
        {
            return mt.Delete(id);
        }
    }
}
