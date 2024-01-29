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
using System.Xml;

namespace Galeri.v1
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 5 TARIH,SAAT,BASLIK FROM TBL_NOTLAR ORDER BY ID DESC", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;

        }
        void Araclar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 10 MARKA,SERI,MODEL,YIL,PLAKA FROM TBL_ARAC ORDER BY ID DESC", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        void Fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 8 AD,SOYAD,TELEFON1 FROM TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");
            Haberler();
            Ajanda();
            Araclar();
            Fihrist();
        }
    }
}
