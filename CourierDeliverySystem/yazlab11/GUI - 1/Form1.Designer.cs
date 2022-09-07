
namespace yazlab11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.giris_button = new System.Windows.Forms.Button();
            this.kayitOl_button = new System.Windows.Forms.Button();
            this.Kullanici_textBox = new System.Windows.Forms.TextBox();
            this.Sifre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre_unuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris_button
            // 
            this.giris_button.Location = new System.Drawing.Point(38, 82);
            this.giris_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(131, 39);
            this.giris_button.TabIndex = 0;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = true;
            this.giris_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayitOl_button
            // 
            this.kayitOl_button.Location = new System.Drawing.Point(173, 82);
            this.kayitOl_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayitOl_button.Name = "kayitOl_button";
            this.kayitOl_button.Size = new System.Drawing.Size(136, 39);
            this.kayitOl_button.TabIndex = 1;
            this.kayitOl_button.Text = "Kayıt";
            this.kayitOl_button.UseVisualStyleBackColor = true;
            this.kayitOl_button.Click += new System.EventHandler(this.kayitOl_button_Click);
            // 
            // Kullanici_textBox
            // 
            this.Kullanici_textBox.Location = new System.Drawing.Point(77, 14);
            this.Kullanici_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kullanici_textBox.Name = "Kullanici_textBox";
            this.Kullanici_textBox.Size = new System.Drawing.Size(232, 23);
            this.Kullanici_textBox.TabIndex = 2;
            this.Kullanici_textBox.Text = "Murat";
            // 
            // Sifre_textBox
            // 
            this.Sifre_textBox.Location = new System.Drawing.Point(77, 47);
            this.Sifre_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sifre_textBox.Name = "Sifre_textBox";
            this.Sifre_textBox.Size = new System.Drawing.Size(232, 23);
            this.Sifre_textBox.TabIndex = 3;
            this.Sifre_textBox.Text = "123456789";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "K. Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sifre_unuttum
            // 
            this.sifre_unuttum.Location = new System.Drawing.Point(38, 125);
            this.sifre_unuttum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifre_unuttum.Name = "sifre_unuttum";
            this.sifre_unuttum.Size = new System.Drawing.Size(273, 39);
            this.sifre_unuttum.TabIndex = 6;
            this.sifre_unuttum.Text = "Ben galiba şifremi unuttum...";
            this.sifre_unuttum.UseVisualStyleBackColor = true;
            this.sifre_unuttum.Click += new System.EventHandler(this.sifre_unuttum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 171);
            this.Controls.Add(this.sifre_unuttum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sifre_textBox);
            this.Controls.Add(this.Kullanici_textBox);
            this.Controls.Add(this.kayitOl_button);
            this.Controls.Add(this.giris_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.Button kayitOl_button;
        private System.Windows.Forms.TextBox Kullanici_textBox;
        private System.Windows.Forms.TextBox Sifre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sifre_unuttum;
    }
}

