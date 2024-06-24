namespace Biblioteca.Forms.Memberships
{
    partial class FrmMemberships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberships));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcMembresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLimit = new System.Windows.Forms.TextBox();
            this.TxtDeadline = new System.Windows.Forms.TextBox();
            this.TxtMembership = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(656, 196);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 40;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(89, 196);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(561, 27);
            this.TxtSearch.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "BUSCAR:";
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
            this.DcCodigo,
            this.DcMembresia,
            this.DcPlazo,
            this.DcLimite});
            this.DgvData.Location = new System.Drawing.Point(16, 236);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(667, 159);
            this.DgvData.TabIndex = 36;
            // 
            // DcCodigo
            // 
            this.DcCodigo.HeaderText = "CODIGO";
            this.DcCodigo.Name = "DcCodigo";
            this.DcCodigo.ReadOnly = true;
            // 
            // DcMembresia
            // 
            this.DcMembresia.HeaderText = "MEMBRESIA";
            this.DcMembresia.Name = "DcMembresia";
            this.DcMembresia.ReadOnly = true;
            this.DcMembresia.Width = 300;
            // 
            // DcPlazo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DcPlazo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DcPlazo.HeaderText = "PLAZO DIAS";
            this.DcPlazo.Name = "DcPlazo";
            this.DcPlazo.ReadOnly = true;
            this.DcPlazo.Width = 120;
            // 
            // DcLimite
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DcLimite.DefaultCellStyle = dataGridViewCellStyle4;
            this.DcLimite.HeaderText = "LIMITE LIBROS";
            this.DcLimite.Name = "DcLimite";
            this.DcLimite.ReadOnly = true;
            this.DcLimite.Width = 140;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-4, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "     MEMBRESIAS REGISTRADAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtLimit
            // 
            this.TxtLimit.Location = new System.Drawing.Point(476, 112);
            this.TxtLimit.Name = "TxtLimit";
            this.TxtLimit.Size = new System.Drawing.Size(207, 27);
            this.TxtLimit.TabIndex = 34;
            // 
            // TxtDeadline
            // 
            this.TxtDeadline.Location = new System.Drawing.Point(142, 112);
            this.TxtDeadline.Name = "TxtDeadline";
            this.TxtDeadline.Size = new System.Drawing.Size(201, 27);
            this.TxtDeadline.TabIndex = 33;
            // 
            // TxtMembership
            // 
            this.TxtMembership.Location = new System.Drawing.Point(142, 79);
            this.TxtMembership.Name = "TxtMembership";
            this.TxtMembership.Size = new System.Drawing.Size(541, 27);
            this.TxtMembership.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "LIMITE LIBROS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "PLAZO EN DIAS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "MEMBRESIA:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "     DATOS GENERALES DE LA MEMBRESIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.toolStrip1.Size = new System.Drawing.Size(700, 31);
            this.toolStrip1.TabIndex = 25;
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
            // FrmMemberships
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(700, 412);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtLimit);
            this.Controls.Add(this.TxtDeadline);
            this.Controls.Add(this.TxtMembership);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMemberships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcMembresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcLimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLimit;
        private System.Windows.Forms.TextBox TxtDeadline;
        private System.Windows.Forms.TextBox TxtMembership;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
    }
}