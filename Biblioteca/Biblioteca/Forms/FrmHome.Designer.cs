namespace Biblioteca.Forms
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.OptAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.OptLiteraryGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.OptPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.OptBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.OptEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.OptMemberhips = new System.Windows.Forms.ToolStripMenuItem();
            this.TsReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnExit = new System.Windows.Forms.ToolStripButton();
            this.BtnLoans = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnMembers = new System.Windows.Forms.ToolStripButton();
            this.SstPrincipal = new System.Windows.Forms.StatusStrip();
            this.LblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.LblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.LblBd = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBooks = new System.Windows.Forms.ToolStripButton();
            this.BtnAuthors = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SstPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsArchivo,
            this.TsReportes,
            this.TsConfiguracion,
            this.TsSistema});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsArchivo
            // 
            this.TsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptAuthors,
            this.toolStripSeparator5,
            this.OptLiteraryGenres,
            this.toolStripSeparator6,
            this.OptPublishers,
            this.toolStripSeparator7,
            this.OptBooks,
            this.toolStripSeparator8,
            this.OptEmployee,
            this.toolStripSeparator9,
            this.OptMemberhips});
            this.TsArchivo.Name = "TsArchivo";
            this.TsArchivo.Size = new System.Drawing.Size(70, 20);
            this.TsArchivo.Text = "ARCHIVO";
            // 
            // OptAuthors
            // 
            this.OptAuthors.Image = ((System.Drawing.Image)(resources.GetObject("OptAuthors.Image")));
            this.OptAuthors.Name = "OptAuthors";
            this.OptAuthors.Size = new System.Drawing.Size(189, 22);
            this.OptAuthors.Text = "AUTORES";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(186, 6);
            // 
            // OptLiteraryGenres
            // 
            this.OptLiteraryGenres.Image = ((System.Drawing.Image)(resources.GetObject("OptLiteraryGenres.Image")));
            this.OptLiteraryGenres.Name = "OptLiteraryGenres";
            this.OptLiteraryGenres.Size = new System.Drawing.Size(189, 22);
            this.OptLiteraryGenres.Text = "GENEROS LITERARIOS";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(186, 6);
            // 
            // OptPublishers
            // 
            this.OptPublishers.Image = ((System.Drawing.Image)(resources.GetObject("OptPublishers.Image")));
            this.OptPublishers.Name = "OptPublishers";
            this.OptPublishers.Size = new System.Drawing.Size(189, 22);
            this.OptPublishers.Text = "EDITORIALES";
            this.OptPublishers.Click += new System.EventHandler(this.OptPublishers_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(186, 6);
            // 
            // OptBooks
            // 
            this.OptBooks.Image = ((System.Drawing.Image)(resources.GetObject("OptBooks.Image")));
            this.OptBooks.Name = "OptBooks";
            this.OptBooks.Size = new System.Drawing.Size(189, 22);
            this.OptBooks.Text = "LIBROS";
            this.OptBooks.Click += new System.EventHandler(this.OptBooks_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(186, 6);
            // 
            // OptEmployee
            // 
            this.OptEmployee.Image = ((System.Drawing.Image)(resources.GetObject("OptEmployee.Image")));
            this.OptEmployee.Name = "OptEmployee";
            this.OptEmployee.Size = new System.Drawing.Size(189, 22);
            this.OptEmployee.Text = "EMPLEADOS";
            this.OptEmployee.Click += new System.EventHandler(this.OptEmployee_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(186, 6);
            // 
            // OptMemberhips
            // 
            this.OptMemberhips.Image = ((System.Drawing.Image)(resources.GetObject("OptMemberhips.Image")));
            this.OptMemberhips.Name = "OptMemberhips";
            this.OptMemberhips.Size = new System.Drawing.Size(189, 22);
            this.OptMemberhips.Text = "MEMBRESIAS";
            this.OptMemberhips.Click += new System.EventHandler(this.OptMemberhips_Click);
            // 
            // TsReportes
            // 
            this.TsReportes.Name = "TsReportes";
            this.TsReportes.Size = new System.Drawing.Size(72, 20);
            this.TsReportes.Text = "REPORTES";
            // 
            // TsConfiguracion
            // 
            this.TsConfiguracion.Name = "TsConfiguracion";
            this.TsConfiguracion.Size = new System.Drawing.Size(114, 20);
            this.TsConfiguracion.Text = "CONFIGURACION";
            // 
            // TsSistema
            // 
            this.TsSistema.Name = "TsSistema";
            this.TsSistema.Size = new System.Drawing.Size(65, 20);
            this.TsSistema.Text = "SISTEMA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAuthors,
            this.toolStripSeparator1,
            this.BtnBooks,
            this.toolStripSeparator4,
            this.BtnExit,
            this.BtnLoans,
            this.toolStripSeparator13,
            this.BtnMembers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1087, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnExit
            // 
            this.BtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(68, 28);
            this.BtnExit.Text = "SALIR";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLoans
            // 
            this.BtnLoans.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLoans.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoans.Image")));
            this.BtnLoans.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnLoans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLoans.Name = "BtnLoans";
            this.BtnLoans.Size = new System.Drawing.Size(105, 28);
            this.BtnLoans.Text = "PRESTAMOS";
            this.BtnLoans.Click += new System.EventHandler(this.BtnLoans_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnMembers
            // 
            this.BtnMembers.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMembers.Image = ((System.Drawing.Image)(resources.GetObject("BtnMembers.Image")));
            this.BtnMembers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Size = new System.Drawing.Size(99, 28);
            this.BtnMembers.Text = "MIEMBROS";
            this.BtnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
            // 
            // SstPrincipal
            // 
            this.SstPrincipal.AutoSize = false;
            this.SstPrincipal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUser,
            this.toolStripSeparator10,
            this.LblFecha,
            this.toolStripSeparator11,
            this.LblBd});
            this.SstPrincipal.Location = new System.Drawing.Point(0, 413);
            this.SstPrincipal.Name = "SstPrincipal";
            this.SstPrincipal.Size = new System.Drawing.Size(1087, 37);
            this.SstPrincipal.TabIndex = 8;
            this.SstPrincipal.Text = "statusStrip1";
            // 
            // LblUser
            // 
            this.LblUser.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Image = ((System.Drawing.Image)(resources.GetObject("LblUser.Image")));
            this.LblUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(38, 32);
            this.LblUser.Text = "---";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 37);
            // 
            // LblFecha
            // 
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Image = ((System.Drawing.Image)(resources.GetObject("LblFecha.Image")));
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(38, 32);
            this.LblFecha.Text = "---";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 37);
            // 
            // LblBd
            // 
            this.LblBd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBd.Image = ((System.Drawing.Image)(resources.GetObject("LblBd.Image")));
            this.LblBd.Name = "LblBd";
            this.LblBd.Size = new System.Drawing.Size(38, 32);
            this.LblBd.Text = "---";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnBooks
            // 
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooks.Image")));
            this.BtnBooks.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(77, 28);
            this.BtnBooks.Text = "LIBROS";
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnAuthors
            // 
            this.BtnAuthors.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAuthors.Image = ((System.Drawing.Image)(resources.GetObject("BtnAuthors.Image")));
            this.BtnAuthors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAuthors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAuthors.Name = "BtnAuthors";
            this.BtnAuthors.Size = new System.Drawing.Size(89, 28);
            this.BtnAuthors.Text = "AUTORES";
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.SstPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SstPrincipal.ResumeLayout(false);
            this.SstPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsArchivo;
        private System.Windows.Forms.ToolStripMenuItem OptAuthors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem OptLiteraryGenres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem OptPublishers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem OptBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem OptEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem OptMemberhips;
        private System.Windows.Forms.ToolStripMenuItem TsReportes;
        private System.Windows.Forms.ToolStripMenuItem TsConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem TsSistema;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnExit;
        private System.Windows.Forms.ToolStripButton BtnLoans;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton BtnMembers;
        private System.Windows.Forms.StatusStrip SstPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel LblUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripStatusLabel LblFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripStatusLabel LblBd;
        private System.Windows.Forms.ToolStripButton BtnAuthors;
        private System.Windows.Forms.ToolStripButton BtnBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}