using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatırBank
{
    internal class Connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-U2DQVDR\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
