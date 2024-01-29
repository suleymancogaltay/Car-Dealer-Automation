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
using DevExpress.Charts;

namespace Galeri.v1
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        
        public string ad;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            LblAktifKullanici.Text = ad;

            listele();
            //Son ayın faturaları
            SqlCommand komut2 = new SqlCommand("Select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblOdemeler.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //Toplam Tutar Hesaplama
            SqlCommand komut1 = new SqlCommand("select Sum(TUTAR) from TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKasa.Text = dr1[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //Son ayın personel Maaşları
            SqlCommand komut3 = new SqlCommand("Select MAASLAR from TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblPersonelMaasları.Text = dr3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            // Toplam Müşteri Sayısı

            SqlCommand komut4 = new SqlCommand("Select Count(*) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Müşteri Şehir Sayısı
            SqlCommand komut7 = new SqlCommand("Select Count(Distinct(IL)) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LblMusteriSehirSayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

           
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //ELEKTRIK
            if (sayac > 0 && sayac <= 5)
            {
                groupControl10.Text = "ELEKTRİK";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            //SU
            else if (sayac > 5 && sayac <= 10)
            {
                groupControl10.Text = "SU";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //DOGALGAZ
            else if (sayac > 10 && sayac <= 15)
            {
                groupControl10.Text = "DOĞALGAZ";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //INTERNET
            else if (sayac > 15 && sayac <= 20)
            {
                groupControl10.Text = "İNTERNET";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }

            //EKSTRA
            else if (sayac > 20 && sayac <= 25)
            {
                groupControl10.Text = "EKSTRA";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            else
                sayac = 0;
        }
        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;

            //ELEKTRIK
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "ELEKTRİK";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            //SU
            else if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl11.Text = "SU";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,SU from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //DOGALGAZ
            else if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl11.Text = "DOĞALGAZ";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("select top 4 AY,DOGALGAZ from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();
                while (dr12.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgl.baglanti().Close();
            }
            //INTERNET
            else if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl11.Text = "İNTERNET";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 4 AY,INTERNET from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }

            //EKSTRA
            else if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl11.Text = "EKSTRA";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 4 AY,EKSTRA from TBL_GIDERLER order by ID Desc", bgl.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();
                while (dr13.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgl.baglanti().Close();
            }
            else
                sayac2 = 0;
        }

        private void LblAktifKullanici_Click(object sender, EventArgs e)
        {
           
        }
    }
}
