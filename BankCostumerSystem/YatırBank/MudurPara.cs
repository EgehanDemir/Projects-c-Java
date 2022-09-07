using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YatırBank
{
    public partial class MudurPara : Form
    {
        public MudurPara()
        {
            InitializeComponent();
        }

        private void MudurPara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaDataSet2.TBL_PARA' table. You can move, or remove it, as needed.
            Listele();
            Temizle();
        }
        Connection connection = new Connection();
        public void Listele()
        {
            this.tBL_PARATableAdapter.Fill(this.bankaDataSet2.TBL_PARA);
        }
        public void Temizle()
        {
            IDLABEL.Text = "";
            para_textBox.Text = "";
            kur_textBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_PARA (PARA,KUR) values (@p1,@p2)",connection.baglanti());
            komut.Parameters.AddWithValue("@p1",para_textBox.Text);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(kur_textBox.Text));
            komut.ExecuteNonQuery();
            connection.baglanti().Close();
            Temizle();
            Listele();
            MessageBox.Show("Para eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_PARA set PARA = @p1, KUR = @p2  WHERE PARANO = @p3", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", para_textBox.Text);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(kur_textBox.Text));
            komut.Parameters.AddWithValue("@p3", Int32.Parse(IDLABEL.Text));
            komut.ExecuteNonQuery();
            connection.baglanti().Close();
            Temizle();
            Listele();
            MessageBox.Show("Para Güncellendi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_PARA where PARANO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(IDLABEL.Text));
            komut.ExecuteNonQuery();
            connection.baglanti().Close();
            Temizle();
            Listele();
            MessageBox.Show("Para silindi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            IDLABEL.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            para_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kur_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            
        }
    }
}
