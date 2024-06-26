namespace Biblioteca.Forms.Loans
{
    partial class FrmLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoans));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.TxtIdApplicant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFApplicant = new System.Windows.Forms.DateTimePicker();
            this.DtpFVacant = new System.Windows.Forms.DateTimePicker();
            this.BtnSearchApplicant = new System.Windows.Forms.Button();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.BtnCleanApplicant = new System.Windows.Forms.Button();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtComentary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnCleanIdBook = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.toolStripSeparator1,
            this.BtnSave,
            this.toolStripSeparator2,
            this.BtnCancel,
            this.toolStripSeparator4,
            this.BtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 31);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(76, 28);
            this.BtnNew.Text = "NUEVO";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 28);
            this.BtnSave.Text = "GUARDAR";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 28);
            this.BtnCancel.Text = "CANCELAR";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnClose
            // 
            this.BtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(68, 28);
            this.BtnClose.Text = "SALIR";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtIdApplicant
            // 
            this.TxtIdApplicant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdApplicant.Location = new System.Drawing.Point(185, 76);
            this.TxtIdApplicant.MaxLength = 9;
            this.TxtIdApplicant.Name = "TxtIdApplicant";
            this.TxtIdApplicant.Size = new System.Drawing.Size(202, 27);
            this.TxtIdApplicant.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "CODIGO SOLICITANTE:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "     DATOS GENERALES DEL PRESTAMO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtIdBook
            // 
            this.TxtIdBook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdBook.Location = new System.Drawing.Point(185, 109);
            this.TxtIdBook.MaxLength = 9;
            this.TxtIdBook.Name = "TxtIdBook";
            this.TxtIdBook.Size = new System.Drawing.Size(202, 27);
            this.TxtIdBook.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "CODIGO LIBRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(633, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "F. SOLICITUD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "F. ENTREGA:";
            // 
            // DtpFApplicant
            // 
            this.DtpFApplicant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFApplicant.Location = new System.Drawing.Point(745, 73);
            this.DtpFApplicant.Name = "DtpFApplicant";
            this.DtpFApplicant.Size = new System.Drawing.Size(105, 27);
            this.DtpFApplicant.TabIndex = 58;
            // 
            // DtpFVacant
            // 
            this.DtpFVacant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFVacant.Location = new System.Drawing.Point(745, 106);
            this.DtpFVacant.Name = "DtpFVacant";
            this.DtpFVacant.Size = new System.Drawing.Size(105, 27);
            this.DtpFVacant.TabIndex = 59;
            // 
            // BtnSearchApplicant
            // 
            this.BtnSearchApplicant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchApplicant.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchApplicant.Image")));
            this.BtnSearchApplicant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearchApplicant.Location = new System.Drawing.Point(393, 76);
            this.BtnSearchApplicant.Name = "BtnSearchApplicant";
            this.BtnSearchApplicant.Size = new System.Drawing.Size(201, 27);
            this.BtnSearchApplicant.TabIndex = 60;
            this.BtnSearchApplicant.Text = "BUSCAR POR NOMBRE";
            this.BtnSearchApplicant.UseVisualStyleBackColor = true;
            this.BtnSearchApplicant.Click += new System.EventHandler(this.BtnSearchApplicant_Click);
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchBook.Image")));
            this.BtnSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearchBook.Location = new System.Drawing.Point(393, 109);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(201, 27);
            this.BtnSearchBook.TabIndex = 61;
            this.BtnSearchBook.Text = "BUSCAR POR NOMBRE";
            this.BtnSearchBook.UseVisualStyleBackColor = true;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BtnCleanApplicant
            // 
            this.BtnCleanApplicant.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanApplicant.Image = ((System.Drawing.Image)(resources.GetObject("BtnCleanApplicant.Image")));
            this.BtnCleanApplicant.Location = new System.Drawing.Point(600, 76);
            this.BtnCleanApplicant.Name = "BtnCleanApplicant";
            this.BtnCleanApplicant.Size = new System.Drawing.Size(27, 27);
            this.BtnCleanApplicant.TabIndex = 62;
            this.BtnCleanApplicant.UseVisualStyleBackColor = true;
            this.BtnCleanApplicant.Click += new System.EventHandler(this.BtnCleanApplicant_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCode,
            this.DcMember,
            this.DcBook,
            this.DcDeadline});
            this.DgvData.Location = new System.Drawing.Point(16, 221);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(834, 231);
            this.DgvData.TabIndex = 64;
            // 
            // DcCode
            // 
            this.DcCode.HeaderText = "CODIGO";
            this.DcCode.Name = "DcCode";
            this.DcCode.ReadOnly = true;
            this.DcCode.Width = 150;
            // 
            // DcMember
            // 
            this.DcMember.HeaderText = "ESTUDIANTE";
            this.DcMember.Name = "DcMember";
            this.DcMember.ReadOnly = true;
            this.DcMember.Width = 270;
            // 
            // DcBook
            // 
            this.DcBook.HeaderText = "LIBRO";
            this.DcBook.Name = "DcBook";
            this.DcBook.ReadOnly = true;
            this.DcBook.Width = 250;
            // 
            // DcDeadline
            // 
            this.DcDeadline.HeaderText = "F. ENTREGA";
            this.DcDeadline.Name = "DcDeadline";
            this.DcDeadline.ReadOnly = true;
            this.DcDeadline.Width = 150;
            // 
            // TxtComentary
            // 
            this.TxtComentary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComentary.Location = new System.Drawing.Point(185, 142);
            this.TxtComentary.MaxLength = 150;
            this.TxtComentary.Name = "TxtComentary";
            this.TxtComentary.Size = new System.Drawing.Size(665, 27);
            this.TxtComentary.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "COMENTARIO:";
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnBook.ForeColor = System.Drawing.Color.Teal;
            this.BtnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnReturnBook.Image")));
            this.BtnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturnBook.Location = new System.Drawing.Point(16, 458);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(232, 27);
            this.BtnReturnBook.TabIndex = 67;
            this.BtnReturnBook.Text = "GESTIONAR DEVOLUCION";
            this.BtnReturnBook.UseVisualStyleBackColor = true;
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // BtnCleanIdBook
            // 
            this.BtnCleanIdBook.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanIdBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnCleanIdBook.Image")));
            this.BtnCleanIdBook.Location = new System.Drawing.Point(600, 109);
            this.BtnCleanIdBook.Name = "BtnCleanIdBook";
            this.BtnCleanIdBook.Size = new System.Drawing.Size(27, 27);
            this.BtnCleanIdBook.TabIndex = 68;
            this.BtnCleanIdBook.UseVisualStyleBackColor = true;
            this.BtnCleanIdBook.Click += new System.EventHandler(this.BtnCleanIdBook_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(823, 183);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 72;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSearch.Location = new System.Drawing.Point(523, 183);
            this.TxtSearch.MaxLength = 150;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(294, 27);
            this.TxtSearch.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(444, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "BUSCAR:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-4, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(444, 28);
            this.label9.TabIndex = 69;
            this.label9.Text = "     PRESTAMOS ACTIVOS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(507, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 14);
            this.label7.TabIndex = 73;
            this.label7.Text = "SELECCIONAR UN REGISTRO PARA REALIZAR UNA DEVOLUCION";
            // 
            // FrmLoans
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(870, 494);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnCleanIdBook);
            this.Controls.Add(this.BtnReturnBook);
            this.Controls.Add(this.TxtComentary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.BtnCleanApplicant);
            this.Controls.Add(this.BtnSearchBook);
            this.Controls.Add(this.BtnSearchApplicant);
            this.Controls.Add(this.DtpFVacant);
            this.Controls.Add(this.DtpFApplicant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtIdBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdApplicant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmLoans_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.TextBox TxtIdApplicant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFApplicant;
        private System.Windows.Forms.DateTimePicker DtpFVacant;
        private System.Windows.Forms.Button BtnSearchApplicant;
        private System.Windows.Forms.Button BtnSearchBook;
        private System.Windows.Forms.Button BtnCleanApplicant;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.TextBox TxtComentary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnCleanIdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDeadline;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}