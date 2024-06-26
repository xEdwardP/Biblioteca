using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Biblioteca.Forms.Employees
{
    public partial class FrmEmployees : Form
    {
        // Instancias
        private Clases.Helpers helpers = new Clases.Helpers();

        private Clases.Repository repository = new Clases.Repository();

        string code, document, name, lastname, adress, email, genre, phone, fechanac, job, stateemployee;
        string datetoday = DateTime.Today.ToShortDateString().ToString();

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
            //Seed();
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
            ValidateData();

            if(errors == 0)
            {
                SetValues();

                string fields = "IDEMP, DOCEMP, NOMEMP, APEEMP, DIREMP, EMAILEMP, SEXO, TELEMP, FNACEMP, CARGOEMP, SALARIOEMP";
                string values = "'" + code + "', '" + document + "', '" + name + "', '" + lastname + "', '" + adress + "', '" + email + "','" + genre + "', '" + phone + "', '" + fechanac + "', '" + job + "', " + salary + "";

                if (repository.Save("EMPLEADOS", fields, values) > 0)
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
                    //string id = code;
                    string values = "DOCEMP='" + document + "', NOMEMP='" + name + "', APEEMP='" + lastname + "', DIREMP='" + adress + "', EMAILEMP='" + email + "'," +
                        "SEXO='" + genre + "', TELEMP='" + phone + "', FNACEMP='" + fechanac + "', CARGOEMP='" + job + "', SALARIOEMP=" + salary + "";
                    string condition = "IDEMP='" + code + "'";

                    if (repository.Update("EMPLEADOS", values, condition) > 0)
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
                string condition = "IDEMP='" + code + "'";

                if (repository.Destroy("EMPLEADOS", condition) > 0)
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
            GetEmployees(search);
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            DgvData.Rows.Clear();
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string id = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoEmployees(id);

                StateControls(true);
                TxtDocument.Enabled = false;
                TxtName.Focus();
            }
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
            BtnCancelSearch.Enabled = stsearch;
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
            DtpDateB.Enabled = state;
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
            var datetoday = DateTime.Today.ToShortDateString();
            DtpDateB.Text = datetoday.ToString();
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

            //Clean();

            StateControls(false);
            StateEmployee(false);
            TxtSearch.Enabled = true;
            BtnSearch.Enabled = true;
        }

        private void ValidateData()
        {
            errors = 0;
            string datetoday = DateTime.Today.ToShortDateString().ToString();
            //helpers.MsgInfo(datetoday);

            if (helpers.CleanStr(TxtDocument.Text.Trim()).Length < 13)
            {
                TxtDocument.Focus();
                helpers.MsgWarning("INGRESE UN NUMERO DE DOCUMENTO VALIDO!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtName.Text.Trim()).Length == 0)
            {
                TxtName.Focus();
                helpers.MsgWarning("INGRESE EL NOMBRE DE EL EMPLEADO!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtLastName.Text.Trim()).Length == 0)
            {
                TxtLastName.Focus();
                helpers.MsgWarning("INGRESE LOS APELLIDOS DE EL EMPLEADO!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtAdress.Text.Trim()).Length == 0)
            {
                TxtAdress.Focus();
                helpers.MsgWarning("INGRESE LA DIRECCION DE EL EMPLEADO!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtEmail.Text.Trim()).Length == 0)
            {
                TxtEmail.Focus();
                helpers.MsgWarning("INGRESE EL EMAIL DE EL EMPLEADO!");
                errors++;
                return;
            }

            if (CmbGenre.Text == "")
            {
                CmbGenre.Focus();
                helpers.MsgWarning("SELECCIONE EL SEXO DEL EMPLEADO!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtPhone.Text.Trim()).Length == 0)
            {
                TxtPhone.Focus();
                helpers.MsgWarning("INGRESE EL NUMERO DEL TELEFONO!");
                errors++;
                return;
            }

            //if (DtpDateBirth.Text == datetoday)
            //{
            //    DtpDateBirth.Focus();
            //    helpers.MsgWarning("INGRESE UNA FECHA DE NACIMIENTO VALIDA!");
            //    errors++;
            //    return;
            //}

            if (CmbJob.Text == "")
            {
                CmbJob.Focus();
                helpers.MsgWarning("DEBE ELEGIR UN CARGO DE LA LISTA DESPLEGABLE!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtSalary.Text.Trim()).Length == 0 || Convert.ToDouble(helpers.CleanStr(TxtSalary.Text.Trim())) <= 0)
            {
                TxtSalary.Focus();
                helpers.MsgWarning("INGRESE EL SALARIO CON UN VALOR VALIDO!");
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
            //dateb = DtpDateBirth.Text;
            fechanac = DtpDateB.Text;
            job = CmbJob.Text.Trim();
            salary = Convert.ToDouble(helpers.CleanStr(TxtSalary.Text.Trim()));
        }

        // Metodo GetPublishers -> Muestra los registros en el data gried view
        private void GetEmployees(string search = "")
        {
            string condition = "", fields = "IDEMP, DOCEMP, NOMEMP + SPACE(1) + APEEMP AS 'NAME', ESTADO";

            if (search != "")
            {
                condition = "NOMEMP LIKE '%" + search + "%'";
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
                TxtDocument.Text = info["DOCEMP"].ToString();
                TxtName.Text = info["NOMEMP"].ToString();
                TxtLastName.Text = info["APEEMP"].ToString();
                TxtAdress.Text = info["DIREMP"].ToString();
                TxtEmail.Text = info["EMAILEMP"].ToString();
                CmbGenre.Text = info["SEXO"].ToString();
                TxtPhone.Text = info["TELEMP"].ToString();
                DtpDateB.Text = info["FNACEMP"].ToString();
                CmbJob.Text = info["CARGOEMP"].ToString();
                TxtSalary.Text = info["SALARIOEMP"].ToString();
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

        private void Seed()
        {
            TxtDocument.Text = "0401200000128";
            TxtName.Text = "JUAN";
            TxtLastName.Text = "BODOQUE";
            TxtAdress.Text = "SANTA ROSA DE COPAN";
            TxtEmail.Text = "correo@gmail.com";
            CmbGenre.Text = "MASCULINO";
            CmbJob.Text = "GERENTE";
            TxtPhone.Text = "99887766";
            TxtSalary.Text = "12000";
        }
    }
}
