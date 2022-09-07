namespace YatırBank
{
    partial class MusteriBorclar
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
            this.bankaDataSet6 = new YatırBank.BankaDataSet6();
            this.tBLBORCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_BORCTableAdapter = new YatırBank.BankaDataSet6TableAdapters.TBL_BORCTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toplamBorc_label = new System.Windows.Forms.Label();
            this.borc_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBORCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bankaDataSet6
            // 
            this.bankaDataSet6.DataSetName = "BankaDataSet6";
            this.bankaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLBORCBindingSource
            // 
            this.tBLBORCBindingSource.DataMember = "TBL_BORC";
            this.tBLBORCBindingSource.DataSource = this.bankaDataSet6;
            // 
            // tBL_BORCTableAdapter
            // 
            this.tBL_BORCTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aylık Borç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Borç :";
            // 
            // toplamBorc_label
            // 
            this.toplamBorc_label.AutoSize = true;
            this.toplamBorc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamBorc_label.Location = new System.Drawing.Point(156, 39);
            this.toplamBorc_label.Name = "toplamBorc_label";
            this.toplamBorc_label.Size = new System.Drawing.Size(0, 22);
            this.toplamBorc_label.TabIndex = 2;
            // 
            // borc_label
            // 
            this.borc_label.AutoSize = true;
            this.borc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borc_label.Location = new System.Drawing.Point(133, 78);
            this.borc_label.Name = "borc_label";
            this.borc_label.Size = new System.Drawing.Size(0, 22);
            this.borc_label.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "AYLIK BORÇ ÖDE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriBorclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borc_label);
            this.Controls.Add(this.toplamBorc_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusteriBorclar";
            this.Text = "MusteriBorclar";
            this.Load += new System.EventHandler(this.MusteriBorclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBORCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BankaDataSet6 bankaDataSet6;
        private System.Windows.Forms.BindingSource tBLBORCBindingSource;
        private BankaDataSet6TableAdapters.TBL_BORCTableAdapter tBL_BORCTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toplamBorc_label;
        private System.Windows.Forms.Label borc_label;
        private System.Windows.Forms.Button button1;
    }
}