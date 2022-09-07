namespace YatırBank
{
    partial class MudurTemsilciİslemleri
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
            this.bankaDataSet8 = new YatırBank.BankaDataSet8();
            this.tBLTEMSILCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_TEMSILCITableAdapter = new YatırBank.BankaDataSet8TableAdapters.TBL_TEMSILCITableAdapter();
            this.tEMSILCINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMSILCISIFREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMSILCIADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISAYISIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sayilabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTEMSILCIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tEMSILCINODataGridViewTextBoxColumn,
            this.tEMSILCISIFREDataGridViewTextBoxColumn,
            this.tEMSILCIADIDataGridViewTextBoxColumn,
            this.mUSTERISAYISIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLTEMSILCIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bankaDataSet8
            // 
            this.bankaDataSet8.DataSetName = "BankaDataSet8";
            this.bankaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLTEMSILCIBindingSource
            // 
            this.tBLTEMSILCIBindingSource.DataMember = "TBL_TEMSILCI";
            this.tBLTEMSILCIBindingSource.DataSource = this.bankaDataSet8;
            // 
            // tBL_TEMSILCITableAdapter
            // 
            this.tBL_TEMSILCITableAdapter.ClearBeforeFill = true;
            // 
            // tEMSILCINODataGridViewTextBoxColumn
            // 
            this.tEMSILCINODataGridViewTextBoxColumn.DataPropertyName = "TEMSILCI_NO";
            this.tEMSILCINODataGridViewTextBoxColumn.HeaderText = "TEMSILCI_NO";
            this.tEMSILCINODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tEMSILCINODataGridViewTextBoxColumn.Name = "tEMSILCINODataGridViewTextBoxColumn";
            this.tEMSILCINODataGridViewTextBoxColumn.ReadOnly = true;
            this.tEMSILCINODataGridViewTextBoxColumn.Width = 125;
            // 
            // tEMSILCISIFREDataGridViewTextBoxColumn
            // 
            this.tEMSILCISIFREDataGridViewTextBoxColumn.DataPropertyName = "TEMSILCI_SIFRE";
            this.tEMSILCISIFREDataGridViewTextBoxColumn.HeaderText = "TEMSILCI_SIFRE";
            this.tEMSILCISIFREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tEMSILCISIFREDataGridViewTextBoxColumn.Name = "tEMSILCISIFREDataGridViewTextBoxColumn";
            this.tEMSILCISIFREDataGridViewTextBoxColumn.Width = 125;
            // 
            // tEMSILCIADIDataGridViewTextBoxColumn
            // 
            this.tEMSILCIADIDataGridViewTextBoxColumn.DataPropertyName = "TEMSILCI_ADI";
            this.tEMSILCIADIDataGridViewTextBoxColumn.HeaderText = "TEMSILCI_ADI";
            this.tEMSILCIADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tEMSILCIADIDataGridViewTextBoxColumn.Name = "tEMSILCIADIDataGridViewTextBoxColumn";
            this.tEMSILCIADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERISAYISIDataGridViewTextBoxColumn
            // 
            this.mUSTERISAYISIDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_SAYISI";
            this.mUSTERISAYISIDataGridViewTextBoxColumn.HeaderText = "MUSTERI_SAYISI";
            this.mUSTERISAYISIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERISAYISIDataGridViewTextBoxColumn.Name = "mUSTERISAYISIDataGridViewTextBoxColumn";
            this.mUSTERISAYISIDataGridViewTextBoxColumn.Width = 125;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDlabel.Location = new System.Drawing.Point(602, 32);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(58, 22);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(602, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temsilci Sifre :";
            // 
            // sifretextBox
            // 
            this.sifretextBox.Location = new System.Drawing.Point(737, 75);
            this.sifretextBox.Name = "sifretextBox";
            this.sifretextBox.Size = new System.Drawing.Size(136, 22);
            this.sifretextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(602, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temsilci Adı :";
            // 
            // ad_textBox
            // 
            this.ad_textBox.Location = new System.Drawing.Point(737, 122);
            this.ad_textBox.Name = "ad_textBox";
            this.ad_textBox.Size = new System.Drawing.Size(136, 22);
            this.ad_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(602, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri Sayısı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "GUNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "SIL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sayilabel
            // 
            this.sayilabel.AutoSize = true;
            this.sayilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayilabel.Location = new System.Drawing.Point(739, 163);
            this.sayilabel.Name = "sayilabel";
            this.sayilabel.Size = new System.Drawing.Size(0, 22);
            this.sayilabel.TabIndex = 11;
            // 
            // MudurTemsilciİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 357);
            this.Controls.Add(this.sayilabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ad_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifretextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MudurTemsilciİslemleri";
            this.Text = "MudurTemsilciİslemleri";
            this.Load += new System.EventHandler(this.MudurTemsilciİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTEMSILCIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaDataSet8 bankaDataSet8;
        private System.Windows.Forms.BindingSource tBLTEMSILCIBindingSource;
        private BankaDataSet8TableAdapters.TBL_TEMSILCITableAdapter tBL_TEMSILCITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMSILCINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMSILCISIFREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMSILCIADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISAYISIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ad_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label sayilabel;
    }
}