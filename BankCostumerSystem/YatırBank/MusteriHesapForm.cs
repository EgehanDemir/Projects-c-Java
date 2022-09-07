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
    public partial class MusteriHesapForm : Form
    {
        public MusteriHesapForm()
        {
            InitializeComponent();
        }
        public string idNo = string.Empty;
        Connection connection = new Connection();
        int kur = 0;
        private void MusteriHesapForm_Load(object sender, EventArgs e)
        {
            Listele();
            Kontrol();

            SqlCommand arama2 = new SqlCommand("select KUR from TBL_PARA Inner Join TBL_MUSTERI_BILGILERI" +
                " on TBL_PARA.PARANO = TBL_MUSTERI_BILGILERI.MUSTERI_PARA where TBL_MUSTERI_BILGILERI.MUSTERI_NO = @p1", connection.baglanti());
            arama2.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader dr3 = arama2.ExecuteReader();
            while (dr3.Read())
            {
                kur = Int32.Parse(dr3[0].ToString());
            }
            dr3.Close();

        }
        public void Listele()
        {
            bool temp = false;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERI_HESAP where MUSTERI_NO =" + idNo, connection.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Kontrol()
        {
            bool kontrol = false;
            SqlCommand komut = new SqlCommand("select * from TBL_MUSTERI_HESAP where MUSTERI_NO =" + idNo, connection.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {  
                    kontrol = true;
            }
            if (!kontrol)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
        public void Temizle()
        {
            Idlabel.Text = "";
            hesapAdtextBox.Text = "";
            bakiyetextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_HESAP set SILME_ONAY = @p2 where MUSTERI_HESAP = @p1 ", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", hesapAdtextBox.Text); 
            komut.Parameters.AddWithValue("@p2", true);
            komut.ExecuteNonQuery();
            Listele();
            Temizle();
            MessageBox.Show("Silme isteği işlemi başarılıdır.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_HESAP set MUSTERI_HESAP = @p1,HESAP_BAKIYESI = @p2 where MUSTERI_NO = @p3", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", hesapAdtextBox.Text);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(bakiyetextBox.Text));
            komut.Parameters.AddWithValue("@p3", idNo);
            komut.ExecuteNonQuery();
            Listele();
            Temizle();
            MessageBox.Show("Güncelleme işlemi başarılıdır.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Idlabel.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            hesapAdtextBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            bakiyetextBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[3].Value.ToString().Equals("False"))
            {
                button2.Enabled = false;
                button2.Text = "Henüz Onaylanmadı.";
            }
            else if (dataGridView1.Rows[secilen].Cells[3].Value.ToString().Equals("True"))
            {
                button2.Enabled = true;
                button2.Text = "GUNCELLE";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERI_HESAP (MUSTERI_NO,MUSTERI_HESAP,HESAP_BAKIYESI, ACMA_ONAY, SILME_ONAY)" +
                "values (@p1,@p2,@p3, @p4, @p5)", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", idNo);
            komut.Parameters.AddWithValue("@p2", hesapAdtextBox.Text);
            komut.Parameters.AddWithValue("@p3", Int32.Parse(bakiyetextBox.Text));
            komut.Parameters.AddWithValue("@p4", false);
            komut.Parameters.AddWithValue("@p5", false);
            komut.ExecuteNonQuery();
            Listele();
            Temizle();
            MessageBox.Show("Onay Ekleme işlemi başarılıdır.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int mevcutBakiye = 0;
            int hesaptakiMevcutBakiye = 0;
            SqlCommand arama = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader dr = arama.ExecuteReader();
            while (dr.Read())
            {
                mevcutBakiye = Int32.Parse(dr[0].ToString());
            }
            dr.Close();

            SqlCommand arama2 = new SqlCommand("select HESAP_BAKIYESI from TBL_MUSTERI_HESAP where MUSTERI_NO = @p1", connection.baglanti());
            arama2.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader dr2 = arama2.ExecuteReader();
            while (dr2.Read())
            {
                hesaptakiMevcutBakiye = Int32.Parse(dr2[0].ToString());
            }
            dr2.Close();

            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_HESAP set HESAP_BAKIYESI = @p2 where MUSTERI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", idNo);
            komut.Parameters.AddWithValue("@p2", hesaptakiMevcutBakiye + Int32.Parse(bakiyetextBox.Text)/kur);

            SqlCommand komut2 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p2 where MUSTERI_NO = @p1", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", idNo);
            komut2.Parameters.AddWithValue("@p2", mevcutBakiye - Int32.Parse(bakiyetextBox.Text)/kur);

            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            Listele();
            Temizle();
            MessageBox.Show("Bakiyeniz güncellenmiştir.");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int mevcutBakiye = 0;
            int hesaptakiMevcutBakiye = 0;
            SqlCommand arama = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader dr = arama.ExecuteReader();
            while (dr.Read())
            {
                mevcutBakiye = Int32.Parse(dr[0].ToString());
            }
            dr.Close();

            SqlCommand arama2 = new SqlCommand("select HESAP_BAKIYESI from TBL_MUSTERI_HESAP where MUSTERI_NO = @p1", connection.baglanti());
            arama2.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader dr2 = arama2.ExecuteReader();
            while (dr2.Read())
            {
                hesaptakiMevcutBakiye = Int32.Parse(dr2[0].ToString());
            }
            dr2.Close();

            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_HESAP set HESAP_BAKIYESI = @p2 where MUSTERI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", idNo);
            komut.Parameters.AddWithValue("@p2", hesaptakiMevcutBakiye - Int32.Parse(bakiyetextBox.Text));

            SqlCommand komut2 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p2 where MUSTERI_NO = @p1", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", idNo);
            komut2.Parameters.AddWithValue("@p2", mevcutBakiye + Int32.Parse(bakiyetextBox.Text));

            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            Listele();
            Temizle();
            MessageBox.Show("Bakiyeniz güncellenmiştir.");
        }
    }
}
