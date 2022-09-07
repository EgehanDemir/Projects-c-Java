using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yazlab11
{
    public partial class KayitOl : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
            BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        public KayitOl()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private async void kayıt_button_Click(object sender, EventArgs e)
        {
            if (sifre2_textbox.Text.Equals(sifre_textbox.Text)) {
                var data = new Data
                {
                    KullaniciMail = mail_textbox.Text,
                    KullaniciAdi = kullanici_textbox.Text,
                    Sifre = sifre_textbox.Text
                };
                client = new FireSharp.FirebaseClient(config);
                SetResponse response = await client.SetTaskAsync("Kisiler/"+kullanici_textbox.Text,data);
                Data.result = response.ResultAs<Data>();
            }
            else
            {
                MessageBox.Show("şifreler uyuşmamaktadır.");
            }
            
        }
    }
}
