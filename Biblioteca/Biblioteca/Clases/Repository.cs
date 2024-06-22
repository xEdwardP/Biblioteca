using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca.Clases
{
    public class Repository
    {
        Clases.Helpers h = new Clases.Helpers();
        public SqlCommand com;
        SqlDataReader reader;
        DataTable recordset;
        string query;

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
        //Actualiza registros existentes
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

        //Metodo Rocket utilizado para Agregar, Actualizar y Eliminar Registros de la Base de Datos
        public void Rocket(string Query, String Msg)
        {
            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                com.ExecuteNonQuery();

                MessageBox.Show(Msg, "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
        }
        //Fin Metodo Rocket

        //Metodo Bullet Utilizado cuando se afectan los registros de la base de datos
        //sin enviar notificacion al usuario.
        public void Bullet(string Query)
        {
            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                com.ExecuteNonQuery();

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
        }

        public void Burst(string Query)
        {
            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                com.ExecuteNonQuery();

                com.Dispose();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
        }
        //Metodo GetSumField, utilizado para traer la suma de un campo
        public string GetSumField(string Campo, string tabla, string Condicion)
        {
            string Sum = "";
            try
            {
                string Query = "SELECT SUM(" + Campo + ") AS Result FROM " + tabla + " " + Condicion;
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                SqlDataReader Recordset;
                Clases.Conexion.OpenConnection();
                Recordset = com.ExecuteReader();

                if (Recordset.Read())
                {
                    Sum = Recordset["Result"].ToString();
                }
                else
                {
                    MessageBox.Show("ERROR AL PROCESAR LOS DATOS!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                Recordset.Close();
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
            return Sum;

        }
        //fin metodo GetSumField

        public string CheckIfExists(string Tabla, string condition)
        {
            string Response = "N";
            try
            {
                query = "SELECT * FROM " + Tabla + " WHERE " + condition;

                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    Response = "S";
                }

                reader.Close();
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
            return Response;
        }

        //Verifica si un codigo ya existe
        public bool VerifyIfExists(string Tabla, string Pk, string Id)
        {
            bool Response = false;
            try
            {
                string Query = "SELECT * FROM " + Tabla + " WHERE " + Pk + "='" + Id + "'";

                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                SqlDataReader TableReader;
                Clases.Conexion.OpenConnection();
                TableReader = com.ExecuteReader();

                if (TableReader.Read())
                {
                    Response = true;
                }

                TableReader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return Response;
        }

        //Metodo Hook, utilizado para traer un solo campo de la base de datos
        public string Hook(string Campo, string Tabla, string Condicion = "")
        {
            string Fish = "";
            try
            {
                if (Condicion == "")
                {
                    query = "SELECT " + Campo + " AS FISH FROM " + Tabla + " ";
                }
                else
                {
                    query = "SELECT " + Campo + " AS FISH FROM " + Tabla + " WHERE " + Condicion;
                }

                com = new SqlCommand(query, Clases.Conexion.ConSql);
                SqlDataReader Recordset;
                Clases.Conexion.OpenConnection();
                Recordset = com.ExecuteReader();
                if (Recordset.Read())
                {
                    Fish = Recordset["FISH"].ToString();
                }

                Recordset.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                string[,] parameters = new string[1, 2];
                parameters[0, 0] = "@log"; parameters[0, 1] = query;
                ExecSPInsert("SP_LogHook", parameters);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return Fish;
        }
        //fin metodo hook

        //metodo Harpoon para traer la primera fila de una consulta
        public string Harpoon(string Campo, string Tabla, string Condicion)
        {
            string target = "";
            try
            {
                string Query;
                Query = "SELECT TOP 1 " + Campo + " AS TARGET FROM " + Tabla + " " + Condicion;
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                SqlDataReader Recordset;
                Clases.Conexion.OpenConnection();
                Recordset = com.ExecuteReader();

                if (Recordset.Read())
                {
                    target = Recordset["TARGET"].ToString();
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON DATOS QUE MOSTRAR!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Recordset.Close();
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
            return target;
        }
        //fin metodo harpoon

        //Metodo GetDataRequired, utilizado para traer Informacion de la base de datos
        public DataTable RawSelect(string Query, string debug = "")
        {
            DataTable RecordSet = new DataTable();

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                SqlDataReader DrRecordSet;
                Clases.Conexion.OpenConnection();

                DrRecordSet = com.ExecuteReader();
                RecordSet.Load(DrRecordSet);

                DrRecordSet.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return RecordSet;
        }
        //Fin Metodo DataRequired

        //Metodo GetNextId, utilizado para generar ids numericos
        public string GetNextId(string idmodule)
        {
            string id = "";
            string correlativo = "";
            string condition;

            condition = "WHERE IDCORRE = '" + idmodule + "'";

            correlativo = Hook("ULTIMO + 1", "CORRELATIVOS", condition);

            double response = h.ReturnsNumber(correlativo);
            if (response > 0 && response <= 9)
            {
                id = "0000000" + response.ToString();
            }
            else if (response >= 10 && response <= 99)
            {
                id = "000000" + response.ToString();
            }
            else if (response >= 100 && response <= 999)
            {
                id = "00000" + response.ToString();
            }
            else if (response >= 1000 && response <= 9999)
            {
                id = "0000" + response.ToString();
            }
            else if (response >= 10000 && response <= 99999)
            {
                id = "000" + response.ToString();
            }
            else if (response >= 100000 && response <= 999999)
            {
                id = "00" + response.ToString();
            }
            else if (response >= 1000000 && response <= 999999999)
            {
                id = "0" + response.ToString();
            }
            else
            {
                id = response.ToString();
            }

            return id;
        }
        //fin GetNextId

        //Metodo GetNext, Utilizado para Generar Correlativos
        public string GetNext(string Id)
        {
            string Next = "";
            string condition;
            condition = "WHERE IDCORRE ='" + Id + "'";


            string Query = "SELECT ULTIMO + 1 AS NEXT FROM CORRELATIVOS " + condition;
            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                SqlDataReader DrNext;
                DrNext = com.ExecuteReader();

                Int32 Corre = 0;
                if (DrNext.Read())
                {
                    Corre = Convert.ToInt32(DrNext["NEXT"].ToString());
                }
                else
                {
                    h.MsgWarning("ERROR AL GENERAR EL CORRELATIVO, CONTACTAR AL ADMINISTRADOR");
                }

                DrNext.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();

                if (Corre >= 1 && Corre <= 9)
                {
                    Next = "00000" + Corre.ToString();
                }
                else if (Corre >= 10 && Corre <= 99)
                {
                    Next = "0000" + Corre.ToString();
                }
                else if (Corre >= 100 && Corre <= 999)
                {
                    Next = "000" + Corre.ToString();
                }
                else if (Corre >= 1000 && Corre <= 9999)
                {
                    Next = "00" + Corre.ToString();
                }
                else if (Corre >= 10000 && Corre <= 99999)
                {
                    Next = "0" + Corre.ToString();
                }
                else if (Corre >= 100000 && Corre <= 999999)
                {
                    Next = Corre.ToString();
                }
                else
                {
                    h.MsgWarning("ERROR AL GENERAR EL CORRELATIVO, HA LLEGADO AL MÁXIMO!");
                }
            }
            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return Next;
        }
        //Fin Metodo GetNext

        //Metodo SetLast, Utilizado para Establecer el ultimo Correlativo Asignado
        public void SetLast(string Id)
        {
            string condition;
            condition = "WHERE IDCORRE='" + Id + "'";


            string Query = "Update Correlativos set Ultimo = Ultimo + 1 where IdCorre='" + Id + "'";

            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
        }
        //Fin Metodo SetLast;

        public void MakeBackUp(string msg = "")
        {
            try
            {
                com = new SqlCommand("MakeBackUp", Clases.Conexion.ConSql);
                com.CommandType = CommandType.StoredProcedure;
                Clases.Conexion.OpenConnection();
                com.ExecuteNonQuery();
                com.Dispose();
                Clases.Conexion.CloseConnection();

                if (msg != "")
                {
                    MessageBox.Show(msg, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
        }

        //Traditional QUERY
        //metodo donde se puede pasar una linea sql sin parametros
        public int T_query(string query)
        {
            int rd = 0;
            try
            {
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
        //fin metodo query tradicional

        //Metodo Delete
        //Marca como eliminado el registro seleccionado
        public int Delete2(string table, string condition = "")
        {
            int rd = 0;
            query = "UPDATE " + table + " SET DEL='S' WHERE " + condition;

            try
            {

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

        //public void TrashBin(string record, string table, string pk, string token)
        //{

        //    string fields = "REGISTRO, MODELO, REFERENC, TOKEN, USUARIO";
        //    string values = "'" + record + "','" + table + "','" + pk + "','" + token + "','" + Clases.User.user + "'";
        //    query = "INSERT INTO PAPELERA (" + fields + ") VALUES(" + values + ")";

        //    try
        //    {
        //        com = new SqlCommand(query, Clases.Conexion.ConSql);
        //        Clases.Conexion.OpenConnection();
        //        com.ExecuteNonQuery();

        //        com.Dispose();
        //        Clases.Conexion.CloseConnection();
        //    }
        //    catch (SqlException error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }
        //    {
        //        Clases.Conexion.EndsConnection();
        //    }

        //}

        public int RestoreItem(string table, string iditem, string Pk, string value)
        {
            int ra = 0;
            ra += Update(table, "DEL='N'", "" + Pk + "='" + value + "'");
            ra += Destroy("PAPELERA", "IDELEMENTO='" + iditem + "'");
            return ra;
        }

        public DataTable Find(string table, string fields, string condition = "", string orderby = "", string debug = "")
        {
            recordset = new DataTable();

            if (condition == "" && orderby == "")
            {
                query = "SELECT " + fields + " FROM " + table;
            }
            else if (condition != "" && orderby == "")
            {
                query = "SELECT " + fields + " FROM " + table + " WHERE " + condition;
            }
            else if (condition == "" && orderby != "")
            {
                query = "SELECT " + fields + " FROM " + table + " ORDER BY " + orderby;
            }
            else if (condition != "" && orderby != "")
            {
                query = "SELECT " + fields + " FROM " + table + " WHERE " + condition + " ORDER BY " + orderby;
            }

            if (debug == "True")
            {
                MessageBox.Show(query);
                Clipboard.SetText(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();
                recordset.Load(reader);

                reader.Close();
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
            return recordset;
        }

        //Metodo Find
        //Buscar registro en la base de datos
        public DataTable Find2(string table, string fields, string condition = "", string orderby = "", bool debug = false)
        {
            recordset = new DataTable();

            if (condition == "" && orderby == "")
            {
                query = "SELECT " + fields + " FROM " + table;
            }

            else if (condition != "" && orderby == "")
            {
                query = "SELECT " + fields + " FROM " + table + " WHERE " + condition;
            }

            else if (condition == "" && orderby != "")
            {
                query = "SELECT " + fields + " FROM " + table + " ORDER BY " + orderby;
            }

            else if (condition != "" && orderby != "")
            {
                query = "SELECT " + fields + " FROM " + table + " WHERE " + condition + " ORDER BY " + orderby;
            }

            if (debug == true)
            {
                h.MsgWarning(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();
                recordset.Load(reader);

                recordset.Dispose();
                reader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }

            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }

            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return recordset;
        }
        //Fin metodo Find

        //Metodo JoinTables
        //Combinar los datos de más tablas
        //fin JoinTables
        public DataTable JoinTables(string data, string condition = "", string orderby = "", string debug = "")
        {
            recordset = new DataTable();
            if (condition == "" && orderby == "")
            {
                query = "SELECT " + data;
            }
            else if (condition != "" && orderby == "")
            {
                query = "SELECT " + data + " WHERE " + condition;
            }
            else if (condition != "" && orderby != "")
            {
                query = "SELECT " + data + " WHERE " + condition + " ORDER BY " + orderby;
            }
            else if (condition == "" && orderby != "")
            {
                query = "SELECT " + data + " ORDER BY " + orderby;
            }

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();
                recordset.Load(reader);

                reader.Close();
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
            return recordset;
        }
        //Fin JoinTables

        //Metodo GetNumRows
        //Determina el numero de filas que cumplen una condicion
        public Int16 GetNumRows(string tablename, string condition = "")
        {
            Int16 NumRows = 0;
            if (condition == "")
            {
                query = "SELECT COUNT(*) AS NUMROWS FROM " + tablename;
            }
            else
            {
                query = "SELECT COUNT(*) AS NUMROWS FROM " + tablename + " WHERE " + condition;
            }
            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    NumRows = Convert.ToInt16(reader["NUMROWS"].ToString());
                }
                else
                {
                    MessageBox.Show("ERROR FATAL AL PROCESAR EL COMANDO ESPECIFICADO");
                }
                reader.Close();
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
            return NumRows;
        }
        //Fin GetNumRows

        public int ExecSPInsert(string SPName, string[,] Params)
        {
            int rowsinserted = 0;
            try
            {
                com = new SqlCommand(SPName, Clases.Conexion.ConSql);
                com.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < Params.GetLength(0); i++)
                {
                    string paramname, value;
                    paramname = Params[i, 0];
                    value = Params[i, 1];
                    com.Parameters.AddWithValue(paramname, value);
                }
                Clases.Conexion.OpenConnection();
                rowsinserted = com.ExecuteNonQuery();

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
            return rowsinserted;
        }

        public int Savei(string tablename, string[,] data, bool debug = false)
        {
            int i;
            string campos = "", valores = "";
            for (i = 0; i < data.GetLength(0); i++)
            {
                int size = data.GetLength(0);
                if (i < size)
                {
                    campos = campos + data[i, 0] + ", ";
                    valores = valores + "'" + data[i, 1] + "', ";
                }
                else
                {
                    campos = campos + data[i, 0];
                    valores = valores + "'" + data[i, 1] + "'";
                }
            }
            query = "INSERT INTO " + tablename + "(" + campos + ") VALUES (" + valores + ")";

            if (debug == true)
            {
                h.MsgInfo(query);
            }
            return i;
        }

        //public void Print(ReportDocument reporte)
        //{
        //    try
        //    {
        //        ConnectionInfo Con = new ConnectionInfo();
        //        Tables _tables = reporte.Database.Tables;

        //        Con.ServerName = Clases.Env.SERVER;
        //        Con.DatabaseName = Clases.Env.DATABASE;
        //        Con.UserID = Clases.Env.USER;
        //        Con.Password = Clases.Env.PASSWORD;

        //        foreach (CrystalDecisions.CrystalReports.Engine.Table _table in _tables)
        //        {
        //            TableLogOnInfo loginfo = _table.LogOnInfo;
        //            loginfo.ConnectionInfo = Con;
        //            _table.ApplyLogOnInfo(loginfo);
        //        }
        //    }
        //    catch (CrystalReportsException error)
        //    {
        //        MessageBox.Show(error.Message);
        //    }
        //}

        //Registrar Correlativos de Establecimiento
        public int SetCorrelativosEstablecimiento(string idcorre, string idest, string detalle)
        {
            int ri = 0;
            string fields, values;
            fields = "IDCORRE, IDEST, DETALLE";
            values = "'" + idcorre + "','" + idest + "', '" + detalle + "'";

            ri = Save("CORRELATIVOS", fields, values);

            return ri;
        }
        //Fin Correlativos de establecimiento

        //Metodo GetLastId
        public Int32 GetLastId(string Table)
        {
            int LastId = 0;
            try
            {
                string Query = "SELECT IDENT_CURRENT('" + Table + "') AS LastId";
                SqlCommand Com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                LastId = Convert.ToInt32(Com.ExecuteScalar());

                Com.Dispose();
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
            return LastId;
        }
        //Fin Metodo GetLastId

        public string ValidateBill(string Id, string IdEst)
        {
            Int32 Correlativo = 0, Ultimo = 0;
            string Controller = "";

            Correlativo = Convert.ToInt32(Hook("ULTIMO", "CORRELATIVOS", "IDCORRE='" + Id + "' AND IDEST='" + IdEst + "'"));
            Ultimo = Convert.ToInt32(Hook("NUMFINAL", "CAIS", "IDEST='" + IdEst + "' AND ESTADO='ACTIVO'"));

            //Verifico si quedan menos de 100 facturas;
            int Restan = Ultimo - Correlativo;
            if (Restan <= 100)
            {
                string msg = "ESTÁ LLEGANDO AL FINAL DE SU LIMITE DE FACTURACIÓN, TIENE " + Restan.ToString() + " FACTURAS DISPONIBLES, CONTACTAR AL ADMINISTRADOR!";
                MessageBox.Show(msg, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //fin verificacion

            if (Correlativo < Ultimo)
            {
                Controller = "E";
            }
            else
            {
                Controller = "D";
            }

            return Controller;
        }
        //Fin Metodo ValidateBill

        //Metodo Count
        //Determina el numero de filas que cumplen una condicion
        public Int32 Count(string tablename, string condition = "", bool debug = false)
        {
            Int32 NumRows = 0;

            if (condition == "")
            {
                query = "SELECT COUNT(*) AS NUMROWS FROM " + tablename;
            }

            else
            {
                query = "SELECT COUNT(*) AS NUMROWS FROM " + tablename + " WHERE " + condition;
            }

            if (debug == true)
            {
                h.MsgSuccess(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    NumRows = Convert.ToInt16(reader["NUMROWS"].ToString());
                }

                else
                {
                    h.MsgWarning("ERROR AL PROCESAR EL COMANDO ESPECIFICADO");
                }

                reader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }

            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }

            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return NumRows;
        }
        //Fin metodo Count

        //Ejecuta una consulta sql cruda
        public Int32 RawSQL(string Query, bool debug = false)
        {
            Int32 ra = 0;

            if (debug == true)
            {
                h.MsgSuccess(Query);
            }

            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }

            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }

            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return ra;
        }
        //Fin RawSQL
    }
}