using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Galeri.v1
{
    public partial class FrmFaturaUrunler : Form
    {
        public FrmFaturaUrunler()
        {
            InitializeComponent();
        }
        public string id;
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURAURUNID='" + id + "'", bgl.baglanti());//sql tabanında sorgulama yaparken eşitlik eğer sayısal bir ifade değilse o zaman tek tırnak içerisinde yazıyor, c#da da tek tırnak tek başına kullanılamadığı için çift tırnak blokları arasına yazılır
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }        private void FrmFaturaUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDuzenleme fr = new FrmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.urunid = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
        }
    }
}
