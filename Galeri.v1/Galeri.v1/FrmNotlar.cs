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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtId.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            TxtBaslik.Text = "";
            RchDetay.Text = "";
            TxtOlusturan.Text = "";
            TxtHitap.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_NOTLAR(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTarih.Text);
            kmt.Parameters.AddWithValue("@p2", MskSaat.Text);
            kmt.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            kmt.Parameters.AddWithValue("@p4", RchDetay.Text);
            kmt.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            kmt.Parameters.AddWithValue("@p6", TxtHitap.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Notunuz Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete from TBL_NOTLAR where ID=@P1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", TxtId.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Notunuz Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update TBL_NOTLAR set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@p7", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", MskTarih.Text);
            kmt.Parameters.AddWithValue("@p2", MskSaat.Text);
            kmt.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            kmt.Parameters.AddWithValue("@p4", RchDetay.Text);
            kmt.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            kmt.Parameters.AddWithValue("@p6", TxtHitap.Text);
            kmt.Parameters.AddWithValue("@p7", TxtId.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Notunuz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtBaslik.Text = dr["BASLIK"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
                TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
                TxtHitap.Text = dr["HITAP"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
