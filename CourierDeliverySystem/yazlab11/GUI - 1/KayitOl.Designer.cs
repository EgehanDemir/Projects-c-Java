
namespace yazlab11
{
    partial class KayitOl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kullanici_textbox = new System.Windows.Forms.TextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.sifre2_textbox = new System.Windows.Forms.TextBox();
            this.kayıt_button = new System.Windows.Forms.Button();
            this.mail_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "K. Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre Tekrar :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // kullanici_textbox
            // 
            this.kullanici_textbox.Location = new System.Drawing.Point(104, 73);
            this.kullanici_textbox.Name = "kullanici_textbox";
            this.kullanici_textbox.Size = new System.Drawing.Size(187, 27);
            this.kullanici_textbox.TabIndex = 5;
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(104, 125);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(189, 27);
            this.sifre_textbox.TabIndex = 7;
            // 
            // sifre2_textbox
            // 
            this.sifre2_textbox.Location = new System.Drawing.Point(104, 179);
            this.sifre2_textbox.Name = "sifre2_textbox";
            this.sifre2_textbox.Size = new System.Drawing.Size(189, 27);
            this.sifre2_textbox.TabIndex = 8;
            // 
            // kayıt_button
            // 
            this.kayıt_button.Location = new System.Drawing.Point(12, 232);
            this.kayıt_button.Name = "kayıt_button";
            this.kayıt_button.Size = new System.Drawing.Size(282, 43);
            this.kayıt_button.TabIndex = 10;
            this.kayıt_button.Text = "Kayıt Ol";
            this.kayıt_button.UseVisualStyleBackColor = true;
            this.kayıt_button.Click += new System.EventHandler(this.kayıt_button_Click);
            // 
            // mail_textbox
            // 
            this.mail_textbox.Location = new System.Drawing.Point(104, 22);
            this.mail_textbox.Name = "mail_textbox";
            this.mail_textbox.Size = new System.Drawing.Size(187, 27);
            this.mail_textbox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mail :";
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 326);
            this.Controls.Add(this.mail_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kayıt_button);
            this.Controls.Add(this.sifre2_textbox);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.kullanici_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            this.Load += new System.EventHandler(this.KayitOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kullanici_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox sifre2_textbox;
        private System.Windows.Forms.Button kayıt_button;
        private System.Windows.Forms.TextBox mail_textbox;
        private System.Windows.Forms.Label label2;
    }
}