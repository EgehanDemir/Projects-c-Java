namespace YatırBank
{
    partial class MüşteriFormu
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
            this.button3 = new System.Windows.Forms.Button();
            this.kredi_textBox = new System.Windows.Forms.TextBox();
            this.ay_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bakiyelabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bakiyetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.miktar_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hesapIDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bilgi Görüntüleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hesap İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kredi Talep Etme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kredi_textBox
            // 
            this.kredi_textBox.Location = new System.Drawing.Point(197, 21);
            this.kredi_textBox.Name = "kredi_textBox";
            this.kredi_textBox.Size = new System.Drawing.Size(103, 22);
            this.kredi_textBox.TabIndex = 3;
            // 
            // ay_textBox
            // 
            this.ay_textBox.Location = new System.Drawing.Point(197, 72);
            this.ay_textBox.Name = "ay_textBox";
            this.ay_textBox.Size = new System.Drawing.Size(103, 22);
            this.ay_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ay :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mıktar :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Borçlar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ay_textBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kredi_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KREDİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.bakiyelabel);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.bakiyetextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 121);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakiye";
            // 
            // bakiyelabel
            // 
            this.bakiyelabel.AutoSize = true;
            this.bakiyelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyelabel.Location = new System.Drawing.Point(17, 35);
            this.bakiyelabel.Name = "bakiyelabel";
            this.bakiyelabel.Size = new System.Drawing.Size(58, 22);
            this.bakiyelabel.TabIndex = 12;
            this.bakiyelabel.Text = "label4";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "Para Çek";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bakiyetextBox
            // 
            this.bakiyetextBox.Location = new System.Drawing.Point(21, 72);
            this.bakiyetextBox.Name = "bakiyetextBox";
            this.bakiyetextBox.Size = new System.Drawing.Size(127, 22);
            this.bakiyetextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.miktar_textBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.hesapIDtextBox);
            this.groupBox3.Location = new System.Drawing.Point(14, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 139);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Para Gönder";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(271, 40);
            this.button6.TabIndex = 13;
            this.button6.Text = "Gönder";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gönderilecek Miktar :";
            // 
            // miktar_textBox
            // 
            this.miktar_textBox.Location = new System.Drawing.Point(165, 55);
            this.miktar_textBox.Name = "miktar_textBox";
            this.miktar_textBox.Size = new System.Drawing.Size(130, 22);
            this.miktar_textBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gönderilecek Hesap :";
            // 
            // hesapIDtextBox
            // 
            this.hesapIDtextBox.Location = new System.Drawing.Point(165, 27);
            this.hesapIDtextBox.Name = "hesapIDtextBox";
            this.hesapIDtextBox.Size = new System.Drawing.Size(130, 22);
            this.hesapIDtextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(25, 601);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 74);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Borç İşlemleri";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(176, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 40);
            this.button7.TabIndex = 14;
            this.button7.Text = "Para Yatır";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MüşteriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 721);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MüşteriFormu";
            this.Text = "MüşteriFormu";
            this.Load += new System.EventHandler(this.MüşteriFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox kredi_textBox;
        private System.Windows.Forms.TextBox ay_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label bakiyelabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox bakiyetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox miktar_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hesapIDtextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
    }
}