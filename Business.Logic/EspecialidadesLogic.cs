using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadesLogic:BusinessLogic
    {
        private EspecialidadesAdapter EspecialidadData;

        public EspecialidadesLogic()
        {
            EspecialidadData = new EspecialidadesAdapter();
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
