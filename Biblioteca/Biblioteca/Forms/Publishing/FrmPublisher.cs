using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Forms.Publishing
{
    public partial class FrmPublisher : Form
    {
        // Instancias
        private Clases.Helpers helpers = new Clases.Helpers();

        private Clases.Repository repository = new Clases.Repository();

        // Variables
        private string code, publisher, adress, email, phone;

        private int errors = 0;
        private string idmodule = "EDT";

        public FrmPublisher()
        {
            InitializeComponent();
        }

        private void FrmPublisher_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Editoriales | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StateButtons(false, true, false, false, true, false, false);
            StateControls(true, true, true, true);
            AutoGenCode();
            TxtSearch.Clear();

            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;
            TxtPublisher.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (errors == 0)
            {
                SetValues();
                string fields = "IDEDIT, EDITORIAL, DIREDIT, TELEDIT, EMAILEDIT";
                string values = "'" + code + "', '" + publisher + "','" + adress + "', '" + phone + "', '" + email + "'";

                if (repository.Save("EDITORIALES", fields, values) > 0)
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
            ValidateData();

            if (errors == 0)
            {
                SetValues();

                if (helpers.MsgQuestion(Clases.Messages.MsgUpdate) == "S")
                {
                    string values = "EDITORIAL='" + publisher + "',DIREDIT='" + adress + "', TELEDIT='" + phone + "', EMAILEDIT='" + email + "'";
                    string condition = "IDEDIT='" + code + "'";

                    if (repository.Update("EDITORIALES", values, condition) > 0)
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
            if (helpers.MsgQuestion(Clases.Messages.MsgCancel) == "S")
            {
                Clean();
                StartForm();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (helpers.MsgQuestion(Clases.Messages.MsgDelete) == "S")
            {
                string condition = "IDEDIT='" + code + "'";

                if (repository.Destroy("EDITORIALES", condition) > 0)
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetPublishers(search);
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

        // Metodo StateControls -> Habilita y deshabilita los controles
        private void StateControls(bool stpublisher, bool stadress, bool stemail, bool stphone)
        {
            TxtPublisher.Enabled = stpublisher;
            TxtAdress.Enabled = stadress;
            TxtEmail.Enabled = stemail;
            TxtPhone.Enabled = stphone;
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DgvData.Rows.Clear();
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "EDT" + repository.GetNext(idmodule);
            // helpers.MsgInfo(code.ToString());
        }

        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            DgvData.Refresh();
            StateButtons(true, false, false, false, true, true, true);

            Clean();

            StateControls(false, false, false, false);
            TxtSearch.Enabled = true;
            BtnSearch.Enabled = true;
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string id = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoPublishers(id);

                TxtSearch.Enabled = false;
                StateControls(true, true, true, true);
            }
        }

        // Metodo ValideData -> Valida la informacion ingresada en los campos
        private void ValidateData()
        {
            errors = 0;

            if (helpers.CleanStr(TxtPublisher.Text.Trim()).Length == 0)
            {
                TxtPublisher.Focus();
                helpers.MsgWarning("INGRESE EL NOMBRE DE LA EDITORIAL!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtAdress.Text.Trim()).Length == 0)
            {
                TxtAdress.Focus();
                helpers.MsgWarning("INGRESE LA DIRECCION DE LA EDITORIAL!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtEmail.Text.Trim()).Length == 0)
            {
                TxtEmail.Focus();
                helpers.MsgWarning("INGRESE EL CORREO ELECTRONICO DE LA EDITORIAL!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtPhone.Text.Trim()).Length == 0)
            {
                TxtPhone.Focus();
                helpers.MsgWarning("INGRESE EL NUMERO DE TELEFONO DE LA EDITORIAL!");
                errors++;
                return;
            }
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            publisher = helpers.CleanStr(TxtPublisher.Text.Trim());
            adress = helpers.CleanStr(TxtAdress.Text.Trim());
            email = helpers.CleanStr(TxtEmail.Text.Trim());
            phone = helpers.CleanStr(TxtPhone.Text.Trim());
        }

        // Metodo GetPublishers -> Muestra los registros en el data gried view
        private void GetPublishers(string search = "")
        {
            string condition = "", fields = "IDEDIT, EDITORIAL";

            if (search != "")
            {
                condition = "EDITORIAL LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("EDITORIALES", fields, condition);
            DgvData.Rows.Clear();

            string _idpublisher, _publisher;
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _idpublisher = data.Rows[i][0].ToString();
                    _publisher = data.Rows[i][1].ToString();

                    DgvData.Rows.Add(_idpublisher, _publisher);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        // Metodo GetInfoPublishers -> Muestra un registro en los campos para su edicion o eliminacion
        private void GetInfoPublishers(string id)
        {
            string condition = "IDEDIT='" + id + "'";
            DataTable data = repository.Find("EDITORIALES", "*", condition);

            if (data.Rows.Count > 0)
            {
                DataRow info = data.Rows[0];
                code = info["IDEDIT"].ToString();
                TxtPublisher.Text = info["EDITORIAL"].ToString();
                TxtAdress.Text = info["DIREDIT"].ToString();
                TxtPhone.Text = info["TELEDIT"].ToString();
                TxtEmail.Text = info["EMAILEDIT"].ToString();

                StateButtons(false, false, true, true, true, false, false);
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgErrorInfo);
            }
        }
    }
}