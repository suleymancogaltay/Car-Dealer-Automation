
namespace Galeri.v1
{
    partial class FrmFaturalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtFaturaId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.TxtFirma = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtPersonel = new System.Windows.Forms.TextBox();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTeslimAlan = new System.Windows.Forms.TextBox();
            this.TxtTeslimEden = new System.Windows.Forms.TextBox();
            this.TxtAlici = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtVergiDaire = new System.Windows.Forms.TextBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSiraNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSeri = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1129, 627);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1130, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(404, 625);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.BtnKaydet);
            this.xtraTabPage2.Controls.Add(this.label13);
            this.xtraTabPage2.Controls.Add(this.label14);
            this.xtraTabPage2.Controls.Add(this.label15);
            this.xtraTabPage2.Controls.Add(this.label16);
            this.xtraTabPage2.Controls.Add(this.label17);
            this.xtraTabPage2.Controls.Add(this.label18);
            this.xtraTabPage2.Controls.Add(this.label19);
            this.xtraTabPage2.Controls.Add(this.TxtFaturaId);
            this.xtraTabPage2.Controls.Add(this.label12);
            this.xtraTabPage2.Controls.Add(this.TxtUrunId);
            this.xtraTabPage2.Controls.Add(this.TxtFirma);
            this.xtraTabPage2.Controls.Add(this.TxtUrunAd);
            this.xtraTabPage2.Controls.Add(this.TxtMiktar);
            this.xtraTabPage2.Controls.Add(this.TxtPersonel);
            this.xtraTabPage2.Controls.Add(this.TxtFiyat);
            this.xtraTabPage2.Controls.Add(this.TxtTutar);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(402, 595);
            this.xtraTabPage2.Text = "Fatura Detayları";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(153, 481);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 54);
            this.BtnKaydet.TabIndex = 58;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(59, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ürün Ad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.Location = new System.Drawing.Point(75, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Miktar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label15.Location = new System.Drawing.Point(87, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Fiyat:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label16.Location = new System.Drawing.Point(82, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 24);
            this.label16.TabIndex = 30;
            this.label16.Text = "Tutar:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label17.Location = new System.Drawing.Point(54, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 24);
            this.label17.TabIndex = 32;
            this.label17.Text = "Personel:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label18.Location = new System.Drawing.Point(80, 372);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 24);
            this.label18.TabIndex = 34;
            this.label18.Text = "Firma:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label19.Location = new System.Drawing.Point(46, 420);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 24);
            this.label19.TabIndex = 36;
            this.label19.Text = "Fatura ID:";
            // 
            // TxtFaturaId
            // 
            this.TxtFaturaId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtFaturaId.Location = new System.Drawing.Point(153, 417);
            this.TxtFaturaId.Name = "TxtFaturaId";
            this.TxtFaturaId.Size = new System.Drawing.Size(194, 32);
            this.TxtFaturaId.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(61, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ürün ID:";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtUrunId.Location = new System.Drawing.Point(153, 81);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(194, 32);
            this.TxtUrunId.TabIndex = 23;
            // 
            // TxtFirma
            // 
            this.TxtFirma.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtFirma.Location = new System.Drawing.Point(153, 369);
            this.TxtFirma.Name = "TxtFirma";
            this.TxtFirma.Size = new System.Drawing.Size(194, 32);
            this.TxtFirma.TabIndex = 35;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtUrunAd.Location = new System.Drawing.Point(153, 129);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(194, 32);
            this.TxtUrunAd.TabIndex = 25;
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtMiktar.Location = new System.Drawing.Point(153, 177);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(194, 32);
            this.TxtMiktar.TabIndex = 27;
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtPersonel.Location = new System.Drawing.Point(153, 321);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(194, 32);
            this.TxtPersonel.TabIndex = 33;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtFiyat.Location = new System.Drawing.Point(153, 225);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(194, 32);
            this.TxtFiyat.TabIndex = 29;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtTutar.Location = new System.Drawing.Point(153, 273);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(194, 32);
            this.TxtTutar.TabIndex = 31;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl3);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(402, 595);
            this.xtraTabPage1.Text = "Fatura Bilgileri";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.BtnGuncelle);
            this.groupControl3.Controls.Add(this.BtnTemizle);
            this.groupControl3.Controls.Add(this.BtnSil);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.TxtTeslimAlan);
            this.groupControl3.Controls.Add(this.TxtTeslimEden);
            this.groupControl3.Controls.Add(this.TxtAlici);
            this.groupControl3.Location = new System.Drawing.Point(0, 346);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(403, 249);
            this.groupControl3.TabIndex = 2;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(60, 198);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(308, 41);
            this.BtnGuncelle.TabIndex = 64;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(225, 148);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(143, 44);
            this.BtnTemizle.TabIndex = 63;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(60, 148);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(159, 44);
            this.BtnSil.TabIndex = 61;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(115, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alıcı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(42, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Teslim Eden:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(47, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Teslim Alan:";
            // 
            // TxtTeslimAlan
            // 
            this.TxtTeslimAlan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtTeslimAlan.Location = new System.Drawing.Point(174, 110);
            this.TxtTeslimAlan.Name = "TxtTeslimAlan";
            this.TxtTeslimAlan.Size = new System.Drawing.Size(194, 32);
            this.TxtTeslimAlan.TabIndex = 17;
            // 
            // TxtTeslimEden
            // 
            this.TxtTeslimEden.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtTeslimEden.Location = new System.Drawing.Point(174, 72);
            this.TxtTeslimEden.Name = "TxtTeslimEden";
            this.TxtTeslimEden.Size = new System.Drawing.Size(194, 32);
            this.TxtTeslimEden.TabIndex = 15;
            // 
            // TxtAlici
            // 
            this.TxtAlici.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtAlici.Location = new System.Drawing.Point(174, 34);
            this.TxtAlici.Name = "TxtAlici";
            this.TxtAlici.Size = new System.Drawing.Size(194, 32);
            this.TxtAlici.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.TxtVergiDaire);
            this.groupControl2.Controls.Add(this.MskSaat);
            this.groupControl2.Controls.Add(this.MskTarih);
            this.groupControl2.Location = new System.Drawing.Point(0, 171);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(403, 169);
            this.groupControl2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(105, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(111, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(51, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vergi Daire:";
            // 
            // TxtVergiDaire
            // 
            this.TxtVergiDaire.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtVergiDaire.Location = new System.Drawing.Point(174, 121);
            this.TxtVergiDaire.Name = "TxtVergiDaire";
            this.TxtVergiDaire.Size = new System.Drawing.Size(194, 32);
            this.TxtVergiDaire.TabIndex = 9;
            // 
            // MskSaat
            // 
            this.MskSaat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.MskSaat.Location = new System.Drawing.Point(174, 83);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(194, 32);
            this.MskSaat.TabIndex = 11;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Tahoma", 12F);
            this.MskTarih.Location = new System.Drawing.Point(174, 45);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(194, 32);
            this.MskTarih.TabIndex = 10;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.TxtSiraNo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.TxtSeri);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Location = new System.Drawing.Point(0, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(403, 162);
            this.groupControl1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(117, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(87, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sıra No:";
            // 
            // TxtSiraNo
            // 
            this.TxtSiraNo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtSiraNo.Location = new System.Drawing.Point(174, 121);
            this.TxtSiraNo.Name = "TxtSiraNo";
            this.TxtSiraNo.Size = new System.Drawing.Size(194, 32);
            this.TxtSiraNo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(130, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // TxtSeri
            // 
            this.TxtSeri.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtSeri.Location = new System.Drawing.Point(174, 80);
            this.TxtSeri.Name = "TxtSeri";
            this.TxtSeri.Size = new System.Drawing.Size(194, 32);
            this.TxtSeri.TabIndex = 9;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TxtId.Location = new System.Drawing.Point(174, 42);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(194, 32);
            this.TxtId.TabIndex = 7;
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 626);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFaturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTeslimAlan;
        private System.Windows.Forms.TextBox TxtTeslimEden;
        private System.Windows.Forms.TextBox TxtAlici;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtVergiDaire;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSiraNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSeri;
        private System.Windows.Forms.TextBox TxtId;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtFaturaId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.TextBox TxtFirma;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtPersonel;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtTutar;
    }
}