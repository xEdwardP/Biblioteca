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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Biblioteca.Forms.Memberships
{
    public partial class FrmMemberships : Form
    {
        // Instancias
        Clases.Helpers helpers = new Clases.Helpers();

        Clases.Repository repository = new Clases.Repository();

        string code;

        int errors = 0;

        string idmodule = "MEM";

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
            //AutoGenCode();
            StateButtons(false, true, false, false, true, false, false);
            StateControls(true);

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
                string fields = "";
                string values = "";

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

        private void StateControls(bool state)
        {
            //
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

            foreach (ComboBox cmb in this.Controls.OfType<ComboBox>())
            {
                cmb.SelectedIndex = -1;
            }
        }

        private void ValideData()
        {
            errors = 0;
        }

        private void SetValues()
        {
            //
        }
    }
}
