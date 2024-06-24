using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms.Employees
{
    public partial class FrmEmployees : Form
    {
        // Instancias
        private Clases.Helpers helpers = new Clases.Helpers();

        private Clases.Repository repository = new Clases.Repository();

        private string code, document, name, lastname, adress, email, genre, phone, dateb, job, stateemployee;

        double salary;

        int errors = 0;
        string idmodule = "EMP";

        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Empleados | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StateButtons(false, true, false, false, true, false, false);
            StateControls(true);
            AutoGenCode();

            TxtSearch.Clear();
            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

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

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetEmployees(search);
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            DgvData.Rows.Clear();
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
            TxtDocument.Enabled = state;
            TxtName.Enabled = state;
            TxtLastName.Enabled = state;
            TxtAdress.Enabled = state;
            TxtEmail.Enabled = state;
            CmbGenre.Enabled = state;
            TxtPhone.Enabled = state;
            DtpDateBirth.Enabled = state;
            CmbJob.Enabled = state;
            TxtSalary.Enabled = state;
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DgvData.Rows.Clear();
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
            CmbGenre.SelectedIndex = -1;
            CmbJob.SelectedIndex = -1;
            var datetoday = DateTime.Now;
            DtpDateBirth.Text = datetoday.ToString();
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "EMP" + repository.GetNext(idmodule);
            // helpers.MsgInfo(code.ToString());
        }

        private void StartForm()
        {
            DgvData.Refresh();
            StateButtons(true, false, false, false, true, true, true);

            Clean();

            StateControls(false);
            StateEmployee(false);
            TxtSearch.Enabled = true;
            BtnSearch.Enabled = true;
        }

        private void ValidateData()
        {
            errors = 0;
            var datetoday = DateTime.Now;

            if (helpers.CleanStr(TxtDocument.Text.Trim()).Length == 0)
            {
                TxtDocument.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtName.Text.Trim()).Length == 0)
            {
                TxtName.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtLastName.Text.Trim()).Length == 0)
            {
                TxtLastName.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtAdress.Text.Trim()).Length == 0)
            {
                TxtAdress.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtEmail.Text.Trim()).Length == 0)
            {
                TxtEmail.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (CmbGenre.Text == "")
            {
                CmbGenre.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtPhone.Text.Trim()).Length == 0)
            {
                TxtPhone.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (DtpDateBirth.Text == datetoday.ToString())
            {
                DtpDateBirth.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (CmbJob.Text == "")
            {
                CmbJob.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtSalary.Text.Trim()).Length == 0)
            {
                TxtSalary.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }
        }

        private void SetValues()
        {
            document = helpers.CleanStr(TxtDocument.Text.Trim());
            name = helpers.CleanStr(TxtName.Text.Trim());
            lastname = helpers.CleanStr(TxtLastName.Text.Trim());
            adress = helpers.CleanStr(TxtAdress.Text.Trim());
            email = helpers.CleanStr(TxtEmail.Text.Trim());
            genre = CmbGenre.Text.Trim();
            phone = helpers.CleanStr(TxtPhone.Text.Trim());
            dateb = DtpDateBirth.Text;
            job = CmbJob.Text.Trim();
            salary = Convert.ToDouble(helpers.CleanStr(TxtSalary.Text.Trim()));
        }

        // Metodo GetPublishers -> Muestra los registros en el data gried view
        private void GetEmployees(string search = "")
        {
            string condition = "", fields = "IDEMP, DOCUMENTO, NOMBRE + SPACE(1) + APELLIDOS AS 'NAME', ESTADO";

            if (search != "")
            {
                condition = "NOMBRE LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("EMPLEADOS", fields, condition);
            DgvData.Rows.Clear();

            string _idemployee, _document, _name, _statee;
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _idemployee = data.Rows[i][0].ToString();
                    _document = data.Rows[i][1].ToString();
                    _name = data.Rows[i][2].ToString();
                    _statee = data.Rows[i][3].ToString();

                    DgvData.Rows.Add(_idemployee, _document, _name, _statee);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        private void GetInfoEmployees(string id)
        {
            string condition = "IDEMP='" + id + "'";
            DataTable data = repository.Find("EMPLEADOS", "*", condition);

            if (data.Rows.Count > 0)
            {
                DataRow info = data.Rows[0];
                code = info["IDEMP"].ToString();
                TxtDocument.Text = info["DNI"].ToString();
                TxtName.Text = info["NOMBRE"].ToString();
                TxtLastName.Text = info["APELLIDOS"].ToString();
                TxtAdress.Text = info["DIREDIT"].ToString();
                TxtEmail.Text = info["EMAILEMP"].ToString();
                CmbGenre.Text = info["SEXO"].ToString();
                TxtPhone.Text = info["TELEMP"].ToString();
                DtpDateBirth.Text = info["FNACIMIENTO"].ToString();
                CmbJob.SelectedValue = info["IDCARGO"].ToString();
                TxtSalary.Text = info["SALARY"].ToString();
                CmbStateEmployee.Text = info["ESTADO"].ToString();
                StateEmployee(true);

                StateButtons(false, false, true, true, true, false, false);
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgErrorInfo);
            }
        }

        private void StateEmployee(bool state)
        {
            CmbStateEmployee.Visible = state;
            LblStaetEmployee.Visible = state;

            CmbStateEmployee.Enabled = state;
        }
    }
}
