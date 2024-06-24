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

namespace Biblioteca.Forms.Auth
{
    public partial class FrmLogin : Form
    {
        Clases.Helpers helpers = new Clases.Helpers();
        Clases.Data db = new Clases.Data();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //db.CheckFileConfiguration();
            var home = new Forms.FrmHome();
            home.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            string msg = "¿ESTA SEGURO QUE DESEA ABANDONAR LA APLICACION?";
            if (helpers.MsgQuestion(msg) == "S")
            {
                Application.Exit();
            }
        }
    }
}
