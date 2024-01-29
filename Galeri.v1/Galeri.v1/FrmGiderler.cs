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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtId.Text = "";
            CmbAy.Text = "";
            CmbYil.Text = "";
            TxtElektrik.Text = "";
            TxtSu.Text = "";
            TxtDogalgaz.Text = "";
            TxtInternet.Text = "";
            TxtKira.Text = "";
            TxtMaaslar.Text = "";
            TxtEkstra.Text = "";
            RchNotlar.Text = "";
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                CmbAy.Text = dr["AY"].ToString();
                CmbYil.Text = dr["YIL"].ToString();
                TxtElektrik.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtDogalgaz.Text = dr["DOGALGAZ"].ToString();
                TxtInternet.Text = dr["INTERNET"].ToString();
                TxtKira.Text = dr["KIRA"].ToString();
                TxtMaaslar.Text = dr["MAASLAR"].ToString();
                TxtEkstra.Text = dr["EKSTRA"].ToString();
                RchNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_GIDERLER  (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,KIRA,MAASLAR,EKSTRA,NOTLAR)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", CmbAy.Text);
            kmt.Parameters.AddWithValue("@p2", CmbYil.Text);
            kmt.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
            kmt.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
            kmt.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
            kmt.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
            kmt.Parameters.AddWithValue("@p7", decimal.Parse(TxtKira.Text));
            kmt.Parameters.AddWithValue("@p8", decimal.Parse(TxtMaaslar.Text));
            kmt.Parameters.AddWithValue("@p9", decimal.Parse(TxtEkstra.Text));
            kmt.Parameters.AddWithValue("@p10", RchNotlar.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Tabloya Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_GIDERLER set  AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,KIRA=@P7,MAASLAR=@P8,EKSTRA=@P9,NOTLAR=@P10  where ID=@P11", bgl.baglanti());

            kmt.Parameters.AddWithValue("@P1", CmbAy.Text);
            kmt.Parameters.AddWithValue("@P2", CmbYil.Text);
            kmt.Parameters.AddWithValue("@P3", decimal.Parse(TxtElektrik.Text));
            kmt.Parameters.AddWithValue("@P4", decimal.Parse(TxtSu.Text));
            kmt.Parameters.AddWithValue("@P5", decimal.Parse(TxtDogalgaz.Text));
            kmt.Parameters.AddWithValue("@P6", decimal.Parse(TxtInternet.Text));
            kmt.Parameters.AddWithValue("@P7", decimal.Parse(TxtKira.Text));
            kmt.Parameters.AddWithValue("@P8", decimal.Parse(TxtMaaslar.Text));
            kmt.Parameters.AddWithValue("@P9", decimal.Parse(TxtEkstra.Text));
            kmt.Parameters.AddWithValue("@P10", RchNotlar.Text);
            kmt.Parameters.AddWithValue("@P11", TxtId.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }
    }
}
