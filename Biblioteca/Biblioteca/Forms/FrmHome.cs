using System;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmHome : Form
    {
        private Clases.Helpers Helpers = new Clases.Helpers();

        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            SetInfoInicial();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            string msg = "¿ESTA SEGURO QUE DESEA ABANDONAR LA APLICACION?";
            if (Helpers.MsgQuestion(msg) == "S")
            {
                Application.Exit();
            }
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            var books = new Forms.Books.FrmBooks();
            books.MdiParent = this;
            books.Show();
        }

        private void SetInfoInicial()
        {
            //this.Text = Clases.Env.APPNAME + " | MENU PRINCIPAL | " + Clases.Auth.REALNAME;
            Text = " | MENU PRINCIPAL | ";
            //LblUser.Text = "[" + Clases.Auth.USER + "]" + Clases.Auth.REALNAME;
            LblUser.Text = "[ USUARIO ANONIMO ]";
            LblFecha.Text = DateTime.Today.ToLongDateString().ToUpper();
        }

        private void OptEmployee_Click(object sender, EventArgs e)
        {
            var employee = new Forms.Employees.FrmEmployees();
            employee.MdiParent = this;
            employee.Show();
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            var members = new Forms.Members.FrmMembers();
            members.MdiParent = this;
            members.Show();
        }

        private void BtnLoans_Click(object sender, EventArgs e)
        {
            var loans = new Forms.Loans.FrmLoans();
            loans.MdiParent = this;
            loans.Show();
        }

        private void OptPublishers_Click(object sender, EventArgs e)
        {
            var publishers = new Forms.Publishing.FrmPublisher();
            publishers.MdiParent = this;
            publishers.Show();
        }

        private void OptBooks_Click(object sender, EventArgs e)
        {
            var books = new Forms.Books.FrmBooks();
            books.MdiParent = this;
            books.Show();
        }

        private void OptMemberhips_Click(object sender, EventArgs e)
        {
            var memberships = new Forms.Memberships.FrmMemberships();
            memberships.MdiParent = this;
            memberships.Show();
        }
    }
}