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
    public partial class Mudurİslemler : Form
    {
        public Mudurİslemler()
        {
            InitializeComponent();
        }

        private void Mudurİslemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaDataSet7.TBL_ISLEM' table. You can move, or remove it, as needed.
            this.tBL_ISLEMTableAdapter.Fill(this.bankaDataSet7.TBL_ISLEM);

        }
    }
}
