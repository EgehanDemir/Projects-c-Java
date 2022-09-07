
namespace yazlab11.GUI_2
{
    partial class TeslimatRota
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.mapView.Location = new System.Drawing.Point(12, 12);
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
            this.mapView.Size = new System.Drawing.Size(763, 480);
            this.mapView.TabIndex = 0;
            this.mapView.Zoom = 0D;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(365, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Başlangıç Noktasını Değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(381, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "İşaretlere Odakla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "En Kısa Yol:";
            // 
            // TeslimatRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mapView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeslimatRota";
            this.Text = "TeslimatRota";
            this.Load += new System.EventHandler(this.TeslimatRota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}