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
    public partial class FrmArac : Form
    {
        public FrmArac()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ARAC", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtId.Text = "";
            TxtMarka.Text = "";
            TxtSeri.Text = "";
            TxtModel.Text = "";
            MskYil.Text = "";
            TxtKm.Text = "";
            TxtPlaka.Text = "";
            TxtAlisFiyat.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmArac_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_ARAC(MARKA,SERI,MODEL,YIL,KM,PLAKA,ALISFIYAT) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtMarka.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSeri.Text);
            kmt.Parameters.AddWithValue("@p3", TxtModel.Text);
            kmt.Parameters.AddWithValue("@p4", MskYil.Text);
            kmt.Parameters.AddWithValue("@p5", TxtKm.Text);
            kmt.Parameters.AddWithValue("@p6", TxtPlaka.Text);
            kmt.Parameters.AddWithValue("@p7", TxtAlisFiyat.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            temizle();
            MessageBox.Show("Araç Bilgisi Sisteme Eklendi. Detay eklemek için çift tıklayın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete from TBL_ARAC where ID=@P1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", TxtId.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            temizle();
            MessageBox.Show("Araç Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_ARAC set MARKA=@P1,SERI=@P2,MODEL=@P3,YIL=@P4,KM=@P5,PLAKA=@P6,ALISFIYAT=@P7 where ID=@P8", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", TxtMarka.Text);
            kmt.Parameters.AddWithValue("@P2", TxtSeri.Text);
            kmt.Parameters.AddWithValue("@P3", TxtModel.Text);
            kmt.Parameters.AddWithValue("@P4", MskYil.Text);
            kmt.Parameters.AddWithValue("@P5", TxtKm.Text);
            kmt.Parameters.AddWithValue("@P6", TxtPlaka.Text);
            kmt.Parameters.AddWithValue("@P7", TxtAlisFiyat.Text);
            kmt.Parameters.AddWithValue("@P8", TxtId.Text);
            kmt.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Araç Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtMarka.Text = dr["MARKA"].ToString();
                TxtSeri.Text = dr["SERI"].ToString();
                TxtModel.Text = dr["MODEL"].ToString();
                MskYil.Text = dr["YIL"].ToString();
                TxtKm.Text = dr["KM"].ToString();
                TxtPlaka.Text = dr["PLAKA"].ToString();
                TxtAlisFiyat.Text = dr["ALISFIYAT"].ToString();


            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_AracDetay fr = new Frm_AracDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["ID"].ToString();
            }
            fr.Show();
        }
    }
}
