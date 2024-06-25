using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Clases
{
    public class Conexion
    {
        //Cadena de Conexion -- > Instancia
        //public static string cadena_de_conexion = @"Server=" + App.SERVER + ";Database="+App.DATABASE+";Trusted_Connection=True;MultipleActiveResultSets=true";
       // public static string cadena = @"Server=" + App.SERVER + "; Trusted_Connection=True;MultipleActiveResultSets=true";
        public static string cadena_de_conexion = @"Server=" + App.SERVER + ";Database=" + App.DATABASE + ";User Id=" + App.USERID + ";Password=" + App.PASSWORD + ";";
        public static SqlConnection ConSql = new SqlConnection(cadena_de_conexion);

        //Metodo OpenConnection --> Abre la conexion a la base de datos
        public static void OpenConnection()
        {
            try
            {
                ConSql.Open();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        } //Fin Metodo

        //Metodo CloseConnection --> Cierra la conexion a la base de datos
        public static void CloseConnection()
        {
            try
            {
                ConSql.Close();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        } //Fin Metodo

        //Metodo EndsConnection --> Revisa que la conexion a SQL este cerrada
        public static void EndsConnection()
        {
            if (ConSql.State == ConnectionState.Open)
            {
                ConSql.Close();
            }
        } //Fin Metodo
    }
}
