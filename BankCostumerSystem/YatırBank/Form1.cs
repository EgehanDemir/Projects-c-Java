using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YatırBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime deneme;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("") && textBox2.Text.Equals(""))
            {
                BankaMuduruForm frm = new BankaMuduruForm();
                frm.Visible = true;
            }
            else
            {
                MessageBox.Show("Bilgileriniz yanlıştır müdürüm.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TemsilciForm frm = new TemsilciForm();
            frm.Id = Int32.Parse(textBox1.Text);
            frm.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MüşteriFormu frm = new MüşteriFormu();
            frm.ID = textBox1.Text;
            frm.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
