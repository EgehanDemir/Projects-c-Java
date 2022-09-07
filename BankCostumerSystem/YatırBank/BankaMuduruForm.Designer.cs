namespace YatırBank
{
    partial class BankaMuduruForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tarihLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.calisanmaas_textBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.faizoranı_textBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.krediGecikme_textBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Musterileri Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Para Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 2;
            // 
            // tarihLabel
            // 
            this.tarihLabel.AutoSize = true;
            this.tarihLabel.Location = new System.Drawing.Point(21, 195);
            this.tarihLabel.Name = "tarihLabel";
            this.tarihLabel.Size = new System.Drawing.Size(145, 16);
            this.tarihLabel.TabIndex = 3;
            this.tarihLabel.Text = "Mevcut Tarih yıl-ay-gun";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Onayla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "1 Ay Arttır.";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(12, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(314, 79);
            this.button5.TabIndex = 6;
            this.button5.Text = "İşlemleri Görüntüle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // calisanmaas_textBox
            // 
            this.calisanmaas_textBox.Location = new System.Drawing.Point(13, 376);
            this.calisanmaas_textBox.Name = "calisanmaas_textBox";
            this.calisanmaas_textBox.Size = new System.Drawing.Size(125, 22);
            this.calisanmaas_textBox.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(172, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 44);
            this.button6.TabIndex = 8;
            this.button6.Text = "Calısan Maas Belirle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "Kredi Faiz Oranı Belirle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // faizoranı_textBox
            // 
            this.faizoranı_textBox.Location = new System.Drawing.Point(13, 426);
            this.faizoranı_textBox.Name = "faizoranı_textBox";
            this.faizoranı_textBox.Size = new System.Drawing.Size(125, 22);
            this.faizoranı_textBox.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(172, 465);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 44);
            this.button9.TabIndex = 12;
            this.button9.Text = "Kredi Gecikme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // krediGecikme_textBox
            // 
            this.krediGecikme_textBox.Location = new System.Drawing.Point(13, 476);
            this.krediGecikme_textBox.Name = "krediGecikme_textBox";
            this.krediGecikme_textBox.Size = new System.Drawing.Size(125, 22);
            this.krediGecikme_textBox.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 527);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(314, 44);
            this.button8.TabIndex = 13;
            this.button8.Text = "Maas Öde";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(13, 124);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(314, 56);
            this.button10.TabIndex = 14;
            this.button10.Text = "Temsilci İşlemleri";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // BankaMuduruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 603);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.krediGecikme_textBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.faizoranı_textBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.calisanmaas_textBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tarihLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "BankaMuduruForm";
            this.Text = "BankaMuduruForm";
            this.Load += new System.EventHandler(this.BankaMuduruForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tarihLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox calisanmaas_textBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox faizoranı_textBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox krediGecikme_textBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
    }
}