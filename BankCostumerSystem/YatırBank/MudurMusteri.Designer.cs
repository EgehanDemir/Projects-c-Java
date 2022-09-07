namespace YatırBank
{
    partial class MudurMusteri
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
            this.tBLMUSTERIMUDURBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankaDataSet5 = new YatırBank.BankaDataSet5();
            this.tBLMUSTERIMUDURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaDataSet1 = new YatırBank.BankaDataSet1();
            this.tBL_MUSTERI_MUDURTableAdapter = new YatırBank.BankaDataSet1TableAdapters.TBL_MUSTERI_MUDURTableAdapter();
            this.ID_LABEL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.RichTextBox();
            this.sifre_textBox = new System.Windows.Forms.TextBox();
            this.adi_textBox = new System.Windows.Forms.TextBox();
            this.soyadi_textBox = new System.Windows.Forms.TextBox();
            this.yas_textBox = new System.Windows.Forms.TextBox();
            this.tc_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.temsilcino_textBox = new System.Windows.Forms.ComboBox();
            this.tBL_MUSTERI_MUDURTableAdapter1 = new YatırBank.BankaDataSet5TableAdapters.TBL_MUSTERI_MUDURTableAdapter();
            this.nODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISIFREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISOYADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yASIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERIMUDURBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERIMUDURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nODataGridViewTextBoxColumn,
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn,
            this.mUSTERISIFREDataGridViewTextBoxColumn,
            this.mUSTERIADIDataGridViewTextBoxColumn,
            this.mUSTERISOYADIDataGridViewTextBoxColumn,
            this.yASIDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMUSTERIMUDURBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 435);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tBLMUSTERIMUDURBindingSource1
            // 
            this.tBLMUSTERIMUDURBindingSource1.DataMember = "TBL_MUSTERI_MUDUR";
            this.tBLMUSTERIMUDURBindingSource1.DataSource = this.bankaDataSet5;
            // 
            // bankaDataSet5
            // 
            this.bankaDataSet5.DataSetName = "BankaDataSet5";
            this.bankaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMUSTERIMUDURBindingSource
            // 
            this.tBLMUSTERIMUDURBindingSource.DataMember = "TBL_MUSTERI_MUDUR";
            this.tBLMUSTERIMUDURBindingSource.DataSource = this.bankaDataSet1;
            // 
            // bankaDataSet1
            // 
            this.bankaDataSet1.DataSetName = "BankaDataSet1";
            this.bankaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_MUSTERI_MUDURTableAdapter
            // 
            this.tBL_MUSTERI_MUDURTableAdapter.ClearBeforeFill = true;
            // 
            // ID_LABEL
            // 
            this.ID_LABEL.AutoSize = true;
            this.ID_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_LABEL.Location = new System.Drawing.Point(36, 482);
            this.ID_LABEL.Name = "ID_LABEL";
            this.ID_LABEL.Size = new System.Drawing.Size(34, 22);
            this.ID_LABEL.TabIndex = 1;
            this.ID_LABEL.Text = "ıd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temsilci Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Musteri Sıfre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Musteri Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Musteri Soyadı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(386, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Musteri Yaşı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(386, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Musteri TC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(386, 565);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Musteri Adresi :";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(390, 591);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(320, 96);
            this.adresTextBox.TabIndex = 10;
            this.adresTextBox.Text = "";
            // 
            // sifre_textBox
            // 
            this.sifre_textBox.Location = new System.Drawing.Point(149, 567);
            this.sifre_textBox.Name = "sifre_textBox";
            this.sifre_textBox.Size = new System.Drawing.Size(231, 22);
            this.sifre_textBox.TabIndex = 13;
            // 
            // adi_textBox
            // 
            this.adi_textBox.Location = new System.Drawing.Point(149, 609);
            this.adi_textBox.Name = "adi_textBox";
            this.adi_textBox.Size = new System.Drawing.Size(231, 22);
            this.adi_textBox.TabIndex = 14;
            // 
            // soyadi_textBox
            // 
            this.soyadi_textBox.Location = new System.Drawing.Point(153, 650);
            this.soyadi_textBox.Name = "soyadi_textBox";
            this.soyadi_textBox.Size = new System.Drawing.Size(231, 22);
            this.soyadi_textBox.TabIndex = 15;
            // 
            // yas_textBox
            // 
            this.yas_textBox.Location = new System.Drawing.Point(510, 482);
            this.yas_textBox.Name = "yas_textBox";
            this.yas_textBox.Size = new System.Drawing.Size(200, 22);
            this.yas_textBox.TabIndex = 16;
            // 
            // tc_textBox
            // 
            this.tc_textBox.Location = new System.Drawing.Point(510, 521);
            this.tc_textBox.Name = "tc_textBox";
            this.tc_textBox.Size = new System.Drawing.Size(200, 22);
            this.tc_textBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 78);
            this.button1.TabIndex = 18;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(911, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 78);
            this.button2.TabIndex = 19;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(751, 591);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 78);
            this.button3.TabIndex = 20;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // temsilcino_textBox
            // 
            this.temsilcino_textBox.FormattingEnabled = true;
            this.temsilcino_textBox.Location = new System.Drawing.Point(149, 523);
            this.temsilcino_textBox.Name = "temsilcino_textBox";
            this.temsilcino_textBox.Size = new System.Drawing.Size(227, 24);
            this.temsilcino_textBox.TabIndex = 21;
            // 
            // tBL_MUSTERI_MUDURTableAdapter1
            // 
            this.tBL_MUSTERI_MUDURTableAdapter1.ClearBeforeFill = true;
            // 
            // nODataGridViewTextBoxColumn
            // 
            this.nODataGridViewTextBoxColumn.DataPropertyName = "NO";
            this.nODataGridViewTextBoxColumn.HeaderText = "NO";
            this.nODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nODataGridViewTextBoxColumn.Name = "nODataGridViewTextBoxColumn";
            this.nODataGridViewTextBoxColumn.ReadOnly = true;
            this.nODataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERITEMSILCISINODataGridViewTextBoxColumn
            // 
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_TEMSILCISI_NO";
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn.HeaderText = "MUSTERI_TEMSILCISI_NO";
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn.Name = "mUSTERITEMSILCISINODataGridViewTextBoxColumn";
            this.mUSTERITEMSILCISINODataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERISIFREDataGridViewTextBoxColumn
            // 
            this.mUSTERISIFREDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_SIFRE";
            this.mUSTERISIFREDataGridViewTextBoxColumn.HeaderText = "MUSTERI_SIFRE";
            this.mUSTERISIFREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERISIFREDataGridViewTextBoxColumn.Name = "mUSTERISIFREDataGridViewTextBoxColumn";
            this.mUSTERISIFREDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERIADIDataGridViewTextBoxColumn
            // 
            this.mUSTERIADIDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_ADI";
            this.mUSTERIADIDataGridViewTextBoxColumn.HeaderText = "MUSTERI_ADI";
            this.mUSTERIADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIADIDataGridViewTextBoxColumn.Name = "mUSTERIADIDataGridViewTextBoxColumn";
            this.mUSTERIADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERISOYADIDataGridViewTextBoxColumn
            // 
            this.mUSTERISOYADIDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_SOYADI";
            this.mUSTERISOYADIDataGridViewTextBoxColumn.HeaderText = "MUSTERI_SOYADI";
            this.mUSTERISOYADIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERISOYADIDataGridViewTextBoxColumn.Name = "mUSTERISOYADIDataGridViewTextBoxColumn";
            this.mUSTERISOYADIDataGridViewTextBoxColumn.Width = 125;
            // 
            // yASIDataGridViewTextBoxColumn
            // 
            this.yASIDataGridViewTextBoxColumn.DataPropertyName = "YASI";
            this.yASIDataGridViewTextBoxColumn.HeaderText = "YASI";
            this.yASIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yASIDataGridViewTextBoxColumn.Name = "yASIDataGridViewTextBoxColumn";
            this.yASIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TCNO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "TCNO";
            this.tCNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
            this.tCNODataGridViewTextBoxColumn.Width = 125;
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            this.aDRESDataGridViewTextBoxColumn.Width = 125;
            // 
            // MudurMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 693);
            this.Controls.Add(this.temsilcino_textBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tc_textBox);
            this.Controls.Add(this.yas_textBox);
            this.Controls.Add(this.soyadi_textBox);
            this.Controls.Add(this.adi_textBox);
            this.Controls.Add(this.sifre_textBox);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_LABEL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MudurMusteri";
            this.Text = "MudurMusteri";
            this.Load += new System.EventHandler(this.MudurMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERIMUDURBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERIMUDURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaDataSet1 bankaDataSet1;
        private System.Windows.Forms.BindingSource tBLMUSTERIMUDURBindingSource;
        private BankaDataSet1TableAdapters.TBL_MUSTERI_MUDURTableAdapter tBL_MUSTERI_MUDURTableAdapter;
        private System.Windows.Forms.Label ID_LABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox adresTextBox;
        private System.Windows.Forms.TextBox sifre_textBox;
        private System.Windows.Forms.TextBox adi_textBox;
        private System.Windows.Forms.TextBox soyadi_textBox;
        private System.Windows.Forms.TextBox yas_textBox;
        private System.Windows.Forms.TextBox tc_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox temsilcino_textBox;
        private BankaDataSet5 bankaDataSet5;
        private System.Windows.Forms.BindingSource tBLMUSTERIMUDURBindingSource1;
        private BankaDataSet5TableAdapters.TBL_MUSTERI_MUDURTableAdapter tBL_MUSTERI_MUDURTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERITEMSILCISINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISIFREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yASIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
    }
}