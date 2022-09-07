namespace YatırBank
{
    partial class TemsilciMüsteriIslemleri
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
            this.bankaDataSet3 = new YatırBank.BankaDataSet3();
            this.tBLMUSTERIBILGILERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_MUSTERI_BILGILERITableAdapter = new YatırBank.BankaDataSet3TableAdapters.TBL_MUSTERI_BILGILERITableAdapter();
            this.mUSTERINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISIFREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISOYADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIYASIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIPARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sifre_textBox = new System.Windows.Forms.TextBox();
            this.ad_textBox = new System.Windows.Forms.TextBox();
            this.soyad_textBox = new System.Windows.Forms.TextBox();
            this.yas_textBox = new System.Windows.Forms.TextBox();
            this.tc_textBox = new System.Windows.Forms.TextBox();
            this.bakiye_textBox = new System.Windows.Forms.TextBox();
            this.para_textBox = new System.Windows.Forms.TextBox();
            this.adres_richTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERIBILGILERIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mUSTERINODataGridViewTextBoxColumn,
            this.mUSTERISIFREDataGridViewTextBoxColumn,
            this.mUSTERIADIDataGridViewTextBoxColumn,
            this.mUSTERISOYADIDataGridViewTextBoxColumn,
            this.mUSTERIYASIDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn,
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn,
            this.mUSTERIPARADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMUSTERIBILGILERIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bankaDataSet3
            // 
            this.bankaDataSet3.DataSetName = "BankaDataSet3";
            this.bankaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMUSTERIBILGILERIBindingSource
            // 
            this.tBLMUSTERIBILGILERIBindingSource.DataMember = "TBL_MUSTERI_BILGILERI";
            this.tBLMUSTERIBILGILERIBindingSource.DataSource = this.bankaDataSet3;
            // 
            // tBL_MUSTERI_BILGILERITableAdapter
            // 
            this.tBL_MUSTERI_BILGILERITableAdapter.ClearBeforeFill = true;
            // 
            // mUSTERINODataGridViewTextBoxColumn
            // 
            this.mUSTERINODataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_NO";
            this.mUSTERINODataGridViewTextBoxColumn.HeaderText = "MUSTERI_NO";
            this.mUSTERINODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERINODataGridViewTextBoxColumn.Name = "mUSTERINODataGridViewTextBoxColumn";
            this.mUSTERINODataGridViewTextBoxColumn.ReadOnly = true;
            this.mUSTERINODataGridViewTextBoxColumn.Width = 125;
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
            // mUSTERIYASIDataGridViewTextBoxColumn
            // 
            this.mUSTERIYASIDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_YASI";
            this.mUSTERIYASIDataGridViewTextBoxColumn.HeaderText = "MUSTERI_YASI";
            this.mUSTERIYASIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIYASIDataGridViewTextBoxColumn.Name = "mUSTERIYASIDataGridViewTextBoxColumn";
            this.mUSTERIYASIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TC_NO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "TC_NO";
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
            // mUSTERIBAKIYEDataGridViewTextBoxColumn
            // 
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_BAKIYE";
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn.HeaderText = "MUSTERI_BAKIYE";
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn.Name = "mUSTERIBAKIYEDataGridViewTextBoxColumn";
            this.mUSTERIBAKIYEDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERIPARADataGridViewTextBoxColumn
            // 
            this.mUSTERIPARADataGridViewTextBoxColumn.DataPropertyName = "MUSTERI_PARA";
            this.mUSTERIPARADataGridViewTextBoxColumn.HeaderText = "MUSTERI_PARA";
            this.mUSTERIPARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIPARADataGridViewTextBoxColumn.Name = "mUSTERIPARADataGridViewTextBoxColumn";
            this.mUSTERIPARADataGridViewTextBoxColumn.Width = 125;
            // 
            // NoLabel
            // 
            this.NoLabel.AutoSize = true;
            this.NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoLabel.Location = new System.Drawing.Point(13, 487);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(0, 22);
            this.NoLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Musteri Sifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Musteri Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Musteri Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(294, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Musteri Yası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(294, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Musteri TC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(294, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adresi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(477, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Musteri Bakiyesi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(696, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Musteri Para Birimi :";
            // 
            // Sifre_textBox
            // 
            this.Sifre_textBox.Location = new System.Drawing.Point(139, 539);
            this.Sifre_textBox.Name = "Sifre_textBox";
            this.Sifre_textBox.Size = new System.Drawing.Size(149, 22);
            this.Sifre_textBox.TabIndex = 10;
            // 
            // ad_textBox
            // 
            this.ad_textBox.Location = new System.Drawing.Point(139, 589);
            this.ad_textBox.Name = "ad_textBox";
            this.ad_textBox.Size = new System.Drawing.Size(149, 22);
            this.ad_textBox.TabIndex = 11;
            // 
            // soyad_textBox
            // 
            this.soyad_textBox.Location = new System.Drawing.Point(17, 660);
            this.soyad_textBox.Name = "soyad_textBox";
            this.soyad_textBox.Size = new System.Drawing.Size(271, 22);
            this.soyad_textBox.TabIndex = 12;
            // 
            // yas_textBox
            // 
            this.yas_textBox.Location = new System.Drawing.Point(418, 537);
            this.yas_textBox.Name = "yas_textBox";
            this.yas_textBox.Size = new System.Drawing.Size(53, 22);
            this.yas_textBox.TabIndex = 13;
            // 
            // tc_textBox
            // 
            this.tc_textBox.Location = new System.Drawing.Point(418, 589);
            this.tc_textBox.Name = "tc_textBox";
            this.tc_textBox.Size = new System.Drawing.Size(190, 22);
            this.tc_textBox.TabIndex = 14;
            // 
            // bakiye_textBox
            // 
            this.bakiye_textBox.Location = new System.Drawing.Point(623, 541);
            this.bakiye_textBox.Name = "bakiye_textBox";
            this.bakiye_textBox.Size = new System.Drawing.Size(67, 22);
            this.bakiye_textBox.TabIndex = 15;
            // 
            // para_textBox
            // 
            this.para_textBox.Location = new System.Drawing.Point(872, 541);
            this.para_textBox.Name = "para_textBox";
            this.para_textBox.Size = new System.Drawing.Size(99, 22);
            this.para_textBox.TabIndex = 16;
            // 
            // adres_richTextBox
            // 
            this.adres_richTextBox.Location = new System.Drawing.Point(371, 637);
            this.adres_richTextBox.Name = "adres_richTextBox";
            this.adres_richTextBox.Size = new System.Drawing.Size(237, 83);
            this.adres_richTextBox.TabIndex = 17;
            this.adres_richTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 18;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 70);
            this.button2.TabIndex = 19;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(632, 660);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 70);
            this.button3.TabIndex = 20;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TemsilciMüsteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 732);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adres_richTextBox);
            this.Controls.Add(this.para_textBox);
            this.Controls.Add(this.bakiye_textBox);
            this.Controls.Add(this.tc_textBox);
            this.Controls.Add(this.yas_textBox);
            this.Controls.Add(this.soyad_textBox);
            this.Controls.Add(this.ad_textBox);
            this.Controls.Add(this.Sifre_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TemsilciMüsteriIslemleri";
            this.Text = "TemsilciMüsteriIslemleri";
            this.Load += new System.EventHandler(this.TemsilciMüsteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERIBILGILERIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaDataSet3 bankaDataSet3;
        private System.Windows.Forms.BindingSource tBLMUSTERIBILGILERIBindingSource;
        private BankaDataSet3TableAdapters.TBL_MUSTERI_BILGILERITableAdapter tBL_MUSTERI_BILGILERITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISIFREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIYASIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIBAKIYEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIPARADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label NoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Sifre_textBox;
        private System.Windows.Forms.TextBox ad_textBox;
        private System.Windows.Forms.TextBox soyad_textBox;
        private System.Windows.Forms.TextBox yas_textBox;
        private System.Windows.Forms.TextBox tc_textBox;
        private System.Windows.Forms.TextBox bakiye_textBox;
        private System.Windows.Forms.TextBox para_textBox;
        private System.Windows.Forms.RichTextBox adres_richTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}