using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Galeri.v1
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            
            SqlConnection baglan = new SqlConnection(@"Data Source = LAPTOP-6VVJHAMP\SQLEXPRESS; Initial Catalog = galeri; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
