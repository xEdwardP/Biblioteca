using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmHome : Form
    {
        Clases.Helpers Helpers = new Clases.Helpers();
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            SetInfoInicial();
        }

        private void BtnAuthors_Click(object sender, EventArgs e)
        {
            //Forms.Authors.FrmAuthors authors = new Forms.Authors.FrmAuthors();
            var authors = new Forms.Authors.FrmAuthors();
            authors.MdiParent = this;
            authors.Show();
        }

        private void BtnLiteraryGenres_Click(object sender, EventArgs e)
        {
            var genres = new Forms.Literary_genres.FrmLiteraryGenres();
            genres.MdiParent = this;
            genres.Show();
        }

        private void BtnPublishers_Click(object sender, EventArgs e)
        {
            var publishers = new Forms.Publishing.FrmPublisher();
            publishers.MdiParent = this;
            publishers.Show();
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
    }
}
