using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class AlumnoAdapter: Adapter
    {
        private static List<AlumnoInscripcion> _Alumnos;

        private static List<AlumnoInscripcion> Alumnos
        {
            get
            {
                if (_Alumnos == null)
                {
                    _Alumnos = new List<Business.Entities.AlumnoInscripcion>();
                    Business.Entities.AlumnoInscripcion alum;
                    alum = new Business.Entities.AlumnoInscripcion();
                    alum.ID = 1;
                    alum.State = Business.Entities.BusinessEntity.States.Unmodified;
                    alum.Condicion = "Aprobado";
                    alum.IDAlumno = 5;
                    alum.IDCurso = 10;
                    alum.Nota = 8;
                    _Alumnos.Add(alum);
                }
                return _Alumnos;
            }
        }
        //#endregion

        public List<AlumnoInscripcion> GetAll()
        {
            return new List<AlumnoInscripcion>(Alumnos);
        }

        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            return Alumnos.Find(delegate (AlumnoInscripcion a) { return a.ID == ID; });
        }

        public void Delete(int ID)
        {
            Alumnos.Remove(this.GetOne(ID));
        }

        public void Save(AlumnoInscripcion alumno)
        {
            if (alumno.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (AlumnoInscripcion alum in Alumnos)
                {
                    if (alum.ID > NextID)
                    {
                        NextID = alum.ID;
                    }
                }
                alumno.ID = NextID + 1;
                Alumnos.Add(alumno);
            }
            else if (alumno.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alumno.ID);
            }
            else if (alumno.State == BusinessEntity.States.Modified)
            {
                Alumnos[Alumnos.FindIndex(delegate (AlumnoInscripcion a) { return a.ID == alumno.ID; })] = alumno;
            }
            alumno.State = BusinessEntity.States.Unmodified;
        }
    }
}

