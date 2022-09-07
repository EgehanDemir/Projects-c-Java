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
    public partial class MusteriBorclar : Form
    {
        public MusteriBorclar()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public int ID;
        int ay;
        int kur = 0;

        private void MusteriBorclar_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("select BORC,AY,TOPLAMBORC from TBL_BORC where MUSTERI_NO = @p1", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", ID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                toplamBorc_label.Text = dr[2].ToString();
                borc_label.Text = dr[0].ToString();
                ay = Int32.Parse(dr[1].ToString());
            }
            dr.Close();

            SqlCommand arama2 = new SqlCommand("select KUR from TBL_PARA Inner Join TBL_MUSTERI_BILGILERI" +
                " on TBL_PARA.PARANO = TBL_MUSTERI_BILGILERI.MUSTERI_PARA where TBL_MUSTERI_BILGILERI.MUSTERI_NO = @p1", connection.baglanti());
            arama2.Parameters.AddWithValue("@p1", ID);
            SqlDataReader dr3 = arama2.ExecuteReader();
            while (dr3.Read())
            {
                kur = Int32.Parse(dr3[0].ToString());
            }
            dr3.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int musteriBakiyesi = 0;
            SqlCommand _arama = new SqlCommand("select MUSTERI_BAKIYE from TBL_MUSTERI_BILGILERI where MUSTERI_NO = @p2",connection.baglanti());
            _arama.Parameters.AddWithValue("@p2", ID);
            SqlDataReader rd2= _arama.ExecuteReader();
            while (rd2.Read())
            {
                musteriBakiyesi = Int32.Parse(rd2[0].ToString());
            }
            rd2.Close();

            SqlCommand komut = new SqlCommand("update TBL_BORC set BORC = @p1,AY = @p2,TOPLAMBORC = @p3 where MUSTERI_NO = @p4", connection.baglanti());
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2", ay-1);
            komut.Parameters.AddWithValue("@p3", Int32.Parse(toplamBorc_label.Text) - Int32.Parse(borc_label.Text));
            komut.Parameters.AddWithValue("@p4", ID);


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
            komut2.Parameters.AddWithValue("@p1", ID);
            komut2.Parameters.AddWithValue("@p2", ID);
            komut2.Parameters.AddWithValue("@p3", 0);
            komut2.Parameters.AddWithValue("@p4", "Borç Ödeme");
            komut2.Parameters.AddWithValue("@p5", Int32.Parse(borc_label.Text));
            komut2.Parameters.AddWithValue("@p6", bakiye);
            komut2.Parameters.AddWithValue("@p7", bakiye + (Int32.Parse(borc_label.Text)));
            komut2.Parameters.AddWithValue("@p8", time);

            SqlCommand komut3 = new SqlCommand("update TBL_TARIH set banka_bakiyesi = @p1 where no = @p2", connection.baglanti());
            komut3.Parameters.AddWithValue("@p1", bakiye + (Int32.Parse(borc_label.Text)/kur));
            komut3.Parameters.AddWithValue("@p2", 1);

            SqlCommand komut4 = new SqlCommand("update TBL_MUSTERI_BILGILERI set MUSTERI_BAKIYE = @p1 where MUSTERI_NO = @p2", connection.baglanti());
            komut4.Parameters.AddWithValue("@p1", musteriBakiyesi - (Int32.Parse(borc_label.Text)/kur));
            komut4.Parameters.AddWithValue("@p2", ID);

            komut4.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            komut.ExecuteNonQuery();
            Listele();

        }
    }
}
