namespace Biblioteca.Forms.Loans
{
    partial class FrmReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReturnBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtComentaryLoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdApplicant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdLoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbStateBook = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtComentaryBook = new System.Windows.Forms.TextBox();
            this.TxtPenalty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.BtnReturnBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpDateApplicant = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "     DATOS GENERALES DEL PRESTAMO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtComentaryLoan
            // 
            this.TxtComentaryLoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComentaryLoan.Location = new System.Drawing.Point(188, 180);
            this.TxtComentaryLoan.MaxLength = 150;
            this.TxtComentaryLoan.Name = "TxtComentaryLoan";
            this.TxtComentaryLoan.ReadOnly = true;
            this.TxtComentaryLoan.Size = new System.Drawing.Size(491, 27);
            this.TxtComentaryLoan.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "COMENTARIO:";
            // 
            // TxtIdBook
            // 
            this.TxtIdBook.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdBook.Location = new System.Drawing.Point(188, 147);
            this.TxtIdBook.MaxLength = 9;
            this.TxtIdBook.Name = "TxtIdBook";
            this.TxtIdBook.ReadOnly = true;
            this.TxtIdBook.Size = new System.Drawing.Size(491, 27);
            this.TxtIdBook.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "LIBRO:";
            // 
            // TxtIdApplicant
            // 
            this.TxtIdApplicant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdApplicant.Location = new System.Drawing.Point(188, 114);
            this.TxtIdApplicant.MaxLength = 9;
            this.TxtIdApplicant.Name = "TxtIdApplicant";
            this.TxtIdApplicant.ReadOnly = true;
            this.TxtIdApplicant.Size = new System.Drawing.Size(491, 27);
            this.TxtIdApplicant.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "SOLICITANTE:";
            // 
            // TxtIdLoan
            // 
            this.TxtIdLoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdLoan.Location = new System.Drawing.Point(188, 81);
            this.TxtIdLoan.MaxLength = 9;
            this.TxtIdLoan.Name = "TxtIdLoan";
            this.TxtIdLoan.ReadOnly = true;
            this.TxtIdLoan.Size = new System.Drawing.Size(200, 27);
            this.TxtIdLoan.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "CODIGO PRESTAMO:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 26);
            this.label6.TabIndex = 75;
            this.label6.Text = "     DEVOLUCION";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpReturnDate.Location = new System.Drawing.Point(158, 252);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(122, 27);
            this.DtpReturnDate.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 77;
            this.label7.Text = "F. DEVOLUCION:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 19);
            this.label8.TabIndex = 79;
            this.label8.Text = "ESTADO DE LIBRO:";
            // 
            // CmbStateBook
            // 
            this.CmbStateBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStateBook.FormattingEnabled = true;
            this.CmbStateBook.Items.AddRange(new object[] {
            "BUEN ESTADO",
            "DAÑADO",
            "PERDIDO"});
            this.CmbStateBook.Location = new System.Drawing.Point(434, 252);
            this.CmbStateBook.Name = "CmbStateBook";
            this.CmbStateBook.Size = new System.Drawing.Size(245, 27);
            this.CmbStateBook.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "COMENTARIOS:";
            // 
            // TxtComentaryBook
            // 
            this.TxtComentaryBook.Location = new System.Drawing.Point(158, 285);
            this.TxtComentaryBook.MaxLength = 150;
            this.TxtComentaryBook.Name = "TxtComentaryBook";
            this.TxtComentaryBook.Size = new System.Drawing.Size(521, 27);
            this.TxtComentaryBook.TabIndex = 82;
            // 
            // TxtPenalty
            // 
            this.TxtPenalty.Location = new System.Drawing.Point(158, 318);
            this.TxtPenalty.MaxLength = 12;
            this.TxtPenalty.Name = "TxtPenalty";
            this.TxtPenalty.Size = new System.Drawing.Size(122, 27);
            this.TxtPenalty.TabIndex = 84;
            this.TxtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 83;
            this.label10.Text = "MULTA:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClose,
            this.BtnReturnBook,
            this.toolStripSeparator4,
            this.BtnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(695, 31);
            this.toolStrip1.TabIndex = 85;
            this.toolStrip1.Text = "toolStrip1";
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
            // BtnReturnBook
            // 
            this.BtnReturnBook.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnReturnBook.Image")));
            this.BtnReturnBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnReturnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(169, 28);
            this.BtnReturnBook.Text = "REALIZAR DEVOLUCION";
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 19);
            this.label11.TabIndex = 86;
            this.label11.Text = "FECHA DE  ENTREGA";
            // 
            // DtpDateApplicant
            // 
            this.DtpDateApplicant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateApplicant.Location = new System.Drawing.Point(556, 81);
            this.DtpDateApplicant.Name = "DtpDateApplicant";
            this.DtpDateApplicant.Size = new System.Drawing.Size(123, 27);
            this.DtpDateApplicant.TabIndex = 87;
            // 
            // FrmReturnBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(695, 360);
            this.Controls.Add(this.DtpDateApplicant);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TxtPenalty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtComentaryBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbStateBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtpReturnDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIdLoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtComentaryLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdApplicant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmReturnBooks_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtComentaryLoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdApplicant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdLoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbStateBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtComentaryBook;
        private System.Windows.Forms.TextBox TxtPenalty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DtpDateApplicant;
        private System.Windows.Forms.ToolStripButton BtnReturnBook;
    }
}