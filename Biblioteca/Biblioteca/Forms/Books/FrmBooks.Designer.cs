namespace Biblioteca.Forms.Books
{
    partial class FrmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ChkAutoGen = new System.Windows.Forms.CheckBox();
            this.CmbAPub = new System.Windows.Forms.ComboBox();
            this.CmbEdition = new System.Windows.Forms.ComboBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbPublisher = new System.Windows.Forms.ComboBox();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.CmbAuthor = new System.Windows.Forms.ComboBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(850, 285);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 57;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // ChkAutoGen
            // 
            this.ChkAutoGen.AutoSize = true;
            this.ChkAutoGen.Checked = true;
            this.ChkAutoGen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAutoGen.Location = new System.Drawing.Point(324, 84);
            this.ChkAutoGen.Name = "ChkAutoGen";
            this.ChkAutoGen.Size = new System.Drawing.Size(116, 23);
            this.ChkAutoGen.TabIndex = 56;
            this.ChkAutoGen.Text = "Auto Generar";
            this.ChkAutoGen.UseVisualStyleBackColor = true;
            // 
            // CmbAPub
            // 
            this.CmbAPub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAPub.FormattingEnabled = true;
            this.CmbAPub.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.CmbAPub.Location = new System.Drawing.Point(129, 181);
            this.CmbAPub.Name = "CmbAPub";
            this.CmbAPub.Size = new System.Drawing.Size(311, 27);
            this.CmbAPub.TabIndex = 55;
            // 
            // CmbEdition
            // 
            this.CmbEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEdition.FormattingEnabled = true;
            this.CmbEdition.Items.AddRange(new object[] {
            "Edicion N.1",
            "Edicion N.2",
            "Edicion N.3",
            "Edicion N.4",
            "Edicion N.5"});
            this.CmbEdition.Location = new System.Drawing.Point(525, 181);
            this.CmbEdition.Name = "CmbEdition";
            this.CmbEdition.Size = new System.Drawing.Size(352, 27);
            this.CmbEdition.TabIndex = 54;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(525, 214);
            this.TxtStock.MaxLength = 7;
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(352, 27);
            this.TxtStock.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(446, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 19);
            this.label13.TabIndex = 52;
            this.label13.Text = "STOCK:";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(129, 247);
            this.TxtIsbn.MaxLength = 150;
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(311, 27);
            this.TxtIsbn.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "ISBN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "AÑO PUB:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBuscar.Location = new System.Drawing.Point(525, 285);
            this.TxtBuscar.MaxLength = 200;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(319, 27);
            this.TxtBuscar.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "BUSCAR:";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCodigo,
            this.DcTitulo,
            this.DcDescripcion,
            this.DcStock});
            this.DgvData.Location = new System.Drawing.Point(18, 328);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(859, 180);
            this.DgvData.TabIndex = 46;
            // 
            // DcCodigo
            // 
            this.DcCodigo.HeaderText = "CODIGO";
            this.DcCodigo.Name = "DcCodigo";
            this.DcCodigo.ReadOnly = true;
            // 
            // DcTitulo
            // 
            this.DcTitulo.HeaderText = "TITULO";
            this.DcTitulo.Name = "DcTitulo";
            this.DcTitulo.ReadOnly = true;
            this.DcTitulo.Width = 250;
            // 
            // DcDescripcion
            // 
            this.DcDescripcion.HeaderText = "DESCRIPCION";
            this.DcDescripcion.Name = "DcDescripcion";
            this.DcDescripcion.ReadOnly = true;
            this.DcDescripcion.Width = 400;
            // 
            // DcStock
            // 
            this.DcStock.HeaderText = "STOCK";
            this.DcStock.Name = "DcStock";
            this.DcStock.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-2, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 28);
            this.label9.TabIndex = 45;
            this.label9.Text = "     LIBROS REGISTRADOS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbPublisher
            // 
            this.CmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPublisher.FormattingEnabled = true;
            this.CmbPublisher.Location = new System.Drawing.Point(129, 214);
            this.CmbPublisher.Name = "CmbPublisher";
            this.CmbPublisher.Size = new System.Drawing.Size(311, 27);
            this.CmbPublisher.TabIndex = 44;
            // 
            // CmbGenre
            // 
            this.CmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(525, 148);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(352, 27);
            this.CmbGenre.TabIndex = 43;
            // 
            // CmbAuthor
            // 
            this.CmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAuthor.FormattingEnabled = true;
            this.CmbAuthor.Location = new System.Drawing.Point(129, 148);
            this.CmbAuthor.Name = "CmbAuthor";
            this.CmbAuthor.Size = new System.Drawing.Size(311, 27);
            this.CmbAuthor.TabIndex = 42;
            // 
            // TxtDescription
            // 
            this.TxtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescription.Location = new System.Drawing.Point(129, 115);
            this.TxtDescription.MaxLength = 50;
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(748, 27);
            this.TxtDescription.TabIndex = 41;
            // 
            // TxtTitle
            // 
            this.TxtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTitle.Location = new System.Drawing.Point(525, 82);
            this.TxtTitle.MaxLength = 200;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(352, 27);
            this.TxtTitle.TabIndex = 40;
            // 
            // TxtCode
            // 
            this.TxtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCode.Location = new System.Drawing.Point(129, 82);
            this.TxtCode.MaxLength = 30;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(189, 27);
            this.TxtCode.TabIndex = 39;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.toolStripSeparator1,
            this.BtnSave,
            this.toolStripSeparator2,
            this.BtnUpdate,
            this.toolStripSeparator3,
            this.BtnCancel,
            this.toolStripSeparator4,
            this.BtnDelete,
            this.toolStripSeparator5,
            this.BtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 31);
            this.toolStrip1.TabIndex = 38;
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
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(107, 28);
            this.BtnUpdate.Text = "ACTUALIZAR";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
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
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 28);
            this.BtnDelete.Text = "ELIMINAR";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(446, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "EDICION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "EDITORIAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "GENERO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "AUTOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "DESCRIPCION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "TITULO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "CODIGO:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "     DATOS GENERALES DEL LIBRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBooks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.ChkAutoGen);
            this.Controls.Add(this.CmbAPub);
            this.Controls.Add(this.CmbEdition);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtIsbn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbPublisher);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.CmbAuthor);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.CheckBox ChkAutoGen;
        private System.Windows.Forms.ComboBox CmbAPub;
        private System.Windows.Forms.ComboBox CmbEdition;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbPublisher;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.ComboBox CmbAuthor;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}