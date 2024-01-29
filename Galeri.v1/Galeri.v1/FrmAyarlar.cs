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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ADMIN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtKulllaniciAd.Text = dr["KULLANICIADI"].ToString();

                TxtSifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values (@P1,@P2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtKulllaniciAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Kullanıcı Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete from TBL_ADMIN where KULLANICIADI=@P1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", TxtKulllaniciAd.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Kullanıcı Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update TBL_ADMIN set SIFRE=@P2 where KULLANICIADI=@P1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@P1", TxtKulllaniciAd.Text);
            komut1.Parameters.AddWithValue("@P2", TxtSifre.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı Bilgileri Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
           
        }
    }
}
