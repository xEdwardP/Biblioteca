using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms.Literary_genres
{
    public partial class FrmLiteraryGenres : Form
    {
        // Instancias
        private Clases.Helpers helpers = new Clases.Helpers();

        private Clases.Repository repository = new Clases.Repository();

        private string code, genre;
        int errors = 0;
        string idmodule = "GNL";

        public FrmLiteraryGenres()
        {
            InitializeComponent();
        }

        private void FrmLiteraryGenres_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + "| Generos Literarios | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            StateButtons(false, true, false, false, true, false, false);
            TxtGenre.Enabled = true;
            TxtGenre.Focus();
            TxtSearch.Enabled = false;
            AutoGenCode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            if(errors == 0)
            {
                SetValues();
                string fields = "IDGENL, GENEROLIT";
                string values = "'" + code + "', '" + genre + "'";

                if (repository.Save("GENEROS_LITERARIOS", fields, values) > 0)
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
                    string values = "IDGENL='" + code + "', GENEROLIT='" + genre + "'";
                    string condition = "IDGENL='" + code + "'";

                    if (repository.Update("GENEROS_LITERARIOS", values, condition) > 0)
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
                // string id = code;
                string condition = "IDGENL='" + code + "'";

                if (repository.Destroy("GENEROS_LITERARIOS", condition) > 0)
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
            GetLiteraryGenres(search);
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

            TxtGenre.Enabled = false;
            TxtSearch.Enabled = true;
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            DgvData.Rows.Clear();
            TxtGenre.Clear();
            TxtSearch.Clear();
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "GNL" + repository.GetNext(idmodule);
            helpers.MsgInfo(code.ToString());
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count > 0)
            {
                string id = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoLiteraryGenres(id);

                TxtGenre.Enabled = true;
                TxtSearch.Enabled = false;
                TxtGenre.Enabled = true;
            }
        }

        // Metodo GetLiteraryGenres -> Muestra los registros en el data gried view
        private void GetLiteraryGenres(string search = "")
        {
            string condition = "", fields = "IDGENL, GENEROLIT";

            if(search != "")
            {
                condition = "AUTOR LIKE '%" + search + "%'";
            }

            DataTable data = repository.Find("GENEROS_LITERARIOS", fields, condition);
            DgvData.Rows.Clear();

            string _idgen, _genre;

            for(int i = 0; i <  data.Rows.Count; i++)
            {
                _idgen = data.Rows[i][0].ToString();
                _genre = data.Rows[i][1].ToString();

                DgvData.Rows.Add(_idgen, _genre);
            }

            data.Dispose();
        }

        private void GetInfoLiteraryGenres(string id)
        {
            string condition = "IDGENL='" + id + "'";
            DataTable data = repository.Find("GENEROS_LITERARIOS", "*", condition);

            if (data.Rows.Count > 0)
            {
                DataRow info = data.Rows[0];
                code = info["IDGENL"].ToString();
                TxtGenre.Text = info["GENEROLIT"].ToString();

                StateButtons(false, false, true, true, true, false, false);
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgErrorInfo);
            }
        }

        private void ValidateData()
        {
            // SetValues();
            if(helpers.CleanStr(TxtGenre.Text.Trim()).Length == 0)
            {
                TxtGenre.Focus();
                helpers.MsgWarning("");
                errors++;
                return;
            }
        }

        private void SetValues()
        {
            genre = helpers.CleanStr(TxtGenre.Text.Trim());
        }
    }
}
