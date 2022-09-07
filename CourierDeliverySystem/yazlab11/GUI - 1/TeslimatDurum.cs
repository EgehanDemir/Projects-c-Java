using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yazlab11.GUI_2;

namespace yazlab11
{
    
    public partial class TeslimatDurum : Form
    {
        TeslimatAdres teslimatAdres;
        bool teslimatAdres_Status = false;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
            BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public TeslimatDurum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(teslimatAdres_Status == false)
            {
                teslimatAdres = new TeslimatAdres(teslimatDurum: this);
                teslimatAdres_Status = true;
                teslimatAdres.Show();
            }
        }

        public void AdresGuncelle(string adres,string enlem, string boylam )
        {
            teslimatAdres_textBox.Text = adres;
            enlem_textbox.Text = enlem;
            boylam_textbox.Text = boylam;
            teslimatAdres_Status = false;
        }

        public async void listele()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "Gaqe1QYxpDcnECrttN7PI38Ue4OwA6huKGBgxJag",
                BasePath = "https://yazlab11-c3dd7-default-rtdb.firebaseio.com/"
            };
            IFirebaseClient client = new FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Kargolar");
            List<Data2> convertedData = response.ResultAs<List<Data2>>();

            foreach (var item in convertedData)
            {
                if (item != null)
                {
                    dataGridView1.Rows.Add(item.KargoID, item.KargoAdi, item.KargoTuru,
                    item.KargoDurum, item.KargoAdres, item.KargoEnlem,item.KargoBoylam);
                }
            }
        }
        private async void TeslimatDurum_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            listele();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var data = new Data2
            {
                KargoID = kargoID_textBox.Text,
                KargoAdi = Kargoadi_textBox.Text,
                KargoTuru = Kargoturu_textBox.Text,
                KargoDurum = kargodurum_comboBox.Text,
                KargoAdres = teslimatAdres_textBox.Text,
                KargoEnlem = enlem_textbox.Text,
                KargoBoylam = boylam_textbox.Text
            };
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetTaskAsync("Kargolar/" + kargoID_textBox.Text, data);
            Data2.result = response.ResultAs<Data2>();
            dataGridView1.Rows.Clear();
            listele();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var data = new Data2()
            {
                KargoID = kargoID_textBox.Text
            };
            FirebaseResponse response = await client.GetTaskAsync("Kargolar/" + kargoID_textBox.Text);
            Data2 obj = response.ResultAs<Data2>();

            MessageBox.Show("" + obj.KargoID+" "+obj.KargoAdi);

            var data2 = new Data2()
            {
                KargoID = obj.KargoID,
                KargoAdi = Kargoadi_textBox.Text,
                KargoTuru = Kargoturu_textBox.Text,
                KargoDurum = kargodurum_comboBox.Text,
                KargoAdres = teslimatAdres_textBox.Text,
                KargoEnlem = enlem_textbox.Text,
                KargoBoylam = boylam_textbox.Text
            };
            FirebaseResponse response2 = await client.UpdateTaskAsync("Kargolar/" + obj.KargoID, data2);
            Data2 result = response2.ResultAs<Data2>();
            dataGridView1.Rows.Clear();
            listele();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var data2 = new Data2()
            {
                KargoID = kargoID_textBox.Text,
                KargoAdi = Kargoadi_textBox.Text,
                KargoTuru = Kargoturu_textBox.Text,
                KargoDurum = kargodurum_comboBox.Text,
                KargoAdres = teslimatAdres_textBox.Text,
                KargoEnlem = enlem_textbox.Text,
                KargoBoylam = boylam_textbox.Text
            };
            var data = await client.DeleteTaskAsync("Kargolar/" + kargoID_textBox.Text);
            dataGridView1.Rows.Clear();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            if(dataGridView1.Rows[secilen].Cells[0].Value != null)
            {
                kargoID_textBox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                Kargoadi_textBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                Kargoturu_textBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                kargodurum_comboBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                teslimatAdres_textBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                enlem_textbox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                boylam_textbox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            }
            
        }

        private void TRO_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult  = MessageBox.Show("Başlangıç konumu seçmeniz gerekmektedir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.OK)
            {
                TeslimatAdres baslangicKonumu = new TeslimatAdres();
                baslangicKonumu.Show();
            }
        }
    }
}
