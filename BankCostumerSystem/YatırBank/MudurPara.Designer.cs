namespace YatırBank
{
    partial class MudurPara
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
            this.bankaDataSet2 = new YatırBank.BankaDataSet2();
            this.tBLPARABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_PARATableAdapter = new YatırBank.BankaDataSet2TableAdapters.TBL_PARATableAdapter();
            this.pARANODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLABEL = new System.Windows.Forms.Label();
            this.Para_Label = new System.Windows.Forms.Label();
            this.Kur_Label = new System.Windows.Forms.Label();
            this.para_textBox = new System.Windows.Forms.TextBox();
            this.kur_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPARABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pARANODataGridViewTextBoxColumn,
            this.pARADataGridViewTextBoxColumn,
            this.kURDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLPARABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bankaDataSet2
            // 
            this.bankaDataSet2.DataSetName = "BankaDataSet2";
            this.bankaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPARABindingSource
            // 
            this.tBLPARABindingSource.DataMember = "TBL_PARA";
            this.tBLPARABindingSource.DataSource = this.bankaDataSet2;
            // 
            // tBL_PARATableAdapter
            // 
            this.tBL_PARATableAdapter.ClearBeforeFill = true;
            // 
            // pARANODataGridViewTextBoxColumn
            // 
            this.pARANODataGridViewTextBoxColumn.DataPropertyName = "PARANO";
            this.pARANODataGridViewTextBoxColumn.HeaderText = "PARANO";
            this.pARANODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pARANODataGridViewTextBoxColumn.Name = "pARANODataGridViewTextBoxColumn";
            this.pARANODataGridViewTextBoxColumn.ReadOnly = true;
            this.pARANODataGridViewTextBoxColumn.Width = 125;
            // 
            // pARADataGridViewTextBoxColumn
            // 
            this.pARADataGridViewTextBoxColumn.DataPropertyName = "PARA";
            this.pARADataGridViewTextBoxColumn.HeaderText = "PARA";
            this.pARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pARADataGridViewTextBoxColumn.Name = "pARADataGridViewTextBoxColumn";
            this.pARADataGridViewTextBoxColumn.Width = 125;
            // 
            // kURDataGridViewTextBoxColumn
            // 
            this.kURDataGridViewTextBoxColumn.DataPropertyName = "KUR";
            this.kURDataGridViewTextBoxColumn.HeaderText = "KUR";
            this.kURDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kURDataGridViewTextBoxColumn.Name = "kURDataGridViewTextBoxColumn";
            this.kURDataGridViewTextBoxColumn.Width = 125;
            // 
            // IDLABEL
            // 
            this.IDLABEL.AutoSize = true;
            this.IDLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDLABEL.Location = new System.Drawing.Point(460, 26);
            this.IDLABEL.Name = "IDLABEL";
            this.IDLABEL.Size = new System.Drawing.Size(0, 22);
            this.IDLABEL.TabIndex = 1;
            // 
            // Para_Label
            // 
            this.Para_Label.AutoSize = true;
            this.Para_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Para_Label.Location = new System.Drawing.Point(463, 77);
            this.Para_Label.Name = "Para_Label";
            this.Para_Label.Size = new System.Drawing.Size(63, 22);
            this.Para_Label.TabIndex = 2;
            this.Para_Label.Text = "Para : ";
            // 
            // Kur_Label
            // 
            this.Kur_Label.AutoSize = true;
            this.Kur_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kur_Label.Location = new System.Drawing.Point(464, 134);
            this.Kur_Label.Name = "Kur_Label";
            this.Kur_Label.Size = new System.Drawing.Size(63, 22);
            this.Kur_Label.TabIndex = 3;
            this.Kur_Label.Text = "Kuru : ";
            // 
            // para_textBox
            // 
            this.para_textBox.Location = new System.Drawing.Point(533, 79);
            this.para_textBox.Name = "para_textBox";
            this.para_textBox.Size = new System.Drawing.Size(188, 22);
            this.para_textBox.TabIndex = 4;
            // 
            // kur_textBox
            // 
            this.kur_textBox.Location = new System.Drawing.Point(533, 136);
            this.kur_textBox.Name = "kur_textBox";
            this.kur_textBox.Size = new System.Drawing.Size(188, 22);
            this.kur_textBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "SIL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MudurPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 313);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kur_textBox);
            this.Controls.Add(this.para_textBox);
            this.Controls.Add(this.Kur_Label);
            this.Controls.Add(this.Para_Label);
            this.Controls.Add(this.IDLABEL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MudurPara";
            this.Text = "MudurPara";
            this.Load += new System.EventHandler(this.MudurPara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPARABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankaDataSet2 bankaDataSet2;
        private System.Windows.Forms.BindingSource tBLPARABindingSource;
        private BankaDataSet2TableAdapters.TBL_PARATableAdapter tBL_PARATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARANODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kURDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label IDLABEL;
        private System.Windows.Forms.Label Para_Label;
        private System.Windows.Forms.Label Kur_Label;
        private System.Windows.Forms.TextBox para_textBox;
        private System.Windows.Forms.TextBox kur_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}