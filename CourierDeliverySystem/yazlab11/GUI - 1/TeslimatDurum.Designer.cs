
namespace yazlab11
{
    partial class TeslimatDurum
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
            this.label3 = new System.Windows.Forms.Label();
            this.Kargoturu_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Kargoadi_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KargoID_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoTuru_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoEnlem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoBoylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRO_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kargodurum_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teslimatAdres_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boylam_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enlem_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kargoID_textBox = new System.Windows.Forms.TextBox();
            this.KargoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Kargo türü :";
            // 
            // Kargoturu_textBox
            // 
            this.Kargoturu_textBox.Location = new System.Drawing.Point(6, 121);
            this.Kargoturu_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kargoturu_textBox.Name = "Kargoturu_textBox";
            this.Kargoturu_textBox.Size = new System.Drawing.Size(176, 23);
            this.Kargoturu_textBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Kargo Adı :";
            // 
            // Kargoadi_textBox
            // 
            this.Kargoadi_textBox.Location = new System.Drawing.Point(6, 78);
            this.Kargoadi_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kargoadi_textBox.Name = "Kargoadi_textBox";
            this.Kargoadi_textBox.Size = new System.Drawing.Size(176, 23);
            this.Kargoadi_textBox.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KargoID_column,
            this.KargoAd,
            this.KargoTuru_column,
            this.dataGridViewTextBoxColumn2,
            this.KargoAdres,
            this.KargoEnlem,
            this.KargoBoylam});
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(676, 357);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // KargoID_column
            // 
            this.KargoID_column.HeaderText = "Kargo ID";
            this.KargoID_column.Name = "KargoID_column";
            // 
            // KargoAd
            // 
            this.KargoAd.HeaderText = "Kargo Adi";
            this.KargoAd.Name = "KargoAd";
            // 
            // KargoTuru_column
            // 
            this.KargoTuru_column.HeaderText = "KargoTuru";
            this.KargoTuru_column.Name = "KargoTuru_column";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Kargo Durum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // KargoAdres
            // 
            this.KargoAdres.HeaderText = "Kargo Adres";
            this.KargoAdres.Name = "KargoAdres";
            // 
            // KargoEnlem
            // 
            this.KargoEnlem.HeaderText = "Kargo Enlem";
            this.KargoEnlem.Name = "KargoEnlem";
            // 
            // KargoBoylam
            // 
            this.KargoBoylam.HeaderText = "Kargo Boylam";
            this.KargoBoylam.Name = "KargoBoylam";
            // 
            // TRO_button
            // 
            this.TRO_button.Location = new System.Drawing.Point(10, 384);
            this.TRO_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TRO_button.Name = "TRO_button";
            this.TRO_button.Size = new System.Drawing.Size(146, 29);
            this.TRO_button.TabIndex = 32;
            this.TRO_button.Text = "Teslimat Rotası Oluştur";
            this.TRO_button.UseVisualStyleBackColor = true;
            this.TRO_button.Click += new System.EventHandler(this.TRO_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kargo ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kargo Durum :";
            // 
            // kargodurum_comboBox
            // 
            this.kargodurum_comboBox.FormattingEnabled = true;
            this.kargodurum_comboBox.Items.AddRange(new object[] {
            "Teslim Edildi",
            "Teslim Edilmedi"});
            this.kargodurum_comboBox.Location = new System.Drawing.Point(6, 165);
            this.kargodurum_comboBox.Name = "kargodurum_comboBox";
            this.kargodurum_comboBox.Size = new System.Drawing.Size(176, 23);
            this.kargodurum_comboBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Teslimat Adresi:";
            // 
            // teslimatAdres_textBox
            // 
            this.teslimatAdres_textBox.Location = new System.Drawing.Point(6, 36);
            this.teslimatAdres_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teslimatAdres_textBox.Multiline = true;
            this.teslimatAdres_textBox.Name = "teslimatAdres_textBox";
            this.teslimatAdres_textBox.ReadOnly = true;
            this.teslimatAdres_textBox.Size = new System.Drawing.Size(176, 68);
            this.teslimatAdres_textBox.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 31);
            this.button1.TabIndex = 41;
            this.button1.Text = "Adresi Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(350, 382);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 31);
            this.button4.TabIndex = 44;
            this.button4.Text = "Kargo Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 45;
            this.button2.Text = "Kargo Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 382);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 31);
            this.button3.TabIndex = 46;
            this.button3.Text = "Kargo Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boylam_textbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.enlem_textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.teslimatAdres_textBox);
            this.groupBox1.Location = new System.Drawing.Point(692, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 202);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Bilgisi";
            // 
            // boylam_textbox
            // 
            this.boylam_textbox.Location = new System.Drawing.Point(98, 125);
            this.boylam_textbox.Name = "boylam_textbox";
            this.boylam_textbox.ReadOnly = true;
            this.boylam_textbox.Size = new System.Drawing.Size(84, 23);
            this.boylam_textbox.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Boylam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Enlem:";
            // 
            // enlem_textbox
            // 
            this.enlem_textbox.Location = new System.Drawing.Point(6, 125);
            this.enlem_textbox.Name = "enlem_textbox";
            this.enlem_textbox.ReadOnly = true;
            this.enlem_textbox.Size = new System.Drawing.Size(84, 23);
            this.enlem_textbox.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kargoID_textBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Kargoturu_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Kargoadi_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.kargodurum_comboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(692, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 202);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres Bilgisi";
            // 
            // kargoID_textBox
            // 
            this.kargoID_textBox.Location = new System.Drawing.Point(6, 36);
            this.kargoID_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kargoID_textBox.Name = "kargoID_textBox";
            this.kargoID_textBox.Size = new System.Drawing.Size(176, 23);
            this.kargoID_textBox.TabIndex = 39;
            // 
            // KargoID
            // 
            this.KargoID.HeaderText = "KargoID";
            this.KargoID.MinimumWidth = 6;
            this.KargoID.Name = "KargoID";
            this.KargoID.Width = 125;
            // 
            // KargoAdi
            // 
            this.KargoAdi.HeaderText = "Kargo Adi";
            this.KargoAdi.MinimumWidth = 6;
            this.KargoAdi.Name = "KargoAdi";
            this.KargoAdi.Width = 125;
            // 
            // KargoTuru
            // 
            this.KargoTuru.HeaderText = "Kargo Türü";
            this.KargoTuru.MinimumWidth = 6;
            this.KargoTuru.Name = "KargoTuru";
            this.KargoTuru.Width = 125;
            // 
            // KargoDurum
            // 
            this.KargoDurum.HeaderText = "Kargo Durumu";
            this.KargoDurum.MinimumWidth = 6;
            this.KargoDurum.Name = "KargoDurum";
            this.KargoDurum.Width = 125;
            // 
            // TeslimatDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TRO_button);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeslimatDurum";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TeslimatDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kargoturu_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Kargoadi_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TRO_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kargodurum_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teslimatAdres_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kargoID_textBox;
        private System.Windows.Forms.TextBox boylam_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enlem_textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoID_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoTuru_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoEnlem;
        private System.Windows.Forms.DataGridViewTextBoxColumn KargoBoylam;
    }
}