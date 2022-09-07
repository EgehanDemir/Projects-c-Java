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
using System.Threading;

namespace YatırBank
{
    
    public partial class MüşteriFormu : Form
    {public string ID = string.Empty;
        public MüşteriFormu()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public DateTime gecerliTarih;
        int kur1 = 0;
        int kur2 = 0;

        public object Threat { get; private set; }

        public void MüşteriFormu_Load(object sender, EventArgs e)
        {

            SqlCommand arama = new SqlCommand("select tarih from TBL_TARIH where no =" + 1, connection.baglanti());
            SqlDataReader _dr = arama.ExecuteReader();
            while (_dr.Read())
            {
                gecerliTarih = DateTime.Parse(_dr[0].ToString());
            }

            SqlCommand komut = new SqlCommand("select * from TBL_TALEP where MUSTERI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1",Int32.Parse(ID));
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                
                if(dr[4].ToString().Equals("True"))
                {
                    button3.Text = "KREDİ TALEBİNİZ ONAYLANMIŞTIR.";
                    button3.BackColor = Color.Green;
                }
                else if (dr[4].ToString().Equals("False"))
                {
                    button3.BackColor = Color.Red;
                    button3.Enabled = false;
                }
            }
            dr.Close();
            connection.baglanti().Close();
            SqlCommand komut2 = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                bakiyelabel.Text = dr2[0].ToString();
            }
            dr2.Close(); 
            connection.baglanti().Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = ID;
            MusteriMusteriIslemleri frm = new MusteriMusteriIslemleri();
            frm.idNo = ID;
            frm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriHesapForm frm = new MusteriHesapForm();
            frm.idNo = ID;
            frm.Visible=true;

        }
        public void Temizle()
        {
            kredi_textBox.Text = "";
            ay_textBox.Text = "";
            bakiyetextBox.Text = "";
            this.Text = "";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_TALEP (MUSTERI_NO,KREDI_TALEBI,TARIH,AY,ONAY) values (@p1,@p2,@p3,@p4,@p5)", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            komut.Parameters.AddWithValue("@p2", Int32.Parse(kredi_textBox.Text));
            komut.Parameters.AddWithValue("@p3", gecerliTarih);
            komut.Parameters.AddWithValue("@p4", Int32.Parse(ay_textBox.Text));
            komut.Parameters.AddWithValue("@p5", false);
            
            

            int bakiye = 0;
            DateTime time = DateTime.Now;
            SqlCommand arama = new SqlCommand("select * from TBL_TARIH where no=@p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1",1);
            SqlDataReader dr = arama.ExecuteReader();
            while (dr.Read())
            {
                bakiye = Int32.Parse(dr[2].ToString());
                time = DateTime.Parse(dr[1].ToString());
            }

            SqlCommand komut2 = new SqlCommand("insert into TBL_ISLEM (MUSTERI_NO,KAYNAK,HEDEF,ISLEM,TUTAR,KAYNAKBAKIYE,HEDEFBAKIYE,TARIH)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            komut2.Parameters.AddWithValue("@p2", Int32.Parse(ID));
            komut2.Parameters.AddWithValue("@p3", 0);
            komut2.Parameters.AddWithValue("@p4", "Kredi Talebi");
            komut2.Parameters.AddWithValue("@p5", Int32.Parse(kredi_textBox.Text));
            komut2.Parameters.AddWithValue("@p6", Int32.Parse(bakiyelabel.Text));
            komut2.Parameters.AddWithValue("@p7", bakiye);
            komut2.Parameters.AddWithValue("@p8", time);
            
            
            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kullanıcıYeniBakiye = Int32.Parse(bakiyelabel.Text) - Int32.Parse(miktar_textBox.Text);
            int alıcıBakiye = 0;
            SqlCommand komut = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p1",connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(hesapIDtextBox.Text));
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                alıcıBakiye=Int32.Parse(dr[0].ToString());
            }
            dr.Close();
            connection.baglanti().Close();

            SqlCommand arama2 = new SqlCommand("select KUR from TBL_PARA Inner Join TBL_MUSTERI_BILGILERI" +
                " on TBL_PARA.PARANO = TBL_MUSTERI_BILGILERI.MUSTERI_PARA where TBL_MUSTERI_BILGILERI.MUSTERI_NO = @p1", connection.baglanti());
            arama2.Parameters.AddWithValue("@p1", Int32.Parse(hesapIDtextBox.Text));
            SqlDataReader dr3 = arama2.ExecuteReader();
            while (dr3.Read())
            {
                kur1 = Int32.Parse(dr3[0].ToString());
            }
            dr3.Close();

            SqlCommand arama3 = new SqlCommand("select KUR from TBL_PARA Inner Join TBL_MUSTERI_BILGILERI" +
                " on TBL_PARA.PARANO = TBL_MUSTERI_BILGILERI.MUSTERI_PARA where TBL_MUSTERI_BILGILERI.MUSTERI_NO = @p1", connection.baglanti());
            arama3.Parameters.AddWithValue("@p1", ID);
            SqlDataReader dr4 = arama3.ExecuteReader();
            while (dr4.Read())
            {
                kur2 = Int32.Parse(dr4[0].ToString());
            }
            dr4.Close();
            int oran1;
            int oran2;

            oran1 = Int32.Parse(miktar_textBox.Text) * kur2 / kur1;
            oran2 = Int32.Parse(miktar_textBox.Text) * kur1 / kur2;

            SqlCommand komut2 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p0 where MUSTERI_NO = @p1", connection.baglanti());
            komut2.Parameters.AddWithValue("@p0", alıcıBakiye + oran1);
            komut2.Parameters.AddWithValue("@p1",Int32.Parse(hesapIDtextBox.Text));
            komut2.ExecuteNonQuery();
            connection.baglanti().Close();

            Thread.Sleep(1000);
            this.Text = "Kullanıcıdan para alınıyor.";

            SqlCommand komut3 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p0 where MUSTERI_NO = @p1", connection.baglanti());
            komut3.Parameters.AddWithValue("@p0", kullanıcıYeniBakiye - oran2);
            komut3.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            komut3.ExecuteNonQuery();
            connection.baglanti().Close();
            bakiyelabel.Text = kullanıcıYeniBakiye.ToString();

            this.Text = "Alıcıya para gönderiliyor.";



            int bakiye = 0;
            DateTime time = DateTime.Now;
            SqlCommand arama = new SqlCommand("select * from TBL_TARIH where no=@p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr2 = arama.ExecuteReader();
            while (dr2.Read())
            {
                bakiye = Int32.Parse(dr2[2].ToString());
                time = DateTime.Parse(dr2[1].ToString());
            }

            SqlCommand komut4 = new SqlCommand("insert into TBL_ISLEM (MUSTERI_NO,KAYNAK,HEDEF,ISLEM,TUTAR,KAYNAKBAKIYE,HEDEFBAKIYE,TARIH)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut4.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            komut4.Parameters.AddWithValue("@p2", Int32.Parse(ID));
            komut4.Parameters.AddWithValue("@p3", Int32.Parse(hesapIDtextBox.Text));
            komut4.Parameters.AddWithValue("@p4", "Para Gönderme");
            komut4.Parameters.AddWithValue("@p5", Int32.Parse(miktar_textBox.Text));
            komut4.Parameters.AddWithValue("@p6", Int32.Parse(bakiyelabel.Text));
            komut4.Parameters.AddWithValue("@p7", alıcıBakiye+ Int32.Parse(miktar_textBox.Text));
            komut4.Parameters.AddWithValue("@p8", time);

            Thread.Sleep(1000);
            this.Text = "İşlem Tamamlandı.";

            komut4.ExecuteNonQuery();
            Temizle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriBorclar frm = new MusteriBorclar();
            frm.ID = Int32.Parse(ID);
            frm.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE=@p2 where MUSTERI_NO = @p1",connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            bakiyelabel.Text = (Int32.Parse(bakiyelabel.Text) - Int32.Parse(bakiyetextBox.Text)).ToString();
            komut.Parameters.AddWithValue("@p2", Int32.Parse(bakiyelabel.Text));

            int bakiye = 0;
            DateTime time = DateTime.Now;
            SqlCommand arama = new SqlCommand("select * from TBL_TARIH where no=@p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr = arama.ExecuteReader();
            while (dr.Read())
            {
                bakiye = Int32.Parse(dr[2].ToString());
                time = DateTime.Parse(dr[1].ToString());
            }

            SqlCommand komut2 = new SqlCommand("insert into TBL_ISLEM (MUSTERI_NO,KAYNAK,HEDEF,ISLEM,TUTAR,KAYNAKBAKIYE,HEDEFBAKIYE,TARIH)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            komut2.Parameters.AddWithValue("@p2", 0);
            komut2.Parameters.AddWithValue("@p3", Int32.Parse(ID));
            komut2.Parameters.AddWithValue("@p4", "Para Çekme");
            komut2.Parameters.AddWithValue("@p5", Int32.Parse(bakiyetextBox.Text));
            komut2.Parameters.AddWithValue("@p6", Int32.Parse(bakiyelabel.Text));
            komut2.Parameters.AddWithValue("@p7", bakiye - Int32.Parse(bakiyetextBox.Text));
            komut2.Parameters.AddWithValue("@p8", time);

            SqlCommand komut3 = new SqlCommand("update TBL_TARIH set banka_bakiyesi = @p1 where no = @p2", connection.baglanti());
            komut3.Parameters.AddWithValue("@p1", bakiye - Int32.Parse(bakiyetextBox.Text));
            komut3.Parameters.AddWithValue("@p2", 1);

            komut3.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            Temizle();
            komut.ExecuteNonQuery();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE=@p2 where MUSTERI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            bakiyelabel.Text = (Int32.Parse(bakiyelabel.Text) + Int32.Parse(bakiyetextBox.Text)).ToString();
            komut.Parameters.AddWithValue("@p2", Int32.Parse(bakiyelabel.Text));

            int bakiye = 0;
            DateTime time = DateTime.Now;
            SqlCommand arama = new SqlCommand("select * from TBL_TARIH where no=@p1", connection.baglanti());
            arama.Parameters.AddWithValue("@p1", 1);
            SqlDataReader dr = arama.ExecuteReader();
            while (dr.Read())
            {
                bakiye = Int32.Parse(dr[2].ToString());
                time = DateTime.Parse(dr[1].ToString());
            }

            SqlCommand komut2 = new SqlCommand("insert into TBL_ISLEM (MUSTERI_NO,KAYNAK,HEDEF,ISLEM,TUTAR,KAYNAKBAKIYE,HEDEFBAKIYE,TARIH)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.baglanti());
            komut2.Parameters.AddWithValue("@p1", Int32.Parse(ID));
            komut2.Parameters.AddWithValue("@p2", Int32.Parse(ID));
            komut2.Parameters.AddWithValue("@p3", 0);
            komut2.Parameters.AddWithValue("@p4", "Para Yatırma");
            komut2.Parameters.AddWithValue("@p5", Int32.Parse(bakiyetextBox.Text));
            komut2.Parameters.AddWithValue("@p6", Int32.Parse(bakiyelabel.Text));
            komut2.Parameters.AddWithValue("@p7", bakiye + Int32.Parse(bakiyetextBox.Text));
            komut2.Parameters.AddWithValue("@p8", time);

            SqlCommand komut3 = new SqlCommand("update TBL_TARIH set banka_bakiyesi = @p1 where no = @p2", connection.baglanti());
            komut3.Parameters.AddWithValue("@p1", bakiye + Int32.Parse(bakiyetextBox.Text));
            komut3.Parameters.AddWithValue("@p2", 1);

            komut3.ExecuteNonQuery();

            komut2.ExecuteNonQuery();
            Temizle();
            komut.ExecuteNonQuery();
        }
    }
}
