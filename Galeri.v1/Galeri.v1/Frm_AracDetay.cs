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
    public partial class Frm_AracDetay : Form
    {
        public string id;
        sqlbaglanti bgl = new sqlbaglanti();
        public Frm_AracDetay()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_ARACDETAY where ARACDETAYID='" + id+"'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Frm_AracDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtAracId.Text = dr["ARACDETAYID"].ToString();
                MskAlınanTarih.Text = dr["ALINDIGITARIH"].ToString();
                TxtRenk.Text = dr["RENK"].ToString();
                TxtKasaTipi.Text = dr["KASATIPI"].ToString();
                TxtYakit.Text = dr["YAKIT"].ToString();
                TxtVites.Text = dr["VITES"].ToString();
                TxtMotorTipi.Text = dr["MOTORTIPI"].ToString();
                TxtMotorGucu.Text = dr["MOTORGUCU"].ToString();
                TxtMotorHacmi.Text = dr["MOTORHACMI"].ToString();
                TxtSehirIci.Text = dr["SEHIRICI"].ToString();
                TxtSehirdisi.Text = dr["SEHIRDISI"].ToString();
                TxtOrtalama.Text = dr["ORTALAMA"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_ARACDETAY set ALINDIGITARIH=@P1,RENK=@P2,KASATIPI=@P3,YAKIT=@P4,VITES=@P5,MOTORTIPI=@P6,MOTORGUCU=@P7,MOTORHACMI=@P8,SEHIRICI=@P9,SEHIRDISI=@P10,ORTALAMA=@P11,DETAY=@P12 where ARACDETAYID=@P13", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", MskAlınanTarih.Text);
            kmt.Parameters.AddWithValue("@P2", TxtRenk.Text);
            kmt.Parameters.AddWithValue("@P3", TxtKasaTipi.Text);
            kmt.Parameters.AddWithValue("@P4", TxtYakit.Text);
            kmt.Parameters.AddWithValue("@P5", TxtVites.Text);
            kmt.Parameters.AddWithValue("@P6", TxtMotorTipi.Text);
            kmt.Parameters.AddWithValue("@P7", TxtMotorGucu.Text);
            kmt.Parameters.AddWithValue("@P8", TxtMotorHacmi.Text);
            kmt.Parameters.AddWithValue("@P9", TxtSehirIci.Text);
            kmt.Parameters.AddWithValue("@P10", TxtSehirdisi.Text);
            kmt.Parameters.AddWithValue("@P11", TxtOrtalama.Text);
            kmt.Parameters.AddWithValue("@P12", RchDetay.Text);
            kmt.Parameters.AddWithValue("@P13", TxtAracId.Text);
            kmt.ExecuteNonQuery();
            listele();

            bgl.baglanti().Close();
            MessageBox.Show("Araç Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
