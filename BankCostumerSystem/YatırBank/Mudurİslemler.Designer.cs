namespace YatırBank
{
    partial class Mudurİslemler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bankaDataSet7 = new YatırBank.BankaDataSet7();
            this.tBLISLEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_ISLEMTableAdapter = new YatırBank.BankaDataSet7TableAdapters.TBL_ISLEMTableAdapter();
            this.iSLEMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAYNAKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEDEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSLEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEDEFBAKIYEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLISLEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSLEMNODataGridViewTextBoxColumn,
            this.mUSTERINODataGridViewTextBoxColumn,
            this.kAYNAKDataGridViewTextBoxColumn,
            this.hEDEFDataGridViewTextBoxColumn,
            this.iSLEMDataGridViewTextBoxColumn,
            this.tUTARDataGridViewTextBoxColumn,
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn,
            this.hEDEFBAKIYEDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLISLEMBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 615);
            this.dataGridView1.TabIndex = 0;
            // 
            // bankaDataSet7
            // 
            this.bankaDataSet7.DataSetName = "BankaDataSet7";
            this.bankaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLISLEMBindingSource
            // 
            this.tBLISLEMBindingSource.DataMember = "TBL_ISLEM";
            this.tBLISLEMBindingSource.DataSource = this.bankaDataSet7;
            // 
            // tBL_ISLEMTableAdapter
            // 
            this.tBL_ISLEMTableAdapter.ClearBeforeFill = true;
            // 
            // iSLEMNODataGridViewTextBoxColumn
            // 
            this.iSLEMNODataGridViewTextBoxColumn.DataPropertyName = "ISLEMNO";
            this.iSLEMNODataGridViewTextBoxColumn.HeaderText = "ISLEMNO";
            this.iSLEMNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSLEMNODataGridViewTextBoxColumn.Name = "iSLEMNODataGridViewTextBoxColumn";
            this.iSLEMNODataGridViewTextBoxColumn.ReadOnly = true;
            this.iSLEMNODataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERINODataGridViewTextBoxColumn
            // 
            this.mUSTERINODataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_NO";
            this.mUSTERINODataGridViewTextBoxColumn.HeaderText = "MUSTERI_NO";
            this.mUSTERINODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERINODataGridViewTextBoxColumn.Name = "mUSTERINODataGridViewTextBoxColumn";
            this.mUSTERINODataGridViewTextBoxColumn.Width = 125;
            // 
            // kAYNAKDataGridViewTextBoxColumn
            // 
            this.kAYNAKDataGridViewTextBoxColumn.DataPropertyName = "KAYNAK";
            this.kAYNAKDataGridViewTextBoxColumn.HeaderText = "KAYNAK";
            this.kAYNAKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kAYNAKDataGridViewTextBoxColumn.Name = "kAYNAKDataGridViewTextBoxColumn";
            this.kAYNAKDataGridViewTextBoxColumn.Width = 125;
            // 
            // hEDEFDataGridViewTextBoxColumn
            // 
            this.hEDEFDataGridViewTextBoxColumn.DataPropertyName = "HEDEF";
            this.hEDEFDataGridViewTextBoxColumn.HeaderText = "HEDEF";
            this.hEDEFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hEDEFDataGridViewTextBoxColumn.Name = "hEDEFDataGridViewTextBoxColumn";
            this.hEDEFDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSLEMDataGridViewTextBoxColumn
            // 
            this.iSLEMDataGridViewTextBoxColumn.DataPropertyName = "ISLEM";
            this.iSLEMDataGridViewTextBoxColumn.HeaderText = "ISLEM";
            this.iSLEMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSLEMDataGridViewTextBoxColumn.Name = "iSLEMDataGridViewTextBoxColumn";
            this.iSLEMDataGridViewTextBoxColumn.Width = 125;
            // 
            // tUTARDataGridViewTextBoxColumn
            // 
            this.tUTARDataGridViewTextBoxColumn.DataPropertyName = "TUTAR";
            this.tUTARDataGridViewTextBoxColumn.HeaderText = "TUTAR";
            this.tUTARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tUTARDataGridViewTextBoxColumn.Name = "tUTARDataGridViewTextBoxColumn";
            this.tUTARDataGridViewTextBoxColumn.Width = 125;
            // 
            // kAYNAKBAKIYEDataGridViewTextBoxColumn
            // 
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn.DataPropertyName = "KAYNAKBAKIYE";
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn.HeaderText = "KAYNAKBAKIYE";
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn.Name = "kAYNAKBAKIYEDataGridViewTextBoxColumn";
            this.kAYNAKBAKIYEDataGridViewTextBoxColumn.Width = 125;
            // 
            // hEDEFBAKIYEDataGridViewTextBoxColumn
            // 
            this.hEDEFBAKIYEDataGridViewTextBoxColumn.DataPropertyName = "HEDEFBAKIYE";
            this.hEDEFBAKIYEDataGridViewTextBoxColumn.HeaderText = "HEDEFBAKIYE";
            this.hEDEFBAKIYEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hEDEFBAKIYEDataGridViewTextBoxColumn.Name = "hEDEFBAKIYEDataGridViewTextBoxColumn";
            this.hEDEFBAKIYEDataGridViewTextBoxColumn.Width = 125;
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            this.tARIHDataGridViewTextBoxColumn.Width = 125;
            // 
            // Mudurİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 615);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mudurİslemler";
            this.Text = "Mudurİslemler";
            this.Load += new System.EventHandler(this.Mudurİslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLISLEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaDataSet7 bankaDataSet7;
        private System.Windows.Forms.BindingSource tBLISLEMBindingSource;
        private BankaDataSet7TableAdapters.TBL_ISLEMTableAdapter tBL_ISLEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSLEMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAYNAKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEDEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSLEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAYNAKBAKIYEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEDEFBAKIYEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
    }
}