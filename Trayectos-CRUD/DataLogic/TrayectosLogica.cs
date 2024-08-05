using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class TrayectosLogica
    {
        private readonly TrayectosMetodos mt = new TrayectosMetodos();
        public List<VIEW_TRAYECTOS> GetByFilters()
        {
            return mt.GetByFilters(DateTime.Now.Year);
        }
        public Trayectos GetById(int id)
        {
            return mt.GetById(id);
        }
        public bool Post(Trayectos conductor)
        {
            return mt.Post(conductor);
        }
        public bool Put(Trayectos conductor)
        {
            return mt.Put(conductor);
        }
        public bool Delete(int id)
        {
            return mt.Delete(id);
        }
    }
}
