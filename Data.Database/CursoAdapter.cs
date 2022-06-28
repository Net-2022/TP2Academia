using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class CursoAdapter: Adapter
    {

        private static List<Curso> _Cursos;

        private static List<Curso> Cursos
        {
            get {
                if (_Cursos == null)
                {
                    _Cursos = new List<Business.Entities.Curso>();
                    Business.Entities.Curso cur;
                    cur = new Business.Entities.Curso();
                    cur.ID = 1;
                    cur.State = Business.Entities.BusinessEntity.States.Unmodified;
                    cur.AnioCalendario = 2022;
                    cur.Cupo = 20;
                    cur.Descripcion = "Tecnologia de Desarrollos de Software .NET";
                    cur.IDComision = 5;
                    cur.IDMateria = 3;
                    _Cursos.Add(cur);

                    cur = new Business.Entities.Curso();
                    cur.ID = 2;
                    cur.State = Business.Entities.BusinessEntity.States.Unmodified;
                    cur.AnioCalendario = 2022;
                    cur.Cupo = 22;
                    cur.Descripcion = "Paradigma";
                    cur.IDComision = 4;
                    cur.IDMateria = 2;
                    _Cursos.Add(cur);

                }
                return _Cursos;
            }
        }

        public List<Curso> GetAll()
        {
            return new List<Curso>(Cursos);
        }

        public Business.Entities.Curso GetOne(int ID)
        {
            return Cursos.Find(delegate (Curso c) { return c.ID == ID; });
        }

        public void Delete(int ID)
        {
            Cursos.Remove(this.GetOne(ID));
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Curso cur in Cursos)
                {
                    if (cur.ID > NextID)
                    {
                        NextID = cur.ID;
                    }
                }
                curso.ID = NextID + 1;
                Cursos.Add(curso);
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                Cursos[Cursos.FindIndex(delegate (Curso cur) { return cur.ID == curso.ID; })] = curso;
            }
            curso.State = BusinessEntity.States.Unmodified;
        }

    }
}
