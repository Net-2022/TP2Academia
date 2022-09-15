using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            try
            {
                List<Especialidad> listaEspecialidades = new List<Especialidad>();

                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("SELECT * From especialidades", sqlConn);
                SqlDataReader drEspecialidades = cmdGetAll.ExecuteReader();

                while (drEspecialidades.Read())
                {
                    Especialidad especialidadActual = new Especialidad();
                    especialidadActual.ID = (int)drEspecialidades["id_especialidad"];
                    especialidadActual.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    listaEspecialidades.Add(especialidadActual);
                }
                drEspecialidades.Close();

                return listaEspecialidades;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar Especialidades.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            try
            {
                Especialidad especialidadActual = new Especialidad();

                this.OpenConnection();
                SqlCommand cmdGetOne = new SqlCommand("SELECT * from especialidades WHERE id_especialidad = @id", sqlConn);
                cmdGetOne.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drEspecialidades = cmdGetOne.ExecuteReader();

                if (drEspecialidades.Read())
                {
                    especialidadActual.ID = (int)drEspecialidades["id_especialidad"];
                    especialidadActual.Descripcion = (string)drEspecialidades["desc_especialidad"];
                }
                drEspecialidades.Close();

                return especialidadActual;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar la especialidad.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("DELETE especialidades from especialidades WHERE id_especialidad=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la especialidad.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Especialidad especialidadActual)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("Update especialidades set desc_especialidad=@descripcion Where id_especialidad=@id", sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = especialidadActual.ID;
                cmdUpdate.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = especialidadActual.Descripcion;

                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la especialidad.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Especialidad especialidadActual)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdInsert = new SqlCommand("Insert into especialidades(desc_especialidad)" +
                        "values(@descripcion)" + "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = especialidadActual.Descripcion;

                especialidadActual.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar especialidad.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            switch (especialidad.State)
            {
                case BusinessEntity.States.New: this.Insert(especialidad); break;
                case BusinessEntity.States.Deleted: this.Delete(especialidad.ID); break;
                case BusinessEntity.States.Modified: this.Update(especialidad); break;
                case BusinessEntity.States.Unmodified: break;
            }
        }
    }
}
