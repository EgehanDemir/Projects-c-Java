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
    public partial class MusteriMusteriIslemleri : Form
    {
        public MusteriMusteriIslemleri()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public string idNo = string.Empty;
        public void Temizle()
        {
            NoLabel.Text = "";
            Sifre_textBox.Text = "";
            ad_textBox.Text = "";
            soyad_textBox.Text = "";
            yas_textBox.Text = "";
            tc_textBox.Text = "";
            adres_richTextBox.Text = "";
            bakiye_textBox.Text = "";
            para_textBox.Text = "";
        }
        public void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERI_BILGILERI where MUSTERI_NO =" + Int32.Parse(idNo), connection.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void MusteriMusteriIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            NoLabel.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Sifre_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soyad_textBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yas_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tc_textBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            adres_richTextBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            bakiye_textBox.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            para_textBox.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            if (!para_textBox.Text.Equals(""))
            {
                SqlCommand arama = new SqlCommand("select PARA from TBL_PARA where PARANO = @p1", connection.baglanti());
                arama.Parameters.AddWithValue("@p1", Int32.Parse(para_textBox.Text));
                SqlDataReader rd = arama.ExecuteReader();
                while (rd.Read())
                {
                    para_textBox.Text = rd[0].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int No = 1;
            SqlCommand arama = new SqlCommand("select PARANO from TBL_PARA where PARA = @p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", para_textBox.Text);
            SqlDataReader rd = arama.ExecuteReader();
            while (rd.Read())
            {
                No = Int32.Parse(rd[0].ToString());
            }

            SqlCommand komut = new SqlCommand("Update TBL_MUSTERI_BILGILERI set MUSTERI_SIFRE = @p1,MUSTERI_ADI= @p2,MUSTERI_SOYADI= @p3,MUSTERI_YASI= @p4" +
                ",TC_NO=@p5, ADRES= @p6, MUSTERI_BAKIYE= @p7, MUSTERI_PARA= @p8", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p2", ad_textBox.Text);
            komut.Parameters.AddWithValue("@p3", soyad_textBox.Text);
            komut.Parameters.AddWithValue("@p4", Int32.Parse(yas_textBox.Text));
            komut.Parameters.AddWithValue("@p5", tc_textBox.Text);
            komut.Parameters.AddWithValue("@p6", adres_richTextBox.Text);
            komut.Parameters.AddWithValue("@p7", Int32.Parse(bakiye_textBox.Text));
            komut.Parameters.AddWithValue("@p8", No);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update TBL_MUSTERI_MUDUR set  MUSTERI_SIFRE = @p2,MUSTERI_ADI = @p3 " +
                ",MUSTERI_SOYADI = @p4 ,YASI = @p5,TCNO = @p6,ADRES = @p7" +
                "  WHERE NO = @p8", connection.baglanti());
            komut2.Parameters.AddWithValue("@p2", Sifre_textBox.Text);
            komut2.Parameters.AddWithValue("@p3", ad_textBox.Text);
            komut2.Parameters.AddWithValue("@p4", soyad_textBox.Text);
            komut2.Parameters.AddWithValue("@p5", yas_textBox.Text);
            komut2.Parameters.AddWithValue("@p6", tc_textBox.Text);
            komut2.Parameters.AddWithValue("@p7", adres_richTextBox.Text);
            komut2.Parameters.AddWithValue("@p8", NoLabel.Text);
            komut2.ExecuteNonQuery();
            connection.baglanti().Close();

            Listele();
            Temizle();
            MessageBox.Show("Güncelleme işlemi başarılıdır.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
