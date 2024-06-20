using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca.Clases
{
    public class Repository
    {
        private Clases.Helpers h = new Clases.Helpers();
        public SqlCommand com;
        private SqlDataReader reader;
        private DataTable recordset;
        private string query;

        //Metodo Save
        //inserta registros en la base de datos
        public int Save(string table, string fields, string values, string debug = "")
        {
            int ra = 0; //rowsaffected
            query = "INSERT INTO " + table + "(" + fields + ") VALUES(" + values + ")";

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return ra;
        }
        //fin Metodo Save

        //Metodo Update
        //Actualizar los registros de la base de datos
        public int Update(string table, string values, string condition = "", string debug = "")
        {
            int ra = 0; //rowsaffected
            if (condition == "")
            {
                query = "UPDATE " + table + " SET " + values;
            }
            else
            {
                query = "UPDATE " + table + " SET " + values + " WHERE " + condition;
            }

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return ra;
        }
        //Fin Metodo Update

        //Metodo Destroy
        //Elimina registros de la base de datos
        public int Destroy(string table, string condition = "")
        {
            int ra = 0;
            if (condition == "")
            {
                query = "DELETE FROM " + table;
            }
            else
            {
                query = "DELETE FROM " + table + " WHERE " + condition;
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return ra;
        }
        //Fin Metodo Destroy

        //Metodo Delete
        //Marca como eliminado el registro seleccionado
        public int Delete(string table, string pk, string value)
        {
            int rd = 0;
            try
            {
                query = "UPDATE " + table + " SET DEL='S' WHERE " + pk + "='" + value + "'";
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                rd = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return rd;
        }
        //Fin Delete
    }
}