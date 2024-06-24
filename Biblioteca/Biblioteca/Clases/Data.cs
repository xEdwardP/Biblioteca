using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Clases
{
    public class Data
    {
        //Clases.Helpers Helpers { get; set; }
        Clases.Helpers h = new Clases.Helpers();

        static bool DatabaseExists(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // La conexión se abrió correctamente, lo que significa que la base de datos existe
                    return true;
                }
            }
            catch (Exception)
            {
                // Ocurrió un error al abrir la conexión, lo que indica que la base de datos no existe o no se puede acceder
                return false;
            }
        }


        public void CheckFileConfiguration()
        {
            var resp = DatabaseExists(Clases.Conexion.cadena_de_conexion);
            
            if(resp == true)
            {
                string path = @"C:\Data\Seeder.sql";

                if (File.Exists(path))
                {
                    try
                    {
                        string sqlScript = File.ReadAllText(path);
                        ExecuteSqlScript(sqlScript);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading SQL script: {ex.Message}");
                    }
                }
                else
                {
                    h.MsgError("ERROR FATAL, NO SE CARGARON LOS ARCHIVOS DE CONFIGURACION DEL SISTEMA, CONTACTAR AL ADMINISTRADOR!");
                    Application.Exit();
                }
            }
            else
            {
                h.MsgError("Error Fatal: La base de datos no existe o no se puede acceder");
            }
        }

        private void ExecuteSqlScript(string sqlScript)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Clases.Conexion.cadena_de_conexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlScript, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing SQL script: {ex.Message}");
            }
        }


        // OTRO

        //public void SelectDatabaseFile()
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = "Archivos SQL (*.sql)|*.sql|Todos los archivos (*.*)|*.*";
        //        openFileDialog.Title = "Selecciona el archivo de base de datos";

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            string selectedFilePath = openFileDialog.FileName;
        //            // Aquí puedes usar 'selectedFilePath' para cargar la información o realizar otras operaciones.
        //            ReadConfiguration(selectedFilePath);
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se seleccionó ningún archivo. La aplicación se cerrará.");
        //            Application.Exit();
        //        }
        //    }
        //}

        //private void ReadConfiguration(string filePath)
        //{
        //    try
        //    {
        //        string sqlScript = File.ReadAllText(filePath);
        //        ExecuteSqlScript(sqlScript); // Implementa este método
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al leer el script SQL: {ex.Message}");
        //    }
        //}

        //private void ExecuteSqlScript(string sqlScript)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection("tu_cadena_de_conexión_a_la_base_de_datos"))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(sqlScript, connection))
        //            {
        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al ejecutar el script SQL: {ex.Message}");
        //    }
        //}
    }
}
