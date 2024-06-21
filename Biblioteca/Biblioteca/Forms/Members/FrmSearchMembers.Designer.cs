namespace Biblioteca.Forms.Members
{
    partial class FrmSearchMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchMembers));
            this.label3 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSalir = new System.Windows.Forms.ToolStripButton();
            this.GrpCriterios = new System.Windows.Forms.GroupBox();
            this.BtnCleanDgv = new System.Windows.Forms.Button();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RbApellidos = new System.Windows.Forms.RadioButton();
            this.RbIdentidad = new System.Windows.Forms.RadioButton();
            this.RbNombres = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.GrpCriterios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(611, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "DOBLE CLICK PARA SELECCIONAR";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcIdentidad,
            this.DcNombres,
            this.DcDireccion,
            this.DcTelefono});
            this.DgvData.Location = new System.Drawing.Point(10, 134);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(796, 249);
            this.DgvData.TabIndex = 20;
            // 
            // DcIdentidad
            // 
            this.DcIdentidad.HeaderText = "IDENTIDAD";
            this.DcIdentidad.Name = "DcIdentidad";
            this.DcIdentidad.ReadOnly = true;
            this.DcIdentidad.Width = 150;
            // 
            // DcNombres
            // 
            this.DcNombres.HeaderText = "NOMBRE";
            this.DcNombres.Name = "DcNombres";
            this.DcNombres.ReadOnly = true;
            this.DcNombres.Width = 340;
            // 
            // DcDireccion
            // 
            this.DcDireccion.HeaderText = "DIRECCION";
            this.DcDireccion.Name = "DcDireccion";
            this.DcDireccion.ReadOnly = true;
            this.DcDireccion.Width = 200;
            // 
            // DcTelefono
            // 
            this.DcTelefono.HeaderText = "TELEFONO";
            this.DcTelefono.Name = "DcTelefono";
            this.DcTelefono.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 31);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(68, 28);
            this.BtnSalir.Text = "SALIR";
            // 
            // GrpCriterios
            // 
            this.GrpCriterios.Controls.Add(this.BtnCleanDgv);
            this.GrpCriterios.Controls.Add(this.BtnCancelSearch);
            this.GrpCriterios.Controls.Add(this.BtnSearch);
            this.GrpCriterios.Controls.Add(this.TxtSearch);
            this.GrpCriterios.Controls.Add(this.label2);
            this.GrpCriterios.Controls.Add(this.RbApellidos);
            this.GrpCriterios.Controls.Add(this.RbIdentidad);
            this.GrpCriterios.Controls.Add(this.RbNombres);
            this.GrpCriterios.Location = new System.Drawing.Point(0, 72);
            this.GrpCriterios.Name = "GrpCriterios";
            this.GrpCriterios.Size = new System.Drawing.Size(806, 56);
            this.GrpCriterios.TabIndex = 18;
            this.GrpCriterios.TabStop = false;
            this.GrpCriterios.Text = "SELECCIONE EL CRITERIO DE BUSQUEDA";
            // 
            // BtnCleanDgv
            // 
            this.BtnCleanDgv.Image = ((System.Drawing.Image)(resources.GetObject("BtnCleanDgv.Image")));
            this.BtnCleanDgv.Location = new System.Drawing.Point(767, 20);
            this.BtnCleanDgv.Name = "BtnCleanDgv";
            this.BtnCleanDgv.Size = new System.Drawing.Size(24, 24);
            this.BtnCleanDgv.TabIndex = 34;
            this.BtnCleanDgv.UseVisualStyleBackColor = true;
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelSearch.Image")));
            this.BtnCancelSearch.Location = new System.Drawing.Point(737, 20);
            this.BtnCancelSearch.Name = "BtnCancelSearch";
            this.BtnCancelSearch.Size = new System.Drawing.Size(24, 24);
            this.BtnCancelSearch.TabIndex = 33;
            this.BtnCancelSearch.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(707, 20);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(24, 24);
            this.BtnSearch.TabIndex = 32;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSearch.Location = new System.Drawing.Point(335, 20);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(366, 27);
            this.TxtSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUSCAR:";
            // 
            // RbApellidos
            // 
            this.RbApellidos.AutoSize = true;
            this.RbApellidos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbApellidos.Location = new System.Drawing.Point(89, 23);
            this.RbApellidos.Name = "RbApellidos";
            this.RbApellidos.Size = new System.Drawing.Size(83, 18);
            this.RbApellidos.TabIndex = 2;
            this.RbApellidos.Text = "APELLIDOS";
            this.RbApellidos.UseVisualStyleBackColor = true;
            // 
            // RbIdentidad
            // 
            this.RbIdentidad.AutoSize = true;
            this.RbIdentidad.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbIdentidad.Location = new System.Drawing.Point(178, 23);
            this.RbIdentidad.Name = "RbIdentidad";
            this.RbIdentidad.Size = new System.Drawing.Size(84, 18);
            this.RbIdentidad.TabIndex = 1;
            this.RbIdentidad.Text = "IDENTIDAD";
            this.RbIdentidad.UseVisualStyleBackColor = true;
            // 
            // RbNombres
            // 
            this.RbNombres.AutoSize = true;
            this.RbNombres.Checked = true;
            this.RbNombres.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNombres.Location = new System.Drawing.Point(10, 23);
            this.RbNombres.Name = "RbNombres";
            this.RbNombres.Size = new System.Drawing.Size(73, 18);
            this.RbNombres.TabIndex = 0;
            this.RbNombres.TabStop = true;
            this.RbNombres.Text = "NOMBRE";
            this.RbNombres.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "     DATOS GENERALES DEL MIEMBRO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSearchMembers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(814, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GrpCriterios);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GrpCriterios.ResumeLayout(false);
            this.GrpCriterios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcTelefono;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSalir;
        private System.Windows.Forms.GroupBox GrpCriterios;
        private System.Windows.Forms.Button BtnCleanDgv;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbApellidos;
        private System.Windows.Forms.RadioButton RbIdentidad;
        private System.Windows.Forms.RadioButton RbNombres;
        private System.Windows.Forms.Label label1;
    }
}