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
    public partial class TemsilciHesapOnay : Form
    {
        public TemsilciHesapOnay()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public int id;
        int no=0;
        string hesap ="";
        int hesapBakiyesi = 0;
        bool acmaOnay = false;
        bool silmeOnay = false;
        int kullanıcıBakiye = 0;
        private void TemsilciHesapOnay_Load(object sender, EventArgs e)
        {
            Listele();
            
        }
        public void Ara()
        {
            SqlCommand arama = new SqlCommand("Select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = "+no,connection.baglanti());
            SqlDataReader read = arama.ExecuteReader();
            while(read.Read()){
                kullanıcıBakiye = Int32.Parse(read[0].ToString());
            }
        }
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("select MUSTERI_ADI, MUSTERI_SOYADI, MUSTERI_NO, MUSTERI_HESAP, HESAP_BAKIYESI, ACMA_ONAY, SILME_ONAY " +
                "from TBL_MUSTERI_HESAP Inner Join TBL_MUSTERI_MUDUR on " +
                "TBL_MUSTERI_MUDUR.NO = TBL_MUSTERI_HESAP.MUSTERI_NO where TBL_MUSTERI_MUDUR.MUSTERI_TEMSILCISI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            no = Int32.Parse(dataGridView1.Rows[secilen].Cells[2].Value.ToString());
            hesap = ""+ dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            hesapBakiyesi = Int32.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            acmaOnay = bool.Parse(dataGridView1.Rows[secilen].Cells[5].Value.ToString());
            silmeOnay = bool.Parse(dataGridView1.Rows[secilen].Cells[6].Value.ToString());
            Ara();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_HESAP set ACMA_ONAY = @p2 where MUSTERI_HESAP = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap);
            komut.Parameters.AddWithValue("@p2", true);
            
            SqlCommand komut2 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p1 where MUSTERI_NO = @p2", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", kullanıcıBakiye - hesapBakiyesi);
            komut2.Parameters.AddWithValue("@p2", no); 
            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            Listele();
            MessageBox.Show("Ekleme işlemi başarılıdır.");
            MessageBox.Show("Hesap bakiyesi Güncellendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete TBL_MUSTERI_HESAP where MUSTERI_HESAP = @p1 and SILME_ONAY = @p2", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", hesap);
            komut.Parameters.AddWithValue("@p2", true);

            SqlCommand komut2 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p1 where MUSTERI_NO = @p2", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", kullanıcıBakiye + hesapBakiyesi);
            komut2.Parameters.AddWithValue("@p2", no);
            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            Listele();
            MessageBox.Show("Silme işlemi başarılıdır.");
            MessageBox.Show("Hesap bakiyesi Güncellendi.");
        }
    }
}
