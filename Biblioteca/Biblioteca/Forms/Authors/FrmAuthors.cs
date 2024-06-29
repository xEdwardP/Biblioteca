using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca.Forms.Authors
{
    public partial class FrmAuthors : Form
    {
        // Instancias
        private Clases.Helpers helpers = new Clases.Helpers();

        private Clases.Repository repository = new Clases.Repository();

        // Variables
        private string author, country, code;

        private int errors = 0;

        string idmodule = "AUT";

        public FrmAuthors()
        {
            InitializeComponent();
        }

        private void FrmAuthors_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Autores | ";
            StartForm();
            GetCountries();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StateButtons(false, true, false, false, true, false, false);

            TxtAuthor.Enabled = true;
            TxtSearch.Enabled = false;
            CmbCountry.Enabled = true;
            AutoGenCode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateInfo();
            if(errors == 0)
            {
                SetValues();
                string fields = "IDAUTOR, AUTOR, IDPAIS";
                string values = "'" + code + "', '" + author + "', '" + country + "'";

                if (repository.Save("AUTORES", fields, values) > 0)
                {
                    helpers.MsgSuccess(Clases.Messages.MsgSave);
                    repository.SetLast(idmodule);
                    Clean();
                    StartForm();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ValidateInfo();

            if(errors == 0)
            {
                SetValues();

                if(helpers.MsgQuestion(Clases.Messages.MsgUpdate) == "S")
                {
                    //string id = code;
                    string values = "AUTOR='" + author + "', IDPAIS='" + country + "'";
                    string condition = "IDAUTOR='" + code + "'";

                    if(repository.Update("AUTORES", values, condition) > 0)
                    {
                        helpers.MsgSuccess(Clases.Messages.MsgUpdatedSuccessfully);
                        Clean();
                        StartForm();
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(helpers.MsgQuestion(Clases.Messages.MsgCancel) == "S")
            {
                Clean();
                StartForm();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(helpers.MsgQuestion(Clases.Messages.MsgDelete) == "S")
            {
                string condition = "IDAUTOR='" + code + "'";

                if (repository.Destroy("AUTORES", condition) > 0)
                {
                    helpers.MsgSuccess(Clases.Messages.MsgDeletedSuccessfully);
                    Clean();
                    StartForm();
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Metodo StateButtons -> Habilita y deshabilita los botones
        private void StateButtons(bool stnew, bool stsave, bool stupdate, bool stdelete, bool stcancel, bool stexit, bool stsearch)
        {
            BtnNew.Enabled = stnew;
            BtnSave.Enabled = stsave;
            BtnUpdate.Enabled = stupdate;
            BtnDelete.Enabled = stdelete;
            BtnCancel.Enabled = stcancel;
            BtnClose.Enabled = stexit;
            BtnSearch.Enabled = stsearch;
        }

        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            DgvData.Refresh();
            StateButtons(true, false, false, false, true, true, true);

            Clean();

            TxtAuthor.Enabled = false;
            TxtSearch.Enabled = true;
            CmbCountry.Enabled = false;
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DgvData.Rows.Clear();
            TxtAuthor.Clear();
            CmbCountry.SelectedIndex = -1;
            TxtSearch.Clear();
        }

        // Metodo ValidateInfo -> Valida la informacion ingresada en los campos
        private void ValidateInfo()
        {
            if (TxtAuthor.Text.Trim().Length == 0)
            {
                helpers.MsgWarning("INGRESE EL NOMBRE DEL AUTOR!");
                TxtAuthor.Focus();
                errors++;
                return;
            }

            if (CmbCountry.Text == "")
            {
                helpers.MsgWarning("SELECCIONE EL PAIS DE ORIGEN DEL AUTOR!");
                CmbCountry.Focus();
                errors++;
                return;
            }
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            author = helpers.CleanStr(TxtAuthor.Text.Trim());
            country = CmbCountry.Text != "" ? CmbCountry.SelectedValue.ToString() : "";
        }

        // Metodo GetCountries -> Obtiene los paises de la base de datos
        private void GetCountries()
        {
            DataTable data = repository.Find("PAISES", "IDPAIS, PAIS", "", "PAIS");
            CmbCountry.DataSource = data;
            CmbCountry.ValueMember = "IDPAIS";
            CmbCountry.DisplayMember = "PAIS";
            CmbCountry.SelectedIndex = -1;
        }

        // Metodo GetAuthors -> Muestra los registros en el data gried view
        private void GetAuthors(string search = "")
        {
            string condition = "", fields = "IDAUTOR, AUTOR";

            if (search != "")
            {
                condition = "AUTOR LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("AUTORES", fields, condition);
            DgvData.Rows.Clear();

            string _id, _author;

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _id = data.Rows[i][0].ToString();
                    _author = data.Rows[i][1].ToString();

                    DgvData.Rows.Add(_id, _author);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetAuthors(search);
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DgvData.Rows.Count > 0)
            {
                string id = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoAuthors(id);

                TxtAuthor.Enabled = true;
                TxtSearch.Enabled = false;
                CmbCountry.Enabled = true;
                TxtAuthor.Focus();
            }
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "AUT" + repository.GetNext(idmodule);
        }


        // Metodo GetInfoAuthors -> Muestra un registro en los campos para su edicion o eliminacion
        private void GetInfoAuthors(string id)
        {
            string condition = "IDAUTOR = '" + id + "'";
            DataTable data = repository.Find("AUTORES", "*", condition);

            if (data.Rows.Count > 0)
            {
                DataRow info = data.Rows[0];
                code = info["IDAUTOR"].ToString();
                TxtAuthor.Text = info["AUTOR"].ToString();
                CmbCountry.SelectedValue = info["IDPAIS"].ToString();

                StateButtons(false, false, true, true, true, false, false);
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgErrorInfo);
            }
        }
    }
}