using Biblioteca.Clases;
using System;
using System.Windows.Forms;

namespace Biblioteca.Forms.Loans
{
    public partial class FrmReturnBooks : Form
    {
        // Instancias
        private Helpers helpers = new Clases.Helpers();

        private Repository repository = new Clases.Repository();

        // Variables
        public string codloan, codbook, codmember, deadline, comentaryloan;
        private string code, returndate, statebook, comentarybook, penaltybook;
        private int errors = 0;
        private string datetoday = DateTime.Today.ToShortDateString().ToString();
        private string idmodule = "DVN";

        public FrmReturnBooks()
        {
            InitializeComponent();
        }

        private void FrmReturnBooks_Load(object sender, EventArgs e)
        {
            StartForm();
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (errors == 0)
            {
                SetValues();
                string fields = "IDDEVOLUCION, IDPRESTAMO, FDEVOLUCION, ESTADOLIBRO, COMENTDEV, MULTA";
                string values = "'" + code + "', '" + codloan + "', '" + returndate + "', '" + statebook + "', '" + comentarybook + "', " + penaltybook + "";

                if (repository.Save("DEVOLUCIONES", fields, values) > 0)
                {
                    repository.Update("PRESTAMOS", "ESTADO='DEVUELTO'", "IDPRESTAMO='" + codloan + "'");
                    helpers.MsgSuccess(Clases.Messages.MsgSave);
                    repository.SetLast(idmodule);
                    IncreaseBooks();
                    Clean();

                    Close();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (helpers.MsgQuestion(Clases.Messages.MsgCancel) == "S")
            {
                Clean();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DtpReturnDate.Text = datetoday;
            CmbStateBook.SelectedIndex = -1;
            TxtComentaryBook.Clear();
            TxtPenalty.Clear();
        }

        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            TxtIdLoan.Text = codloan.ToString();
            DtpDateApplicant.Text = deadline.ToString();
            TxtIdApplicant.Text = codmember.ToString();
            TxtIdBook.Text = codbook.ToString();
            TxtComentaryLoan.Text = comentaryloan.ToString();

            DtpDateApplicant.Enabled = false;
            TxtComentaryLoan.Focus();

            TxtPenalty.Text = "0.00";
        }

        // Metodo ValideData -> Valida la informacion ingresada en los campos
        private void ValidateData()
        {
            errors = 0;
            penaltybook = helpers.CleanStr(TxtPenalty.Text.Trim());
            DateTime date1 = DateTime.Parse(DtpDateApplicant.Text);
            DateTime date2 = DateTime.Parse(DtpReturnDate.Text);

            int resp = DateTime.Compare(date1, date2);

            if (resp > 0)
            {
                DtpReturnDate.Focus();
                helpers.MsgWarning("LA FECHA DE ENTREGA DEBE SER PROXIMA A LA QUE SE PRESTO!");
                errors++;
                return;
            }

            if (CmbStateBook.Text == "")
            {
                CmbStateBook.Focus();
                helpers.MsgWarning("SELECCIONE EL ESTADO EN QUE FUE ENTREGADO EL LIBRO!");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtComentaryBook.Text.Trim()).Length == 0)
            {
                TxtComentaryBook.Clear();
                helpers.MsgWarning("INGRESE UN COMENSARIO SOBRE LA DEVOLUCION!");
                errors++;
                return;
            }

            if (penaltybook.Length == 0 || Convert.ToDouble(penaltybook) < 0)
            {
                TxtPenalty.Clear();
                helpers.MsgWarning("INGRESE UN VALOR DE MULTA VALIDO!");
                errors++;
                return;
            }
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            AutoGenCode();
            returndate = DtpReturnDate.Text;
            statebook = CmbStateBook.Text;
            comentarybook = helpers.CleanStr(TxtComentaryBook.Text.Trim());
            penaltybook = helpers.CleanStr(TxtPenalty.Text.Trim());
        }

        // Metodo IncreaseBooks -> Incrementa la disponibilidad en stock y en solicitudes del miembro
        private void IncreaseBooks()
        {
            string idmember = repository.Hook("IDMIEMBRO", "PRESTAMOS", "IDPRESTAMO='" + codloan + "'");
            string idbook = repository.Hook("IDLIBRO", "PRESTAMOS", "IDPRESTAMO='" + codloan + "'");

            int libdisp = Convert.ToInt16(repository.Hook("LIBDISP", "MIEMBROS", "IDMIEMBRO='" + idmember + "'"));
            int stock = Convert.ToInt16(repository.Hook("STOCK", "LIBROS", "IDLIBRO='" + idbook + "'"));

            libdisp++;
            stock++;

            int change1 = repository.Update("MIEMBROS", "LIBDISP='" + libdisp + "'", "IDMIEMBRO='" + idmember + "'");
            int change2 = repository.Update("LIBROS", "STOCK='" + stock + "'", "IDLIBRO='" + idbook + "'");

            if (change1 > 0 && change2 > 0)
            {
                helpers.MsgSuccess("SE AUMENTÓ LA DISPONIBILIDAD DE LIBROS!");
            }
        }

        // Metodo AutoGenCode -> Genera los codigos para libros
        private void AutoGenCode()
        {
            code = "DVN" + repository.GetNext(idmodule);
        }
    }
}