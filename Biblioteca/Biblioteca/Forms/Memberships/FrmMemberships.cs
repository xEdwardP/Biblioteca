using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Forms.Memberships
{
    public partial class FrmMemberships : Form
    {
        // Instancias
        private Clases.Helpers helpers = new Clases.Helpers();

        private Clases.Repository repository = new Clases.Repository();

        private string code, memberships;

        private int errors = 0, limitbooks;

        private string idmodule = "MEM";

        public FrmMemberships()
        {
            InitializeComponent();
        }

        private void FrmMemberships_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Membresias | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            AutoGenCode();
            StateButtons(false, true, false, false, true, false, false);
            StateControls(true);
            Clean();
            TxtSearch.Clear();
            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;

            TxtMembership.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValideData();

            if (errors == 0)
            {
                SetValues();
                string fields = "IDMEMBRESIA, MEMBRESIA, LIMITELIB";
                string values = "'" + code + "','" + memberships + "'," + limitbooks + "";

                if (repository.Save("MEMBRESIAS", fields, values) > 0)
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
            ValideData();

            if (errors == 0)
            {
                SetValues();

                if (helpers.MsgQuestion(Clases.Messages.MsgUpdate) == "S")
                {
                    string values = "MEMBRESIA='" + memberships + "', LIMITELIB=" + limitbooks + "";
                    string condition = "IDMEMBRESIA='" + code + "'";

                    if (repository.Update("MEMBRESIAS", values, condition) > 0)
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
                string condition = "IDMEMBRESIA='" + code + "'";

                if (repository.Destroy("MEMBRESIAS", condition) > 0)
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

        // Metodo StateControls -> Habilita y deshabilita los controles
        private void StateControls(bool state)
        {
            TxtMembership.Enabled = state;
            TxtLimit.Enabled = state;
        }

        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            DgvData.Refresh();
            StateButtons(true, false, false, false, true, true, true);
            StateControls(false);

            Clean();

            TxtSearch.Enabled = true;
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

        // Metodo ValideData -> Valida la informacion ingresada en los campos
        private void ValideData()
        {
            errors = 0;
            if (helpers.CleanStr(TxtMembership.Text.Trim()).Length == 0)
            {
                TxtMembership.Focus();
                helpers.MsgWarning("INGRESE EL NOMBRE DE LA MEMBRESIA!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtLimit.Text.Trim()).Length == 0)
            {
                TxtLimit.Focus();
                helpers.MsgWarning("INGRESE EL LIMITE DE LIBROS QUE PUEDE SOLICITAR CON ESTA MEMBRESIA!");
                errors++;
                return;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetMemberships(search);
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            memberships = helpers.CleanStr(TxtMembership.Text.Trim());
            limitbooks = Convert.ToInt16(helpers.CleanStr(TxtLimit.Text.Trim()));
        }

        // Metodo GetMemberships -> Muestra los registros en el data gried view
        private void GetMemberships(string search = "")
        {
            string condition = "", fields = "IDMEMBRESIA, MEMBRESIA, LIMITELIB";

            if (search != "")
            {
                condition = "MEMBRESIA LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("MEMBRESIAS", fields, condition);
            DgvData.Rows.Clear();

            string _idmembership, _membership, _limit;

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _idmembership = data.Rows[i][0].ToString();
                    _membership = data.Rows[i][1].ToString();
                    _limit = data.Rows[i][2].ToString();

                    DgvData.Rows.Add(_idmembership, _membership, _limit);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DgvData.Rows.Count > 0)
            {
                string id = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoMemberships(id);

                StateControls(true);
                TxtSearch.Enabled = false;
                TxtMembership.Focus();
            }
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "MEM" + repository.GetNext(idmodule);
        }

        // Metodo GetInfoMemberships -> Muestra un registro en los campos para su edicion o eliminacion
        private void GetInfoMemberships(string id)
        {
            string condition = "IDMEMBRESIA = '" + id + "'";
            DataTable data = repository.Find("MEMBRESIAS", "*", condition);

            if(data.Rows.Count > 0)
            {
                DataRow info = data.Rows[0];
                code = info["IDMEMBRESIA"].ToString();
                TxtMembership.Text = info["MEMBRESIA"].ToString();
                TxtLimit.Text = info["LIMITELIB"].ToString();

                StateButtons(false, false, true, true, true, false, false);
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgErrorInfo);
            }
        }
    }
}