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
    public partial class TemsilciMusteriİslem : Form
    {
        public TemsilciMusteriİslem()
        {
            InitializeComponent();
        }
        Connection connection = new Connection();
        public int id = 0;
        private void TemsilciMusteriİslem_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_ISLEM Inner Join TBL_MUSTERI_MUDUR on " +
                "TBL_MUSTERI_MUDUR.NO = TBL_ISLEM.MUSTERI_NO where TBL_MUSTERI_MUDUR.MUSTERI_TEMSILCISI_NO = "+id, connection.baglanti());
        }
    }
}
