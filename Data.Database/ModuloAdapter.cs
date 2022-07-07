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
    public class ModuloAdapter : Adapter
    {
        public List<Modulo> GetAll()
        {
            try
            {
                List<Modulo> listaModulo = new List<Modulo>();

                this.OpenConnection();
                SqlCommand cmdGetAll = new SqlCommand("SELECT * From modulos", sqlConn);
                SqlDataReader drModulo = cmdGetAll.ExecuteReader();

                while (drModulo.Read())
                {
                    Modulo moduloActual = new Modulo();
                    moduloActual.ID = (int)drModulo["id_modulo"];
                    moduloActual.Descripcion = (string)drModulo["desc_modulo"];
                    listaModulo.Add(moduloActual);
                }
                drModulo.Close();

                return listaModulo;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar Modulo.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Business.Entities.Modulo GetOne(int ID)
        {
            try
            {
                Modulo moduloActual = new Modulo();

                this.OpenConnection();
                SqlCommand cmdGetOne = new SqlCommand("SELECT * from modulos WHERE id_modulo = @id", sqlConn);
                cmdGetOne.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drModulo = cmdGetOne.ExecuteReader();

                if (drModulo.Read())
                {
                    moduloActual.ID = (int)drModulo["id_modulo"];
                    moduloActual.Descripcion = (string)drModulo["desc_modulo"];
                }
                drModulo.Close();

                return moduloActual;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar el modulo.", ex);
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

                SqlCommand cmdDelete = new SqlCommand("DELETE modulos from modulos WHERE id_modulo=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el modulo.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Modulo moduloActual)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("Update modulos set desc_modulo=@descripcion Where id_modulo=@id", sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = moduloActual.ID;
                cmdUpdate.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = moduloActual.Descripcion;

                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el modulo.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Modulo moduloActual)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdInsert = new SqlCommand("Insert into modulos(desc_modulo)" +
                        "values(@descripcion)" + "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = moduloActual.Descripcion;

                moduloActual.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar modulo.", ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Modulo modulo)
        {
            switch (modulo.State)
            {
                case BusinessEntity.States.New: this.Insert(modulo); break;
                case BusinessEntity.States.Deleted: this.Delete(modulo.ID); break;
                case BusinessEntity.States.Modified: this.Update(modulo); break;
                case BusinessEntity.States.Unmodified: break;
            }
        }
    }
}
