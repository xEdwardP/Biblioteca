using Biblioteca.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca.Forms.Loans
{
    public partial class FrmLoans : Form
    {
        // Instancias
        private Helpers helpers = new Clases.Helpers();

        private Repository repository = new Clases.Repository();

        private string datetoday = DateTime.Today.ToShortDateString().ToString();
        private int errors, stock, libdisp;
        private string code, idmember, idbook, comentary, dateapplicant, datevacant;
        private string idmodule = "PSM";

        public FrmLoans()
        {
            InitializeComponent();
        }

        private void FrmLoans_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Prestamos | ";
            StartForm();
            //Seed();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StateButtons(false, true, true, false, true);
            StateControls(true);
            AutoGenCode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (errors == 0)
            {
                SetValues();
                string fields = "IDPRESTAMO, IDMIEMBRO, IDLIBRO, FSOLICITUD, FENTREGA, COMENTARIO";
                string values = "'" + code + "', '" + idmember + "', '" + idbook + "', '" + dateapplicant + "', '" + datevacant + "', '" + comentary + "'";

                if (repository.Save("PRESTAMOS", fields, values) > 0)
                {
                    helpers.MsgSuccess(Clases.Messages.MsgSave);
                    repository.SetLast(idmodule);
                    DecreaseBooks();
                    Clean();
                    StartForm();
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Metodo StateButtons -> Habilita y deshabilita los botones
        private void StateButtons(bool stnew, bool stsave, bool stcancel, bool stexit, bool stsearch)
        {
            BtnNew.Enabled = stnew;
            BtnSave.Enabled = stsave;
            BtnCancel.Enabled = stcancel;
            BtnClose.Enabled = stexit;

            BtnSearchApplicant.Enabled = stsearch;
            BtnSearchBook.Enabled = stsearch;
            BtnCleanApplicant.Enabled = stsearch;
            BtnCleanIdBook.Enabled = stsearch;
        }

        // Metodo StateControls -> Habilita y deshabilita los controles
        private void StateControls(bool state)
        {
            TxtIdApplicant.Enabled = state;
            TxtIdBook.Enabled = state;
            TxtComentary.Enabled = state;
            DtpFApplicant.Enabled = state;
            DtpFVacant.Enabled = state;
        }

        // Metodo StartHome -> Metodo Inicial
        private void StartForm()
        {
            StateButtons(true, false, true, true, false);
            StateControls(false);
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DgvData.Rows.Clear();
            TxtSearch.Clear();
            TxtIdApplicant.Clear();
            TxtIdBook.Clear(); ;
            TxtComentary.Clear();
            DtpFApplicant.Text = datetoday;
            DtpFVacant.Text = datetoday;
        }

        // Metodo ValideData -> Valida la informacion ingresada en los campos
        private void ValidateData()
        {
            errors = 0;

            string idMemb = helpers.CleanStr(TxtIdApplicant.Text.Trim());
            string idLib = helpers.CleanStr(TxtIdBook.Text.Trim());

            if (helpers.CleanStr(TxtIdApplicant.Text.Trim()).Length < 9)
            {
                TxtIdApplicant.Focus();
                helpers.MsgWarning("INGRESE UN CODIGO DE MIEMBRO VALIDO!");
                errors++;
                return;
            }

            if (TxtIdBook.Text.Length < 9)
            {
                TxtIdBook.Focus();
                helpers.MsgWarning("INGRESE UN CODIGO DE LIBRO VALIDO!");
                errors++;
                return;
            }

            if (TxtComentary.Text.Length == 0)
            {
                TxtComentary.Focus();
                helpers.MsgWarning("INGRESE UN COMENTARIO!");
                errors++;
                return;
            }

            ValidateMember(idMemb);
            ValidateBook(idLib);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetLoans(search);
        }

        private void BtnSearchApplicant_Click(object sender, EventArgs e)
        {
        }

        private void BtnCleanApplicant_Click(object sender, EventArgs e)
        {
            TxtIdApplicant.Clear();
        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
        }

        private void BtnCleanIdBook_Click(object sender, EventArgs e)
        {
            TxtComentary.Clear();
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            // Enviamos la informacion a el formulario de devoluciones
            if (DgvData.Rows.Count > 0)
            {
                string codloan, codbook, codmember, deadline, comentarybook;
                codloan = DgvData.CurrentRow.Cells[0].Value.ToString();
                codmember = DgvData.CurrentRow.Cells[1].Value.ToString();
                codbook = DgvData.CurrentRow.Cells[2].Value.ToString();
                deadline = DgvData.CurrentRow.Cells[3].Value.ToString();
                comentarybook = repository.Hook("COMENTARIO", "PRESTAMOS", "IDPRESTAMO='" + codloan + "'");

                var returnBooks = new Forms.Loans.FrmReturnBooks();
                AddOwnedForm(returnBooks);

                returnBooks.codloan = codloan;
                returnBooks.codmember = codmember;
                returnBooks.codbook = codbook;
                returnBooks.deadline = deadline;
                returnBooks.comentaryloan = comentarybook;

                returnBooks.ShowDialog();
            }
            else
            {
                helpers.MsgWarning("NO HA SELECCIONADO UN REGISTRO, SELECCIONE EL REGISTRO AL QUE DESEA REALIZAR LA DEVOLUCION!");
            }
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            idmember = helpers.CleanStr(TxtIdApplicant.Text.Trim());
            idbook = helpers.CleanStr(TxtIdBook.Text.Trim());
            comentary = helpers.CleanStr(TxtComentary.Text.Trim());
            dateapplicant = DtpFApplicant.Text;
            datevacant = DtpFVacant.Text;
        }

        // Metodo AutoGenCode -> Genera los codigos para libros
        private void AutoGenCode()
        {
            code = "PSM" + repository.GetNext(idmodule);
        }

        // Metodo ValidateMember -> Validamos a el miembro solicitante del prestamo
        private void ValidateMember(string id)
        {
            string condition = "IDMIEMBRO='" + id + "'";
            string msg = "EL ESTUDIANTE NO PUEDE SOLICITAR UN PRESTAMO DE LIBRO YA QUE SUPERO EL LIMITE QUE PUEDE TENER, DEBE REALIZAR LA DEVOLUCION DE ALGUN LIBRO!";

            // Verificamos que exista el miembro
            var response = repository.VerifyIfExists("MIEMBROS", "IDMIEMBRO", id);

            if (response == false)
            {
                helpers.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS, VERIFIQUE EL CODIGO O UTILICE EL BOTON DE BUSCAR POR NOMBRE!");
                errors++;
                return;
            }

            // Verificamos que tenga disponible prestamos
            libdisp = Convert.ToInt16(repository.Hook("LIBDISP", "MIEMBROS", condition));

            //helpers.MsgInfo(libdisp.ToString());

            if (libdisp <= 0)
            {
                helpers.MsgWarning(msg);
                errors++;
                return;
            }
        }

        // Metodo ValidateBook -> Validamos el libro solicitado
        private void ValidateBook(string id)
        {
            string condition = "IDLIBRO='" + id + "'";

            // Verificamos existencia del codigo de libro
            var response = repository.VerifyIfExists("LIBROS", "IDLIBRO", id);

            if (response == false)
            {
                helpers.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS, VERIFIQUE EL CODIGO O UTILICE EL BOTON DE BUSCAR POR NOMBRE!");
                errors++;
                return;
            }

            // Verificamos disponibilidad en stock
            stock = Convert.ToInt16(repository.Hook("STOCK", "LIBROS", condition));

            if (stock <= 0)
            {
                helpers.MsgWarning("EL LIBRO SOLICITADO NO TIENE MAS UNIDADES DISPONIBLES!");
                errors++;
                return;
            }
        }

        // Metodo DecreaseBooks -> Disminuye la cantidad en stock y en libros que puede solicitar el miembro
        private void DecreaseBooks()
        {
            stock--;
            libdisp--;

            var cond2 = repository.Update("LIBROS", "STOCK='" + stock + "'", "IDLIBRO='" + idbook + "'");
            var cond1 = repository.Update("MIEMBROS", "LIBDISP='" + libdisp + "'", "IDMIEMBRO='" + idmember + "'");

            if (cond1 > 0 && cond2 > 0)
            {
                helpers.MsgSuccess("SE DISMINUYERON LAS EXISTENCIAS!");
            }
        }

        // Metodo GetLoans -> Muestra los registros en el data gried view
        private void GetLoans(string search = "")
        {
            string condition = "";
            string query = "A.IDPRESTAMO, B.NOMMIEMBRO + SPACE(1) + B.APEMIEMBRO AS NAME, C.LIBRO, A.FENTREGA, A.ESTADO FROM PRESTAMOS A INNER JOIN MIEMBROS B ON (A.IDMIEMBRO = B.IDMIEMBRO) " +
                "INNER JOIN LIBROS C ON (A.IDLIBRO = C.IDLIBRO)";

            if (search != "")
            {
                condition = "B.MIEMBRO LIKE '%" + search + "%'";
            }
            else
            {
                condition = "A.ESTADO='ACTIVO'";
            }

            //DataTable data = repository.Find("PRESTAMOS", fields, condition);
            DataTable data = new DataTable();
            data = repository.JoinTables(query, condition);
            DgvData.Rows.Clear();

            string _idloan, _idmember, _idbook, _deadline;

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _idloan = data.Rows[i][0].ToString();
                    _idmember = data.Rows[i][1].ToString();
                    _idbook = data.Rows[i][2].ToString();
                    _deadline = data.Rows[i][3].ToString();

                    DgvData.Rows.Add(_idloan, _idmember, _idbook, _deadline);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }
    }
}