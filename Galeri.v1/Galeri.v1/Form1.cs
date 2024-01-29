using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri.v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FrmAnaSayfa fr1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new FrmAnaSayfa();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }
        public string ad1;
        public string kullanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = kullanici;
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new FrmAnaSayfa();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }
        FrmArac fr2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new FrmArac();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FrmMusteriler fr3;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new FrmMusteriler();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        FrmGiderler fr4;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new FrmGiderler();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        FrmFaturalar fr5;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new FrmFaturalar();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        FrmKasa fr10;        
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new FrmKasa();
                fr10.MdiParent = this;
                fr10.ad = kullanici;
                fr10.Show();
            }
        }
        FrmRehber fr6;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new FrmRehber();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        FrmNotlar fr7;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new FrmNotlar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        FrmHareketler fr9;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new FrmHareketler();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        FrmAyarlar fr8;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new FrmAyarlar();
               // fr8.MdiParent = this;
                fr8.Show();
            }
        }
    }
}
