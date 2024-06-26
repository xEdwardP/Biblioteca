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

namespace Biblioteca.Forms.Loans
{
    public partial class FrmReturnBooks : Form
    {
        // Instancias
        private Helpers helpers = new Clases.Helpers();

        private Repository repository = new Clases.Repository();

        public FrmReturnBooks()
        {
            InitializeComponent();
        }

        private void FrmReturnBooks_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (helpers.MsgQuestion(Clases.Messages.MsgCancel) == "S")
            {
                Clean();
                //StartForm();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clean()
        {
            //
        }
    }
}
