using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoLogic: BusinessLogic
    {
        private AlumnoAdapte AlumnoData;

        public AlumnoLogic()
        {
            AlumnoData = new AlumnoAdapte();
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return AlumnoData.GetOne(id);
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoData.GetAll();
        }

        public void Delete(int id)
        {
            AlumnoData.Delete(id);
        }

        public void Save(AlumnoInscripcion alumno)
        {
            AlumnoData.Save(alumno);
        }
    }
}
