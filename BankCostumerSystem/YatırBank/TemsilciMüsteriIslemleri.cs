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
    public partial class TemsilciMüsteriIslemleri : Form
    {
        public TemsilciMüsteriIslemleri()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public int id;
        private void TemsilciMüsteriIslemleri_Load(object sender, EventArgs e)
        {
            this.Text = ""+id;
            // TODO: This line of code loads data into the 'bankaDataSet3.TBL_MUSTERI_BILGILERI' table. You can move, or remove it, as needed.
            Listele();
            Temizle();
        }
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_MUSTERI_BILGILERI inner join TBL_MUSTERI_MUDUR ON " +
                "TBL_MUSTERI_MUDUR.NO = TBL_MUSTERI_BILGILERI.MUSTERI_NO where MUSTERI_TEMSILCISI_NO = @p1 ", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
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

            int musteriBakiye = 0;
            SqlCommand komut2 = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1 ", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(NoLabel.Text));
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                musteriBakiye = Int32.Parse(dr2[0].ToString());
            }

            if (musteriBakiye > 0)
            {
                button3.Enabled = false;
                button3.Text = "Kullanıcı silinemez.";
            }
            else
            {
                button3.Enabled = true;
                button3.Text = "SIL.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int No=1;
            SqlCommand arama = new SqlCommand("select PARANO from TBL_PARA where PARA = @p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", "TR");
            SqlDataReader rd = arama.ExecuteReader();
            while (rd.Read())
            {
                No =Int32.Parse(rd[0].ToString());
            }

            SqlCommand komut2 = new SqlCommand("insert into TBL_MUSTERI_MUDUR (MUSTERI_SIFRE,MUSTERI_ADI,MUSTERI_SOYADI,YASI,TCNO,ADRES)" +
                " values (@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut2.Parameters.AddWithValue("@p3", Sifre_textBox.Text);
            komut2.Parameters.AddWithValue("@p4", ad_textBox.Text);
            komut2.Parameters.AddWithValue("@p5", soyad_textBox.Text);
            komut2.Parameters.AddWithValue("@p6", yas_textBox.Text);
            komut2.Parameters.AddWithValue("@p7", tc_textBox.Text);
            komut2.Parameters.AddWithValue("@p8", adres_richTextBox.Text);
            komut2.ExecuteNonQuery();

            int no2 = 0;
            SqlCommand arama2 = new SqlCommand("select NO from TBL_MUSTERI_MUDUR where TCNO = @p1", connection.baglanti());
            arama2.Parameters.AddWithValue("@p1",tc_textBox.Text);
            SqlDataReader dr2 = arama2.ExecuteReader();
            while (dr2.Read())
            {
                no2 = Int32.Parse(dr2[0].ToString());
            }

            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERI_BILGILERI (MUSTERI_NO,MUSTERI_SIFRE,MUSTERI_ADI,MUSTERI_SOYADI,MUSTERI_YASI" +
                ",TC_NO, ADRES, MUSTERI_BAKIYE, MUSTERI_PARA) VALUES " +
                "(@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut.Parameters.AddWithValue("@p0", no2);
            komut.Parameters.AddWithValue("@p1", Sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p2", ad_textBox.Text);
            komut.Parameters.AddWithValue("@p3", soyad_textBox.Text);
            komut.Parameters.AddWithValue("@p4", Int32.Parse(yas_textBox.Text));
            komut.Parameters.AddWithValue("@p5", tc_textBox.Text);
            komut.Parameters.AddWithValue("@p6", adres_richTextBox.Text);
            komut.Parameters.AddWithValue("@p7", Int32.Parse(bakiye_textBox.Text));
            komut.Parameters.AddWithValue("@p8", No);
            komut.ExecuteNonQuery();

            Listele();
            Temizle();
            MessageBox.Show("Ekleme işlemi başarılıdır.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(NoLabel.Text));
            komut2.ExecuteNonQuery();

            SqlCommand komut = new SqlCommand("delete from TBL_MUSTERI_MUDUR where NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(NoLabel.Text));
            komut.ExecuteNonQuery();

            Listele();
            Temizle();
            MessageBox.Show("Silme İşlemi Başarılıdır.");
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
                ",TC_NO=@p5, ADRES= @p6, MUSTERI_BAKIYE= @p7, MUSTERI_PARA= @p8 where MUSTERI_NO = @p9", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p2", ad_textBox.Text);
            komut.Parameters.AddWithValue("@p3", soyad_textBox.Text);
            komut.Parameters.AddWithValue("@p4", Int32.Parse(yas_textBox.Text));
            komut.Parameters.AddWithValue("@p5", tc_textBox.Text);
            komut.Parameters.AddWithValue("@p6", adres_richTextBox.Text);
            komut.Parameters.AddWithValue("@p7", Int32.Parse(bakiye_textBox.Text));
            komut.Parameters.AddWithValue("@p8", No);
            komut.Parameters.AddWithValue("@p9", Int32.Parse(NoLabel.Text));
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
    }
}
