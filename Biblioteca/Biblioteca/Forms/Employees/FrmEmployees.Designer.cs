namespace Biblioteca.Forms.Employees
{
    partial class FrmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployees));
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdentidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(792, 316);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 52;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg.ForeColor = System.Drawing.Color.Crimson;
            this.LblMsg.Location = new System.Drawing.Point(374, 83);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(478, 27);
            this.LblMsg.TabIndex = 51;
            this.LblMsg.Text = "---";
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcIdentidad,
            this.DcEmpleado});
            this.DgvData.Location = new System.Drawing.Point(12, 352);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(840, 203);
            this.DgvData.TabIndex = 50;
            // 
            // DcIdentidad
            // 
            this.DcIdentidad.HeaderText = "IDENTIDAD";
            this.DcIdentidad.Name = "DcIdentidad";
            this.DcIdentidad.ReadOnly = true;
            this.DcIdentidad.Width = 150;
            // 
            // DcEmpleado
            // 
            this.DcEmpleado.HeaderText = "NOMBRE";
            this.DcEmpleado.Name = "DcEmpleado";
            this.DcEmpleado.ReadOnly = true;
            this.DcEmpleado.Width = 670;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBuscar.Location = new System.Drawing.Point(447, 316);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(339, 27);
            this.TxtBuscar.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "BUSCAR:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-4, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 27);
            this.label8.TabIndex = 47;
            this.label8.Text = "     EMPLEADOS REGISTRADOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(731, 275);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(121, 27);
            this.TxtSalario.TabIndex = 46;
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartamento.FormattingEnabled = true;
            this.CmbDepartamento.Location = new System.Drawing.Point(110, 275);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(484, 27);
            this.CmbDepartamento.TabIndex = 45;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(463, 242);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(131, 27);
            this.TxtTelefono.TabIndex = 44;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Location = new System.Drawing.Point(112, 149);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDireccion.Size = new System.Drawing.Size(740, 54);
            this.TxtDireccion.TabIndex = 43;
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(112, 116);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(740, 27);
            this.TxtNombre.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-4, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "     DATOS GENERALES DEL EMPLEADO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "SALARIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "CARGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "DIRECCION:";
            // 
            // TxtIdentidad
            // 
            this.TxtIdentidad.Location = new System.Drawing.Point(112, 83);
            this.TxtIdentidad.Name = "TxtIdentidad";
            this.TxtIdentidad.Size = new System.Drawing.Size(256, 27);
            this.TxtIdentidad.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "IDENTIDAD:";
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
            this.toolStrip1.Size = new System.Drawing.Size(865, 31);
            this.toolStrip1.TabIndex = 33;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(740, 27);
            this.textBox1.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 53;
            this.label10.Text = "EMAIL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(600, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 19);
            this.label11.TabIndex = 55;
            this.label11.Text = "F. NACIMIENTO:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(731, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.comboBox1.Location = new System.Drawing.Point(112, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 27);
            this.comboBox1.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 57;
            this.label12.Text = "SEXO:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(825, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmEmployees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(865, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.CmbDepartamento);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIdentidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcEmpleado;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdentidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}