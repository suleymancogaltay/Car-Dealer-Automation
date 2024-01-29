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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTelefon.Text = "";
            MskTelefon2.Text = "";
            MskTc.Text = "";
            TxtMail.Text = "";
            CbeIl.Text = "";
            CbeIlce.Text = "";
            RchAdres.Text = "";
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            sehirlerlistesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_MUSTERILER(AD,SOYAD,TELEFON1,TELEFON2,TC,MAIL,IL,ILCE,ADRES) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtAd.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", MskTelefon.Text);
            kmt.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            kmt.Parameters.AddWithValue("@p5", MskTc.Text);
            kmt.Parameters.AddWithValue("@p6", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p7", CbeIl.Text);
            kmt.Parameters.AddWithValue("@p8", CbeIlce.Text);
            kmt.Parameters.AddWithValue("@p9", RchAdres.Text);

            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Müşteri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete from TBL_MUSTERILER where ID=@P1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", TxtId.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Müşteri listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update TBL_MUSTERILER set AD=@P1,SOYAD=@P2,TELEFON1=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9 WHERE ID=@P10", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TxtAd.Text);
            kmt.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmt.Parameters.AddWithValue("@p3", MskTelefon.Text);
            kmt.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            kmt.Parameters.AddWithValue("@p5", MskTc.Text);
            kmt.Parameters.AddWithValue("@p6", TxtMail.Text);
            kmt.Parameters.AddWithValue("@p7", CbeIl.Text);
            kmt.Parameters.AddWithValue("@p8", CbeIlce.Text);
            kmt.Parameters.AddWithValue("@p9", RchAdres.Text);
            kmt.Parameters.AddWithValue("p10", TxtId.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon.Text = dr["TELEFON1"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                CbeIl.Text = dr["IL"].ToString();
                CbeIlce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();

            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void sehirlerlistesi()
        {
            SqlCommand komut = new SqlCommand("Select sehir From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CbeIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        

        private void CbeIl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CbeIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ilce from TBL_ILCELER where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CbeIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CbeIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }
    }
    }

