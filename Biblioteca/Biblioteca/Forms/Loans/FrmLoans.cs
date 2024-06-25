using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Biblioteca.Forms.Loans
{
    public partial class FrmLoans : Form
    {
        // Instancias
        private Helpers helpers = new Clases.Helpers();

        private Repository repository = new Clases.Repository();

        string datetoday = DateTime.Today.ToShortDateString().ToString();
        int errors, stock, libdisp;
        string code, idmember, idbook, comentary, dateapplicant, datevacant;
        string idmodule = "PSM";

        public FrmLoans()
        {
            InitializeComponent();
        }

        private void FrmLoans_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Prestamos | ";
            StartForm();
            Seed();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StateButtons(false,true,true,false,true);
            StateControls(true);
            AutoGenCode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            if(errors == 0)
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
            StateButtons(true, false, false, true, false);
            StateControls(false);
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            TxtIdApplicant.Clear();
            TxtIdBook.Clear(); ;
            TxtComentary.Clear();
            DtpFApplicant.Text = datetoday;
            DtpFVacant.Text = datetoday;
        }

        private void ValidateData()
        {
            errors = 0;

            if(TxtIdApplicant.Text.Length < 9)
            {
                TxtIdApplicant.Focus();
                helpers.MsgWarning("INGRESE UN CODIGO DE MIEMBRO VALIDO!");
                errors++;
                return;
            }

            if(TxtIdBook.Text.Length < 9)
            {
                TxtIdBook.Focus();
                helpers.MsgWarning("INGRESE UN CODIGO DE LIBRO VALIDO!");
                errors++;
                return;
            }

            if(TxtComentary.Text.Length == 0)
            {
                TxtComentary.Focus();
                errors++;
                return;
                //if (helpers.MsgQuestion("ESTA SEGURO(A) QUE NO DESEA AGREGAR UN COMENTARIO?") == "N")
                //{
                //    TxtComentary.Focus();
                //    errors++;
                //    return;
                //}
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetLoans(search);
        }

        private void SetValues()
        {
            idmember = helpers.CleanStr(TxtIdApplicant.Text.Trim());
            idbook = helpers.CleanStr(TxtIdBook.Text.Trim());
            comentary = helpers.CleanStr(TxtComentary.Text.Trim());
            dateapplicant = DtpFApplicant.Text;
            datevacant = DtpFVacant.Text;

            ValidateMember(idmember);
            ValidateBook(idbook);
        }

        // Metodo AutoGenCode -> Genera los codigos para libros
        private void AutoGenCode()
        {
            code = "PSM" + repository.GetNext(idmodule);
        }

        private void ValidateMember(string id)
        {
            string condition = "IDMIEMBRO='" + id + "'";
            string msg = "EL ESTUDIANTE NO PUEDE SOLICITAR UN PRESTAMO DE LIBRO YA QUE SUPERO EL LIMITE QUE PUEDE TENER, DEBE REALIZAR LA DEVOLUCION DE ALGUN LIBRO!";

            // Verificamos que exista el miembro
            var response = repository.VerifyIfExists("MIEMBROS", "IDMIEMBRO", id);

            if (response == false)
            {
                helpers.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS, VERIFIQUE EL CODIGO O UTILICE EL BOTON DE BUSCAR POR NOMBRE!");
                return;
            }

            // Verificamos que tenga disponible prestamos
            libdisp = Convert.ToInt16(repository.Hook("LIBDISP", "MIEMBROS", condition));

            helpers.MsgInfo(libdisp.ToString());

            if (libdisp == 0)
            {
                helpers.MsgWarning(msg);
                return;
            }
        }

        private void ValidateBook(string id)
        {
            string condition = "IDLIBRO='" + id + "'";

            // Verificamos existencia del codigo de libro
            var response = repository.VerifyIfExists("LIBROS", "IDLIBRO", id);

            if (response == false)
            {
                helpers.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS, VERIFIQUE EL CODIGO O UTILICE EL BOTON DE BUSCAR POR NOMBRE!");
                return;
            }

            // Verificamos disponibilidad en stock
            stock = Convert.ToInt16(repository.Hook("STOCK", "LIBROS", condition));

            if(stock == 0)
            {
                helpers.MsgWarning("EL LIBRO SOLICITADO NO TIENE MAS UNIDADES DISPONIBLES!");
                return;
            }
        }

        private void Seed()
        {
            TxtIdApplicant.Text = "MBO000002";
            TxtIdBook.Text = "LIB000001";
            TxtComentary.Text = "LO QUIERO PARA MI";
        }

        // Metodo DecreaseBooks -> Disminuye la cantidad en stock y en libros que puede solicitar el miembro
        private void DecreaseBooks()
        {
            stock--;
            libdisp--;

            var cond2 = repository.Update("LIBROS", "STOCK='" + stock + "'", "IDLIBRO='" + idbook + "'");
            var cond1 = repository.Update("MIEMBROS", "LIBDISP='" + libdisp + "'", "IDMIEMBRO='" + idmember + "'");

            if(cond1 > 0 && cond2 > 0)
            {
                helpers.MsgSuccess("SE DISMINUYERON LAS EXISTENCIAS!");
            }
        }

        // Metodo GetLoans -> Muestra los registros en el data gried view
        private void GetLoans(string search = "")
        {
            string condition = "", fields = "IDPRESTAMO, IDMIEMBRO, IDLIBRO, FENTREGA";

            if(search != "")
            {
                condition = "IDMIEMBRO LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("PRESTAMOS", fields, condition);
            DgvData.Rows.Clear();

            string _idloan, _idmember, _idbook, _deadline;

            if(data.Rows.Count > 0)
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
