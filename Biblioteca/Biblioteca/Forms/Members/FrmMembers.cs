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

namespace Biblioteca.Forms.Members
{
    public partial class FrmMembers : Form
    {
        // Instancias
        private Helpers helpers = new Clases.Helpers();

        private Repository repository = new Clases.Repository();

        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            GetMemberships();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

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
                //Clean();
                //StartForm();
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

        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            DgvData.Rows.Clear();
        }

        private void GetMemberships()
        {
            DataTable data = repository.Find("MEMBRESIAS", "IDMEMBRESIA, MEMBRESIA", "", "MEMBRESIA");
            CmbMembership.DataSource = data;
            CmbMembership.ValueMember = "IDMEMBRESIA";
            CmbMembership.DisplayMember = "MEMBRESIA";
            CmbMembership.SelectedIndex = -1;
        }
    }
}
