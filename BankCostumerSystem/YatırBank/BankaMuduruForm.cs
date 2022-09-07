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
    public partial class BankaMuduruForm : Form
    {
        public BankaMuduruForm()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            MudurMusteri frm = new MudurMusteri();
            frm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MudurPara frm = new MudurPara();
            frm.Visible=true;
        }
        public DateTime tarih;
        private void button3_Click(object sender, EventArgs e)
        {
            tarih = DateTime.Parse(textBox1.Text);
            textBox1.Text = "" + tarih;

            SqlCommand komut = new SqlCommand("update TBL_TARIH set tarih = @p1 where no="+1, connection.baglanti());
            komut.Parameters.AddWithValue("@p1",tarih);
            komut.ExecuteNonQuery();

            button4.Enabled = true;
            button8.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button8.Enabled = true;

            tarih = tarih.AddMonths(1);
            textBox1.Text = "" + tarih;

            SqlCommand komut = new SqlCommand("update TBL_TARIH set tarih = @p1 where no=" + 1, connection.baglanti());
            komut.Parameters.AddWithValue("@p1", tarih);
            komut.ExecuteNonQuery();
            
            SqlCommand arama = new SqlCommand("select * from TBL_BORC",connection.baglanti());
            SqlDataReader rd = arama.ExecuteReader();
            while (rd.Read())
            {
                SqlCommand komut2 = new SqlCommand("update TBL_BORC set BORC = @p1,AY = @p2,TOPLAMBORC = @p3 where MUSTERI_NO = @p4", connection.baglanti());
                komut2.Parameters.AddWithValue("@p1", Int32.Parse(rd[3].ToString())/ (Int32.Parse(rd[2].ToString())));
                komut2.Parameters.AddWithValue("@p3", Int32.Parse(rd[3].ToString()));
                komut2.Parameters.AddWithValue("@p2", Int32.Parse(rd[2].ToString()));
                komut2.Parameters.AddWithValue("@p4", Int32.Parse(rd[0].ToString()));
                komut2.ExecuteNonQuery();
            }

            
        }

        private void BankaMuduruForm_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select calısan_maas, faiz, kredi_gecikme from TBL_TARIH where no=@p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                calisanmaas_textBox.Text = dr[0].ToString();
                faizoranı_textBox.Text = dr[1].ToString();
                krediGecikme_textBox.Text = dr[2].ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mudurİslemler frm = new Mudurİslemler();
            frm.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_TARIH set calısan_maas = @p2 where no=@p1 ", connection.baglanti());
            komut.Parameters.AddWithValue("@p1",1);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(calisanmaas_textBox.Text));
            
            komut.ExecuteNonQuery();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_TARIH set faiz=@p3 where no=@p1 ", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", 1);
            komut.Parameters.AddWithValue("@p3", Int32.Parse(faizoranı_textBox.Text));
            
            komut.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_TARIH set kredi_gecikme=@p4 where no=@p1 ", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", 1);
            komut.Parameters.AddWithValue("@p4", Int32.Parse(krediGecikme_textBox.Text));
            komut.ExecuteNonQuery();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int carpan = 1;
            SqlCommand komut = new SqlCommand("Select count(TEMSILCI_NO) FROM TBL_TEMSILCI", connection.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                carpan = Int32.Parse(dr[0].ToString());
            }
            dr.Close();
            int eskiBakiye = 0;
            SqlCommand _komut = new SqlCommand("Select banka_bakiyesi FROM TBL_TARIH where no=@p2", connection.baglanti());
            _komut.Parameters.AddWithValue("@p2", 1);
            SqlDataReader dr2 = _komut.ExecuteReader();
            while (dr2.Read())
            {
                eskiBakiye = Int32.Parse(dr2[0].ToString());
            }
            int yeniBakiye = carpan * Int32.Parse(calisanmaas_textBox.Text);

            SqlCommand komut2 = new SqlCommand("update TBL_TARIH set banka_bakiyesi = @p1 where no=@p2",connection.baglanti());
            komut2.Parameters.AddWithValue("@p1",eskiBakiye-yeniBakiye);
            komut2.Parameters.AddWithValue("@p2", 1);
            komut2.ExecuteNonQuery();

            button4.Enabled = true;
            button8.Enabled = false;
            dr2.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MudurTemsilciİslemleri frm = new MudurTemsilciİslemleri();
            frm.Visible = true;
        }
    }
}
