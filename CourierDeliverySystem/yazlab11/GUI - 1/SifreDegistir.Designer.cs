
namespace yazlab11
{
    partial class SifreDegistir
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
            this.kullanici_textbox = new System.Windows.Forms.TextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.sifretekrar_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mail_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanici_textbox
            // 
            this.kullanici_textbox.Location = new System.Drawing.Point(102, 15);
            this.kullanici_textbox.Name = "kullanici_textbox";
            this.kullanici_textbox.Size = new System.Drawing.Size(210, 27);
            this.kullanici_textbox.TabIndex = 1;
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(103, 112);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(210, 27);
            this.sifre_textbox.TabIndex = 3;
            this.sifre_textbox.TextChanged += new System.EventHandler(this.sifre_textbox_TextChanged);
            // 
            // sifretekrar_textbox
            // 
            this.sifretekrar_textbox.Location = new System.Drawing.Point(103, 169);
            this.sifretekrar_textbox.Name = "sifretekrar_textbox";
            this.sifretekrar_textbox.Size = new System.Drawing.Size(210, 27);
            this.sifretekrar_textbox.TabIndex = 4;
            this.sifretekrar_textbox.TextChanged += new System.EventHandler(this.sifretekrar_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sifre :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre Tekrar :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mail :";
            // 
            // Mail_textBox
            // 
            this.Mail_textBox.Location = new System.Drawing.Point(102, 67);
            this.Mail_textBox.Name = "Mail_textBox";
            this.Mail_textBox.Size = new System.Drawing.Size(210, 27);
            this.Mail_textBox.TabIndex = 2;
            // 
            // SifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mail_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifretekrar_textbox);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.kullanici_textbox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistir";
            this.Text = "SıfreDegistir";
            this.Load += new System.EventHandler(this.SifreDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kullanici_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox sifretekrar_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mail_textBox;
    }
}