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
    public partial class TemsilciForm : Form
    {
        public TemsilciForm()
        {
            InitializeComponent();
        }
        public int Id;
        private void TemsilciForm_Load(object sender, EventArgs e)
        {
            this.Text = "" + Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemsilciMüsteriIslemleri frm = new TemsilciMüsteriIslemleri();
            frm.id = Id;
            frm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temsilci_Talep frm = new Temsilci_Talep();
            frm.id = Id;
            frm.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TemsilciMüsteriIslemleri frm = new TemsilciMüsteriIslemleri();
            frm.id = Id;
            frm.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TemsilciHesapOnay frm = new TemsilciHesapOnay();
            frm.id =Id;
            frm.Visible = true;
        }
    }
}
