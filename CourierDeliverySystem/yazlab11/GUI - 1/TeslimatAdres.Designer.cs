
namespace yazlab11
{
    partial class TeslimatAdres
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
            this.mapView = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adresEkle_btn = new System.Windows.Forms.Button();
            this.hkn_btn = new System.Windows.Forms.Button();
            this.sıfırla_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_AdresBul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boylam_textbox = new System.Windows.Forms.TextBox();
            this.enlem_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapView
            // 
            this.mapView.Bearing = 0F;
            this.mapView.CanDragMap = true;
            this.mapView.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapView.GrayScaleMode = false;
            this.mapView.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapView.LevelsKeepInMemory = 5;
            this.mapView.Location = new System.Drawing.Point(12, 70);
            this.mapView.MarkersEnabled = true;
            this.mapView.MaxZoom = 2;
            this.mapView.MinZoom = 2;
            this.mapView.MouseWheelZoomEnabled = true;
            this.mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapView.Name = "mapView";
            this.mapView.NegativeMode = false;
            this.mapView.PolygonsEnabled = true;
            this.mapView.RetryLoadTile = 0;
            this.mapView.RoutesEnabled = true;
            this.mapView.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapView.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapView.ShowTileGridLines = false;
            this.mapView.Size = new System.Drawing.Size(685, 338);
            this.mapView.TabIndex = 15;
            this.mapView.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adresEkle_btn);
            this.groupBox1.Controls.Add(this.hkn_btn);
            this.groupBox1.Controls.Add(this.sıfırla_btn);
            this.groupBox1.Location = new System.Drawing.Point(708, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 338);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // adresEkle_btn
            // 
            this.adresEkle_btn.Location = new System.Drawing.Point(6, 21);
            this.adresEkle_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresEkle_btn.Name = "adresEkle_btn";
            this.adresEkle_btn.Size = new System.Drawing.Size(100, 100);
            this.adresEkle_btn.TabIndex = 21;
            this.adresEkle_btn.Text = "Adresi Ekle";
            this.adresEkle_btn.UseVisualStyleBackColor = true;
            this.adresEkle_btn.Click += new System.EventHandler(this.adresEkle_btn_Click);
            // 
            // hkn_btn
            // 
            this.hkn_btn.Location = new System.Drawing.Point(6, 125);
            this.hkn_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hkn_btn.Name = "hkn_btn";
            this.hkn_btn.Size = new System.Drawing.Size(100, 100);
            this.hkn_btn.TabIndex = 20;
            this.hkn_btn.Text = "Haritadan Konum Al";
            this.hkn_btn.UseVisualStyleBackColor = true;
            this.hkn_btn.Click += new System.EventHandler(this.hkn_btn_Click);
            // 
            // sıfırla_btn
            // 
            this.sıfırla_btn.Location = new System.Drawing.Point(6, 229);
            this.sıfırla_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sıfırla_btn.Name = "sıfırla_btn";
            this.sıfırla_btn.Size = new System.Drawing.Size(100, 100);
            this.sıfırla_btn.TabIndex = 19;
            this.sıfırla_btn.Text = "Sıfırla";
            this.sıfırla_btn.UseVisualStyleBackColor = true;
            this.sıfırla_btn.Click += new System.EventHandler(this.sıfırla_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_AdresBul);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.address_textbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 54);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokasyon Bazlı Arama";
            // 
            // Btn_AdresBul
            // 
            this.Btn_AdresBul.Location = new System.Drawing.Point(503, 15);
            this.Btn_AdresBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_AdresBul.Name = "Btn_AdresBul";
            this.Btn_AdresBul.Size = new System.Drawing.Size(176, 33);
            this.Btn_AdresBul.TabIndex = 12;
            this.Btn_AdresBul.Text = "Adres Bul";
            this.Btn_AdresBul.UseVisualStyleBackColor = true;
            this.Btn_AdresBul.Click += new System.EventHandler(this.Btn_AdresBul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "İsim: ";
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(48, 21);
            this.address_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(446, 23);
            this.address_textbox.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.boylam_textbox);
            this.groupBox3.Controls.Add(this.enlem_textbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 44);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevcut Konum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boylam:";
            // 
            // boylam_textbox
            // 
            this.boylam_textbox.Location = new System.Drawing.Point(218, 15);
            this.boylam_textbox.Name = "boylam_textbox";
            this.boylam_textbox.ReadOnly = true;
            this.boylam_textbox.Size = new System.Drawing.Size(100, 23);
            this.boylam_textbox.TabIndex = 2;
            // 
            // enlem_textbox
            // 
            this.enlem_textbox.Location = new System.Drawing.Point(56, 16);
            this.enlem_textbox.Name = "enlem_textbox";
            this.enlem_textbox.ReadOnly = true;
            this.enlem_textbox.Size = new System.Drawing.Size(100, 23);
            this.enlem_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enlem:";
            // 
            // TeslimatAdres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mapView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeslimatAdres";
            this.Text = "Adres";
            this.Load += new System.EventHandler(this.TeslimatDurum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl mapView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button adresEkle_btn;
        private System.Windows.Forms.Button sıfırla_btn;
        private System.Windows.Forms.Button Btn_AdresBul;
        private System.Windows.Forms.Button hkn_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boylam_textbox;
        private System.Windows.Forms.TextBox enlem_textbox;
        private System.Windows.Forms.Label label1;
    }
}