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
    public partial class SifreDegistir : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
            BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            
            var data = new Data()
            {
                KullaniciAdi = kullanici_textbox.Text,
                KullaniciMail = Mail_textBox.Text
            };
            FirebaseResponse response = await client.GetTaskAsync("Kisiler/" + kullanici_textbox.Text);
            Data obj = response.ResultAs<Data>();

            MessageBox.Show("" + obj.KullaniciAdi);

            if (obj.KullaniciAdi.Equals(kullanici_textbox.Text))
            {

                if (sifretekrar_textbox.Text.Equals(sifre_textbox.Text))
                {
                    var data2 = new Data()
                    {
                        KullaniciAdi = obj.KullaniciAdi,
                        KullaniciMail = obj.KullaniciMail,
                        Sifre = sifre_textbox.Text
                    };
                    FirebaseResponse response2 = await client.UpdateTaskAsync("Kisiler/" + kullanici_textbox.Text, data2);
                    Data result = response2.ResultAs<Data>();
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                }

            }
            else
            {
                MessageBox.Show("Mail YANLIŞTIR...");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sifretekrar_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sifre_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
