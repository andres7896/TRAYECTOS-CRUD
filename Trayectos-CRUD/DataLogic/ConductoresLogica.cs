using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class ConductoresLogica
    {
        private readonly ConductoresMetodos mt = new ConductoresMetodos();
        public List<Conductores> GetAll()
        {
            return mt.GetAll();
        }
        public Conductores GetById(int id)
        {
            return mt.GetById(id);
        }
        public Conductores Post(Conductores conductor)
        {
            return mt.Post(conductor);
        }
        public bool Put(Conductores conductor)
        {
            return mt.Put(conductor);
        }
        public bool Delete(int id)
        {
            return mt.Delete(id);
        }
    }
}
