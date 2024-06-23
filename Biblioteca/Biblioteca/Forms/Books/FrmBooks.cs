using Biblioteca.Clases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Biblioteca.Forms.Books
{
    public partial class FrmBooks : Form
    {
        // Instancias
        private Helpers helpers = new Clases.Helpers();

        private Repository repository = new Clases.Repository();

        // Variables Globales
        private string code, title, description, idauthor, idgenre, idpublisher, edition, yearpub, isbn, stock;

        private int errors = 0;

        string idmodule = "LIB";

        public FrmBooks()
        {
            InitializeComponent();
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Libros | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            AutoGenCode();
            StateButtons(false, true, false, false, true, false, false);
            StateControls(true);

            TxtSearch.Clear();
            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateDatos();

            if(errors == 0)
            {
                SetValues();
                string fields = "IDLIBRO, LIBRO, DESCLIBRO, IDAUTOR, IDGENL, IDEDIT, EDITION, APULIB, ISBN, STOCK";
                string values = "'" + code + "', '" + title + "', '" + description + "', '" + idauthor + "', '" + idgenre + "', '" + idpublisher + "'," +
                    "'" + edition + "', '" + yearpub + "', '" + isbn + "', " + stock + "";

                if (repository.Save("LIBROS", fields, values) > 0)
                {
                    helpers.MsgSuccess(Clases.Messages.MsgSave);
                    
                    if(ChkAutoGen.Checked == true)
                    {
                        repository.SetLast(idmodule);
                    }

                    Clean();
                    StartForm();
                } 
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ValidateDatos();

            if (errors == 0)
            {
                SetValues();

                if (helpers.MsgQuestion(Clases.Messages.MsgUpdate) == "S")
                {
                    //string id = code;
                    string values = "LIBRO='" + title + "', DESCLIBRO='" + description + "', IDAUTOR='" + idauthor + "', IDGENL='" + idgenre + "', IDEDIT='" + idpublisher + "'," +
                        "EDITION='" + edition + "', APULIB='" + yearpub + "', ISBN='" + isbn + "', STOCK=" + stock + "";
                    string condition = "IDLIBRO='" + code + "'";

                    if (repository.Update("LIBROS", values, condition) > 0)
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
                string id = TxtCode.Text.Trim();
                string condition = "IDLIBRO='" + id + "'";

                if (repository.Destroy("LIBROS", condition) > 0)
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
            GetBooks(search);
        }

        // Metodo GetAuthors -> Obtiene los autores de la base de datos
        private void GetAuthors()
        {
            DataTable data = repository.Find("AUTORES", "IDAUTOR, AUTOR", "", "AUTOR");
            CmbAuthor.DataSource = data;
            CmbAuthor.ValueMember = "IDAUTOR";
            CmbAuthor.DisplayMember = "AUTOR";
            CmbAuthor.SelectedIndex = -1;
        }

        // Metodo GetPublishers -> Obtiene las editoriales de la base de datos
        private void GetPublishers()
        {
            DataTable data = repository.Find("EDITORIALES", "IDEDIT, EDITORIAL", "", "EDITORIAL");
            CmbPublisher.DataSource = data;
            CmbPublisher.ValueMember = "IDEDIT";
            CmbPublisher.DisplayMember = "EDITORIAL";
            CmbPublisher.SelectedIndex = -1;
        }

        // Metodo GetLiteraryGenres -> Obtiene los generos literarios de la base de datos
        private void GetLiteraryGenres()
        {
            DataTable data = repository.Find("GENEROS_LITERARIOS", "IDGENL, GENEROLIT", "", "GENEROLIT");
            CmbGenre.DataSource = data;
            CmbGenre.ValueMember = "IDGENL";
            CmbGenre.DisplayMember = "GENEROLIT";
            CmbGenre.SelectedIndex = -1;
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string id = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoBooks(id);

                StateControls(true);
                TxtCode.Enabled = false;
                TxtTitle.Focus();
            }
        }

        // Metodo AutoGenCode -> Genera los codigos para libros
        private void AutoGenCode()
        {
            if(ChkAutoGen.Checked == true)
            {
                TxtCode.Text = "LIB" + repository.GetNext(idmodule);
                TxtCode.Enabled = false;
                TxtTitle.Focus();
            }
            else
            {
                TxtCode.Clear();
                TxtCode.Focus();
                TxtCode.Enabled = true;
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
        }

        // Metodo StateControls -> Habilita y deshabilita los controles
        private void StateControls(bool state)
        {
            TxtTitle.Enabled = state;
            TxtDescription.Enabled = state;
            CmbAuthor.Enabled = state;
            CmbGenre.Enabled = state;
            CmbPublisher.Enabled = state;
            CmbEdition.Enabled = state;
            TxtYearP.Enabled = state;
            TxtIsbn.Enabled = state;
            TxtStock.Enabled = state;
        }

        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            GetAuthors();
            GetPublishers();
            GetLiteraryGenres();

            DgvData.Refresh();
            StateButtons(true, false, false, false, true, true, true);
            StateControls(false);
            TxtCode.Enabled = false;

            Clean();

            TxtSearch.Enabled = true;
            ChkAutoGen.Checked = true;
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DgvData.Rows.Clear();

            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }

            foreach (ComboBox cmb in this.Controls.OfType<ComboBox>())
            {
                cmb.SelectedIndex = -1;
            }
        }

        private void ValidateDatos()
        {
            errors = 0;

            if(helpers.CleanStr(TxtCode.Text.Trim()).Length == 0)
            {
                TxtCode.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtTitle.Text.Trim()).Length == 0)
            {
                TxtTitle.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtDescription.Text.Trim()).Length == 0)
            {
                TxtDescription.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if(CmbAuthor.Text == "")
            {
                CmbAuthor.Focus();
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

            if (CmbPublisher.Text == "")
            {
                CmbPublisher.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (CmbEdition.Text == "")
            {
                CmbEdition.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtYearP.Text.Trim()).Length == 0)
            {
                TxtYearP.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtIsbn.Text.Trim()).Length == 0)
            {
                TxtIsbn.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }

            if (helpers.CleanStr(TxtStock.Text.Trim()).Length == 0)
            {
                TxtStock.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }
        }

        private void SetValues()
        {
            code = helpers.CleanStr(TxtCode.Text.Trim());
            title = helpers.CleanStr(TxtTitle.Text.Trim());
            description = helpers.CleanStr(TxtDescription.Text.Trim());
            idauthor = CmbAuthor.Text != "" ? CmbAuthor.SelectedValue.ToString() : "";
            idgenre = CmbGenre.Text != "" ? CmbGenre.SelectedValue.ToString() : "";
            idpublisher = CmbPublisher.Text != "" ? CmbPublisher.SelectedValue.ToString() : "";
            edition = CmbEdition.Text;
            yearpub = helpers.CleanStr(TxtYearP.Text.Trim());
            isbn = helpers.CleanStr(TxtIsbn.Text.Trim());
            stock = helpers.CleanStr(TxtStock.Text.Trim());
        }

        // Metodo GetBooks -> Muestra los registros en el data gried view
        private void GetBooks(string search = "")
        {
            string condition = "", fields = "IDLIBRO, LIBRO, DESCLIBRO, STOCK";

            if (search != "")
            {
                condition = "LIBRO LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("LIBROS", fields, condition);
            DgvData.Rows.Clear();

            string _idbook, _book, _desc, _stock;

            if (data.Rows.Count > 0)
            {
                for (int i = 0;  i < data.Rows.Count; i++)
                {
                    _idbook = data.Rows[i][0].ToString();
                    _book = data.Rows[i][1].ToString();
                    _desc = data.Rows[i][2].ToString();
                    _stock = data.Rows[i][3].ToString();

                    DgvData.Rows.Add(_idbook, _book, _desc, _stock);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        private void GetInfoBooks(string id)
        {
            string condition = "IDLIBRO='" + id + "'";
            DataTable data = repository.Find("LIBROS", "*", condition);

            if (data.Rows.Count > 0)
            {
                DataRow info = data.Rows[0];
                TxtCode.Text = info["IDLIBRO"].ToString();
                TxtTitle.Text = info["LIBRO"].ToString();
                TxtDescription.Text = info["DESCLIBRO"].ToString();
                CmbAuthor.SelectedValue = info["IDAUTOR"].ToString();
                CmbGenre.SelectedValue = info["IDGENL"].ToString();
                CmbPublisher.SelectedValue = info["IDEDIT"].ToString();
                CmbEdition.Text = info["EDITION"].ToString();
                TxtYearP.Text = info["APULIB"].ToString();
                TxtIsbn.Text = info["ISBN"].ToString();
                TxtStock.Text = info["STOCK"].ToString();

                StateButtons(false, false, true, true, true, false, false);
                StateControls(true);
                TxtCode.Enabled = false;
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgErrorInfo);
            }
        }
    }
}
