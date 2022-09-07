using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace yazlab11
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
            BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data()
            {
                KullaniciAdi = Kullanici_textBox.Text,
                Sifre = Sifre_textBox.Text
              };
            FirebaseResponse response = await client.GetTaskAsync("Kisiler/" + Kullanici_textBox.Text);
            Data obj = response.ResultAs<Data>();

            if(Kullanici_textBox.Text.Equals(obj.KullaniciAdi) && Sifre_textBox.Text.Equals(obj.Sifre))
            {
                TeslimatDurum form = new TeslimatDurum();
                form.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı.");
            }


           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kayitOl_button_Click(object sender, EventArgs e)
        {
            KayitOl form = new KayitOl();
            form.Visible = true;
        }

        private void sifre_unuttum_Click(object sender, EventArgs e)
        {
            SifreDegistir form = new SifreDegistir();
            form.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Bağlantınız başarılıdır.");
            }
            else {
                MessageBox.Show("Kanka bir teslik var bak!!! \nAllah bu ekranı kimseye göstermesin.");
            }
        }
    }
}
