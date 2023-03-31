using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemekhane_Kayıt_Programı
{
    class VtConnection
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=MELISA;Initial Catalog=Yemekhane_Kayit_programi;Integrated Security=True");

            baglan.Open();

            return baglan;
        }
    }
}
