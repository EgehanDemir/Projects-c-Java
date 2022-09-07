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
    public partial class MudurMusteri : Form
    {
        public MudurMusteri()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public string enKucukMusteriSahibi;
        int sayi = 0;
        private void MudurMusteri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaDataSet5.TBL_MUSTERI_MUDUR' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'bankaDataSet1.TBL_MUSTERI_MUDUR' table. You can move, or remove it, as needed.
            Listele();
            Temizle();
            TemsilciComboboxAyarla();

        }
        public void Listele()
        {
           this.tBL_MUSTERI_MUDURTableAdapter1.Fill(this.bankaDataSet5.TBL_MUSTERI_MUDUR);
           /* SqlCommand komut = new SqlCommand("select NO, MUSTERI_TEMSILCISI_NO,MUSTERI_SAYISI,MUSTERI_SIFRE,MUSTERI_ADI,MUSTERI_SOYADI,YASI,TCNO,ADRES " +
                "from TBL_MUSTERI_MUDUR inner join TBL_TEMSILCI on TBL_MUSTERI_MUDUR.MUSTERI_TEMSILCISI_NO = TBL_TEMSILCI.TEMSILCI_NO ", connection.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/

        }
        public void Temizle()
        {
            ID_LABEL.Text = "";
            temsilcino_textBox.Text = "";
            sifre_textBox.Text = "";
            adi_textBox.Text = "";
            soyadi_textBox.Text = "";
            yas_textBox.Text = "";
            tc_textBox.Text = "";
            adresTextBox.Text = "";
        }
        public void TemsilciComboboxAyarla()
        {
            SqlCommand komut = new SqlCommand("Select TEMSILCI_ADI From TBL_TEMSILCI", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", temsilcino_textBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (!temsilcino_textBox.Items.Equals(dr[0].ToString()))
                {
                    temsilcino_textBox.Items.Add(dr[0].ToString());
                }
            }
            SqlCommand komut2 = new SqlCommand("Select TEMSILCI_ADI From TBL_TEMSILCI ORDER BY MUSTERI_SAYISI ASC", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", temsilcino_textBox.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                enKucukMusteriSahibi ="" + dr2[0].ToString();
                break;
            }
            


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ID_LABEL.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            temsilcino_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            adi_textBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            soyadi_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            yas_textBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tc_textBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            adresTextBox.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            SqlCommand komut = new SqlCommand("Select TEMSILCI_ADI From TBL_TEMSILCI where TEMSILCI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", temsilcino_textBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                    temsilcino_textBox.Text = dr[0].ToString();
            }
            dr.Close();

            int musteriBakiye = 0;
            SqlCommand komut2 = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1 ", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(ID_LABEL.Text));
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                if (dr2.Read())
                {
                    musteriBakiye = Int32.Parse(dr2[0].ToString());
                }
                
            }

            if(musteriBakiye>0)
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
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int no = 0;
            SqlCommand _komut = new SqlCommand("Select TEMSILCI_NO From TBL_TEMSILCI where TEMSILCI_ADI = @p1", connection.baglanti());
            _komut.Parameters.AddWithValue("@p1", enKucukMusteriSahibi);
            SqlDataReader dr = _komut.ExecuteReader();
            while (dr.Read())
            {
                no = Int32.Parse(dr[0].ToString());
            }
            
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERI_MUDUR (MUSTERI_TEMSILCISI_NO,MUSTERI_SIFRE,MUSTERI_ADI,MUSTERI_SOYADI,YASI,TCNO,ADRES)" +
                " values (@p1,@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", no);
            komut.Parameters.AddWithValue("@p3", sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p4", adi_textBox.Text);
            komut.Parameters.AddWithValue("@p5", soyadi_textBox.Text);
            komut.Parameters.AddWithValue("@p6", yas_textBox.Text);
            komut.Parameters.AddWithValue("@p7", tc_textBox.Text);
            komut.Parameters.AddWithValue("@p8", adresTextBox.Text);
            komut.ExecuteNonQuery();
            connection.baglanti().Close();

            int no2=0;
            SqlCommand arama = new SqlCommand("select NO from TBL_MUSTERI_MUDUR where TCNO = @p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", tc_textBox.Text);
            SqlDataReader dr2 = arama.ExecuteReader();
            while (dr2.Read())
            {
                no2=Int32.Parse(dr2[0].ToString());
            }
            dr2.Close();

            SqlCommand komut2 = new SqlCommand("insert into TBL_MUSTERI_BILGILERI (MUSTERI_NO,MUSTERI_SIFRE,MUSTERI_ADI,MUSTERI_SOYADI,MUSTERI_YASI" +
               ",TC_NO, ADRES) VALUES " +
               "(@p0,@p1,@p2,@p3,@p4,@p5,@p6)", connection.baglanti());
            komut2.Parameters.AddWithValue("@p0", no2);
            komut2.Parameters.AddWithValue("@p1", sifre_textBox.Text);
            komut2.Parameters.AddWithValue("@p2", adi_textBox.Text);
            komut2.Parameters.AddWithValue("@p3", soyadi_textBox.Text);
            komut2.Parameters.AddWithValue("@p4", Int32.Parse(yas_textBox.Text));
            komut2.Parameters.AddWithValue("@p5", tc_textBox.Text);
            komut2.Parameters.AddWithValue("@p6", adresTextBox.Text);
            komut2.ExecuteNonQuery();
            
            Temizle();
            Listele();
            MessageBox.Show("Ekleme işleminiz başarılıdır.");
        }

        private void temsilciadi_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(ID_LABEL.Text));
            komut2.ExecuteNonQuery();

            SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERI_MUDUR where NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1",Int32.Parse(ID_LABEL.Text));
            komut.ExecuteNonQuery();
            connection.baglanti().Close();

            Temizle();
            Listele();
            MessageBox.Show("Silme işlemi başarılıdır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            int no = 0;
            SqlCommand _komut = new SqlCommand("Select TEMSILCI_NO From TBL_TEMSILCI where TEMSILCI_ADI = @p1", connection.baglanti());
            _komut.Parameters.AddWithValue("@p1", temsilcino_textBox.Text);
            SqlDataReader dr = _komut.ExecuteReader();
            while (dr.Read())
            {
                no = Int32.Parse(dr[0].ToString());
            }

            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_MUDUR set MUSTERI_TEMSILCISI_NO = @p1, MUSTERI_SIFRE = @p2,MUSTERI_ADI = @p3 " +
                ",MUSTERI_SOYADI = @p4 ,YASI = @p5,TCNO = @p6,ADRES = @p7" +
                "  WHERE NO = @p8", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", no);
            komut.Parameters.AddWithValue("@p2", sifre_textBox.Text);
            komut.Parameters.AddWithValue("@p3", adi_textBox.Text);
            komut.Parameters.AddWithValue("@p4", soyadi_textBox.Text);
            komut.Parameters.AddWithValue("@p5", yas_textBox.Text);
            komut.Parameters.AddWithValue("@p6", tc_textBox.Text);
            komut.Parameters.AddWithValue("@p7", adresTextBox.Text);
            komut.Parameters.AddWithValue("@p8", ID_LABEL.Text);
            komut.ExecuteNonQuery();
            connection.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Update TBL_MUSTERI_BILGILERI set MUSTERI_SIFRE = @p1,MUSTERI_ADI= @p2,MUSTERI_SOYADI= @p3,MUSTERI_YASI= @p4" +
                ",TC_NO=@p5, ADRES= @p6 where MUSTERI_NO = @p9", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", sifre_textBox.Text);
            komut2.Parameters.AddWithValue("@p2", adi_textBox.Text);
            komut2.Parameters.AddWithValue("@p3", soyadi_textBox.Text);
            komut2.Parameters.AddWithValue("@p4", Int32.Parse(yas_textBox.Text));
            komut2.Parameters.AddWithValue("@p5", tc_textBox.Text);
            komut2.Parameters.AddWithValue("@p6", adresTextBox.Text);
            komut2.Parameters.AddWithValue("@p9", ID_LABEL.Text);
            komut2.ExecuteNonQuery();

            Listele();
            Temizle();
            MessageBox.Show("Güncelleme işlemi başarılıdır.");
        }
    }
}
