namespace OpenLibrary.Prenstation
{
    partial class frmChuyenNganh
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
            this.components = new System.ComponentModel.Container();
            this.dgvChuyenNganh = new System.Windows.Forms.DataGridView();
            this.maCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPENLIBRARYDataSet = new OpenLibrary.Prenstation.OPENLIBRARYDataSet();
            this.txtChuyenNganh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cHUYENNGANHTableAdapter = new OpenLibrary.Prenstation.OPENLIBRARYDataSetTableAdapters.CHUYENNGANHTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPENLIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChuyenNganh
            // 
            this.dgvChuyenNganh.AutoGenerateColumns = false;
            this.dgvChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCNDataGridViewTextBoxColumn,
            this.tenCNDataGridViewTextBoxColumn});
            this.dgvChuyenNganh.DataSource = this.cHUYENNGANHBindingSource;
            this.dgvChuyenNganh.Location = new System.Drawing.Point(18, 138);
            this.dgvChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChuyenNganh.Name = "dgvChuyenNganh";
            this.dgvChuyenNganh.RowHeadersWidth = 62;
            this.dgvChuyenNganh.RowTemplate.Height = 28;
            this.dgvChuyenNganh.Size = new System.Drawing.Size(1039, 348);
            this.dgvChuyenNganh.TabIndex = 13;
            this.dgvChuyenNganh.SelectionChanged += new System.EventHandler(this.dgvChuyenNganh_SelectionChanged);
            // 
            // maCNDataGridViewTextBoxColumn
            // 
            this.maCNDataGridViewTextBoxColumn.DataPropertyName = "MaCN";
            this.maCNDataGridViewTextBoxColumn.HeaderText = "MaCN";
            this.maCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCNDataGridViewTextBoxColumn.Name = "maCNDataGridViewTextBoxColumn";
            this.maCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.maCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenCNDataGridViewTextBoxColumn
            // 
            this.tenCNDataGridViewTextBoxColumn.DataPropertyName = "TenCN";
            this.tenCNDataGridViewTextBoxColumn.HeaderText = "TenCN";
            this.tenCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenCNDataGridViewTextBoxColumn.Name = "tenCNDataGridViewTextBoxColumn";
            this.tenCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataMember = "CHUYENNGANH";
            this.cHUYENNGANHBindingSource.DataSource = this.oPENLIBRARYDataSet;
            // 
            // oPENLIBRARYDataSet
            // 
            this.oPENLIBRARYDataSet.DataSetName = "OPENLIBRARYDataSet";
            this.oPENLIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.Location = new System.Drawing.Point(215, 22);
            this.txtChuyenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.Size = new System.Drawing.Size(337, 22);
            this.txtChuyenNganh.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chuyên ngành:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(635, 71);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(222, 63);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(347, 71);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(222, 63);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(47, 71);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(222, 63);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cHUYENNGANHTableAdapter
            // 
            this.cHUYENNGANHTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 497);
            this.Controls.Add(this.dgvChuyenNganh);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Name = "frmChuyenNganh";
            this.Text = "frmChuyenNganh";
            this.Load += new System.EventHandler(this.frmChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPENLIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChuyenNganh;
        private System.Windows.Forms.TextBox txtChuyenNganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private OPENLIBRARYDataSet oPENLIBRARYDataSet;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private OPENLIBRARYDataSetTableAdapters.CHUYENNGANHTableAdapter cHUYENNGANHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}