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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            TxtUrunId.Text = urunid;
            SqlCommand komut = new SqlCommand("Select * from TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtFiyat.Text = dr[3].ToString();
                TxtMiktar.Text = dr[2].ToString();
                TxtTutar.Text = dr[4].ToString();
                TxtUrunAd.Text = dr[1].ToString();
                bgl.baglanti().Close();
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 where FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P5", TxtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FATURADETAY where FATURAURUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }
    }
}
