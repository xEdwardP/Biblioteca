namespace Biblioteca.Forms.Loans
{
    partial class FrmSearchMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchMember));
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbFiltroSearch = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RbCode = new System.Windows.Forms.RadioButton();
            this.RbName = new System.Windows.Forms.RadioButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.GbFiltroSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(824, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(794, 88);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 77;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSearch.Location = new System.Drawing.Point(391, 87);
            this.TxtSearch.MaxLength = 150;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(397, 27);
            this.TxtSearch.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "BUSCAR:";
            // 
            // GbFiltroSearch
            // 
            this.GbFiltroSearch.Controls.Add(this.radioButton1);
            this.GbFiltroSearch.Controls.Add(this.RbCode);
            this.GbFiltroSearch.Controls.Add(this.RbName);
            this.GbFiltroSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFiltroSearch.Location = new System.Drawing.Point(12, 83);
            this.GbFiltroSearch.Name = "GbFiltroSearch";
            this.GbFiltroSearch.Size = new System.Drawing.Size(295, 31);
            this.GbFiltroSearch.TabIndex = 74;
            this.GbFiltroSearch.TabStop = false;
            this.GbFiltroSearch.Text = "Buscar por:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(190, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 18);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.Text = "ESTUDIANTE";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RbCode
            // 
            this.RbCode.AutoSize = true;
            this.RbCode.Checked = true;
            this.RbCode.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbCode.Location = new System.Drawing.Point(66, 9);
            this.RbCode.Name = "RbCode";
            this.RbCode.Size = new System.Drawing.Size(67, 18);
            this.RbCode.TabIndex = 26;
            this.RbCode.TabStop = true;
            this.RbCode.Text = "CODIGO";
            this.RbCode.UseVisualStyleBackColor = true;
            // 
            // RbName
            // 
            this.RbName.AutoSize = true;
            this.RbName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbName.Location = new System.Drawing.Point(139, 9);
            this.RbName.Name = "RbName";
            this.RbName.Size = new System.Drawing.Size(45, 18);
            this.RbName.TabIndex = 25;
            this.RbName.Text = "DNI";
            this.RbName.UseVisualStyleBackColor = true;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCode,
            this.DcDocument,
            this.DcName,
            this.DcState});
            this.DgvData.Location = new System.Drawing.Point(12, 134);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(840, 203);
            this.DgvData.TabIndex = 79;
            // 
            // DcCode
            // 
            this.DcCode.HeaderText = "CODIGO";
            this.DcCode.Name = "DcCode";
            this.DcCode.ReadOnly = true;
            this.DcCode.Width = 150;
            // 
            // DcDocument
            // 
            this.DcDocument.HeaderText = "DNI";
            this.DcDocument.Name = "DcDocument";
            this.DcDocument.ReadOnly = true;
            this.DcDocument.Width = 150;
            // 
            // DcName
            // 
            this.DcName.HeaderText = "NOMBRE";
            this.DcName.Name = "DcName";
            this.DcName.ReadOnly = true;
            this.DcName.Width = 370;
            // 
            // DcState
            // 
            this.DcState.HeaderText = "ESTADO";
            this.DcState.Name = "DcState";
            this.DcState.ReadOnly = true;
            this.DcState.Width = 150;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(370, 27);
            this.label8.TabIndex = 80;
            this.label8.Text = "     MIEMBROS REGISTRADOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 31);
            this.toolStrip1.TabIndex = 89;
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
            // 
            // FrmSearchMember
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(863, 348);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GbFiltroSearch);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearchMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.GbFiltroSearch.ResumeLayout(false);
            this.GbFiltroSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GbFiltroSearch;
        private System.Windows.Forms.RadioButton RbCode;
        private System.Windows.Forms.RadioButton RbName;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcState;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnClose;
    }
}