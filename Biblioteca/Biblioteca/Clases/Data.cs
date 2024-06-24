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
        Clases.Helpers Helpers { get; set; }

        //Metodo CheckFileConfiguration --> Verifica la existencia del archivo de base de datos
        //public void CheckFileConfiguration()
        //{
        //    string path = @"C:\Data\Database.sql";

        //    if (File.Exists(path))
        //    {
        //        //Cargar informacion
        //        ReadConfiguration();
        //    }
        //    else
        //    {
        //        //Error
        //        Helpers.MsgWarning("ERROR FATAL, NO SE CARGARON LOS ARCHIVOS DE CONFIGURACION DEL SISTEMA, CONTACTAR AL ADMINISTRADOR!");
        //        Application.Exit();
        //    }
        //}
        //Fin CheckFileConfiguration

        //Metodo ReadConfiguration --> Lee y ejecuta el archivo que contiene la creacion de la base de datos
        //private void ReadConfiguration()
        //{
        //    try
        //    {
        //        //SqlCommand sqlCommand = new SqlCommand(Path, Clases.Conexion.ConSql); 
        //        Clases.Conexion.CloseConnection();
        //    }

        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }

        //    finally
        //    {
        //        Clases.Conexion.EndsConnection();
        //    }
        //}
        //Fin ReadConfiguration

        //public bool DatabaseExists(string connectionString)
        //{
        //    using (var context = new DbContext(connectionString))
        //    {
        //        return context.Database.Exists();
        //    }
        //}


        public void CheckFileConfiguration()
        {
            string path = @"C:\Data\Database.sql";

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
                Helpers.MsgError("ERROR FATAL, NO SE CARGARON LOS ARCHIVOS DE CONFIGURACION DEL SISTEMA, CONTACTAR AL ADMINISTRADOR!");
                Application.Exit();
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
