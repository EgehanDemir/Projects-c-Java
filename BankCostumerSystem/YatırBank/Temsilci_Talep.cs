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
    public partial class Temsilci_Talep : Form
    {
        public Temsilci_Talep()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public int id;
        int faiz = 0;
        int ayGecikme = 0;
        private void Temsilci_Talep_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("select MUSTERI_NO, MUSTERI_ADI, MUSTERI_SOYADI, KREDI_TALEBI, TARIH, AY, ONAY from TBL_TALEP inner join TBL_MUSTERI_MUDUR ON  TBL_TALEP.MUSTERI_NO = TBL_MUSTERI_MUDUR.NO " +
                "where TBL_MUSTERI_MUDUR.MUSTERI_TEMSILCISI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand arama1 = new SqlCommand("select faiz,kredi_gecikme from TBL_TARIH where no = @p1", connection.baglanti());
            arama1.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr2 = arama1.ExecuteReader();
            while (dr2.Read())
            {
                faiz = Int32.Parse(dr2[0].ToString());
                ayGecikme = Int32.Parse(dr2[1].ToString());
            }
            dr2.Close();
        }
        public void Temizle()
        {
            IDlabel.Text = "";
            musteri_adi_label.Text = "";
            kredi_talebi_label.Text = "";
            Tarih_label.Text = "";
            ay_label4.Text = "";
            onay_label.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            IDlabel.Text = "" + dataGridView1.Rows[secilen].Cells[0].Value.ToString(); 
            musteri_adi_label.Text = ""+ dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            musteri_adi_label.Text += " "+ dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kredi_talebi_label.Text = ""+ dataGridView1.Rows[secilen].Cells[3].Value.ToString(); 
            Tarih_label.Text = ""+ dataGridView1.Rows[secilen].Cells[4].Value.ToString(); 
            ay_label4.Text = ""+ dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[6].Value.ToString().Equals("False"))
            {
                onay_label.Text = "Olumsuz ya da Beklemede.";
                button1.Enabled = true;
            }
            else if (dataGridView1.Rows[secilen].Cells[6].Value.ToString().Equals("True"))
            {
                onay_label.Text = "Onaylandı";
                button1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_TALEP set ONAY = @p1 where MUSTERI_NO = @p2",connection.baglanti());
            komut.Parameters.AddWithValue("@p1",true);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(IDlabel.Text));

            bool borcVarMi = false;
            int borc = 0;
            int ay = 0;
            int toplamborc = 0;

            SqlCommand komut2 = new SqlCommand("select * from TBL_BORC where MUSTERI_NO = @p2", connection.baglanti());
            komut2.Parameters.AddWithValue("@p2", Int32.Parse(IDlabel.Text));
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                borcVarMi = true;
                borc = Int32.Parse(dr[1].ToString());
                ay = Int32.Parse(dr[2].ToString());
                toplamborc = Int32.Parse(dr[3].ToString());
            }
            
            SqlCommand komut3;
            if (borcVarMi)
            {
                komut3 = new SqlCommand("update TBL_BORC set MUSTERI_NO = @p1,BORC = @p2,AY = @p3,TOPLAMBORC = @p4 where MUSTERI_NO = @p1", connection.baglanti());
                komut3.Parameters.AddWithValue("@p1", Int32.Parse(IDlabel.Text));
                komut3.Parameters.AddWithValue("@p2", borc+(Int32.Parse(kredi_talebi_label.Text)*((100+faiz)/100) / Int32.Parse(ay_label4.Text)));
                komut3.Parameters.AddWithValue("@p3", ay+Int32.Parse(ay_label4.Text)+ ayGecikme);
                komut3.Parameters.AddWithValue("@p4", toplamborc+Int32.Parse(kredi_talebi_label.Text));
                button1.Text = "var";
            }
            else
            {
                komut3= new SqlCommand("insert into TBL_BORC (MUSTERI_NO,BORC,AY,TOPLAMBORC) values (@p1,@p2,@p3,@p4)", connection.baglanti());
                komut3.Parameters.AddWithValue("@p1", Int32.Parse(IDlabel.Text));
                komut3.Parameters.AddWithValue("@p2", Int32.Parse(kredi_talebi_label.Text) * ((100 + faiz) / 100) / Int32.Parse(ay_label4.Text));
                komut3.Parameters.AddWithValue("@p3", Int32.Parse(ay_label4.Text));
                komut3.Parameters.AddWithValue("@p4", Int32.Parse(kredi_talebi_label.Text));
                button1.Text = "yok";
            }
            DateTime tarih = DateTime.Now;
            int bankaBakiyesi = 0;
            SqlCommand arama = new SqlCommand("select tarih,banka_bakiyesi from TBL_TARIH where no =" + 1, connection.baglanti());
            SqlDataReader dr2=arama.ExecuteReader();
            while (dr2.Read())
            {
                tarih = DateTime.Parse(dr2[0].ToString());
                bankaBakiyesi = Int32.Parse(dr2[1].ToString());
            }
            dr2.Close();

            int bakiye = 0;
            SqlCommand arama2 = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO =" + Int32.Parse(IDlabel.Text), connection.baglanti());
            SqlDataReader dr3 = arama2.ExecuteReader();
            while (dr3.Read())
            {
                bakiye = Int32.Parse(dr3[0].ToString());
            }

            SqlCommand komut4 = new SqlCommand("insert into TBL_ISLEM (MUSTERI_NO,KAYNAK,HEDEF,ISLEM,TUTAR,KAYNAKBAKIYE,HEDEFBAKIYE,TARIH)" +
                "values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection.baglanti());
            komut4.Parameters.AddWithValue("@p2", Int32.Parse(IDlabel.Text));
            komut4.Parameters.AddWithValue("@p3", id);
            komut4.Parameters.AddWithValue("@p4", 0);
            komut4.Parameters.AddWithValue("@p5", "kredi onaylama");
            komut4.Parameters.AddWithValue("@p6", Int32.Parse(kredi_talebi_label.Text));
            komut4.Parameters.AddWithValue("@p7", bakiye);
            komut4.Parameters.AddWithValue("@p8", bankaBakiyesi);
            komut4.Parameters.AddWithValue("@p9", tarih);

            komut4.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            button1.Enabled = false;
            Temizle();
            Listele();
        }
    }
}
