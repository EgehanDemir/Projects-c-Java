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
    public partial class MudurTemsilciİslemleri : Form
    {
        public MudurTemsilciİslemleri()
        {
            InitializeComponent();
        }
        int sayi=0;
        Connection connection = new Connection();
        private void MudurTemsilciİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaDataSet8.TBL_TEMSILCI' table. You can move, or remove it, as needed.
            Listele();
            Temizle();


        }
        public void Temizle()
        {
            IDlabel.Text = "";
            sifretextBox.Text = "";
            ad_textBox.Text = "";
            sayilabel.Text = "";
        }
        public void Listele()
        {
            this.tBL_TEMSILCITableAdapter.Fill(this.bankaDataSet8.TBL_TEMSILCI);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sayi = 0;

            IDlabel.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            sifretextBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            ad_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            SqlCommand arama = new SqlCommand("select NO from TBL_MUSTERI_MUDUR inner join TBL_TEMSILCI on " +
                "TBL_MUSTERI_MUDUR.MUSTERI_TEMSILCISI_NO = TBL_TEMSILCI.TEMSILCI_NO where TBL_TEMSILCI.TEMSILCI_NO =@p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", Int32.Parse(IDlabel.Text));
            SqlDataReader dr3 = arama.ExecuteReader();
            while (dr3.Read())
            {
                sayi++;
            }
            dr3.Close();
            sayilabel.Text = "" + sayi;

            SqlCommand komut = new SqlCommand("update TBL_TEMSILCI set MUSTERI_SAYISI = @p1 where TEMSILCI_NO = @p2",connection.baglanti());
            komut.Parameters.AddWithValue("@p1",sayi);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(IDlabel.Text));
            komut.ExecuteNonQuery();

            if (sayi > 0)
            {
                button3.Enabled = false;
            }
            else { button3.Enabled = true; }
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete TBL_TEMSILCI where TEMSILCI_NO=@p1",connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(IDlabel.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi başarılıdır.");
            Listele();
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_TEMSILCI (TEMSILCI_SIFRE,TEMSILCI_ADI,MUSTERI_SAYISI) values" +
                " ( @p1,@p2,@p3)",connection.baglanti());
            komut.Parameters.AddWithValue("@p1",sifretextBox.Text);
            komut.Parameters.AddWithValue("@p2",ad_textBox.Text);
            komut.Parameters.AddWithValue("@p3",0);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılıdır.");
            Listele();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_TEMSILCI set TEMSILCI_SIFRE = @p1 TEMSILCI_ADI = @p2 where TEMSILCI_NO = @p3",connection.baglanti());
            komut.Parameters.AddWithValue("@p1", sifretextBox.Text);
            komut.Parameters.AddWithValue("@p2", ad_textBox.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılıdır.");
            Listele();
            Temizle();
        }
    }
}
