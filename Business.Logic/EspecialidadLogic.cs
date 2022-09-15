using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter EspecialidadData;

        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }

        public Especialidad GetOne(int id)
        {
            return EspecialidadData.GetOne(id);
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }

        public void Save(Especialidad usuario)
        {
            EspecialidadData.Save(usuario);
        }
    }
}
