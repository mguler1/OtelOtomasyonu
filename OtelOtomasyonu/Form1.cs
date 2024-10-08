﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDurumTanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmDurum d = new Formlar.Tanımlar.FrmDurum();
            d.Show();
        }

     

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmDepartman d = new Formlar.Tanımlar.FrmDepartman();
            d.Show();
        }

        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmBirim b = new Formlar.Tanımlar.FrmBirim();
            b.Show();
        }

        private void BtnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmGorev g = new Formlar.Tanımlar.FrmGorev();
            g.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmKasa k = new Formlar.Tanımlar.FrmKasa();
            k.Show();
        }

        private void BtnKurTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmKur k = new Formlar.Tanımlar.FrmKur();
            k.Show();
        }

        private void BtnOdaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmOda o = new Formlar.Tanımlar.FrmOda();
            o.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlar.FrmUrunGrup x = new Formlar.Tanımlar.FrmUrunGrup();
            x.Show();
        }

        private void BtnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.Personel_İslemleri.FrmPersonelKarti pk = new Formlar.Personel_İslemleri.FrmPersonelKarti();
            pk.Show();          
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel_İslemleri.PersonelListesi pl = new Formlar.Personel_İslemleri.PersonelListesi();
            pl.MdiParent = this;
            pl.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir_İslemleri.MisafirKarti mk = new Formlar.Misafir_İslemleri.MisafirKarti();
            mk.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir_İslemleri.FrmMisafirListesi ml = new Formlar.Misafir_İslemleri.FrmMisafirListesi();
            ml.MdiParent = this;
            ml.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunIslemleri.FrmUrunListesi ul = new Formlar.UrunIslemleri.FrmUrunListesi();
            ul.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunIslemleri.FrmUrunKarti uk = new Formlar.UrunIslemleri.FrmUrunKarti();
            uk.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunIslemleri.FrmUrunGiris ug = new Formlar.UrunIslemleri.FrmUrunGiris();
            ug.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunIslemleri.FrmUrunCikis ug = new Formlar.UrunIslemleri.FrmUrunCikis();
            ug.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunIslemleri.FrmUrunHareketTanimi uh = new Formlar.UrunIslemleri.FrmUrunHareketTanimi();
            uh.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.RezervasyonIslemleri.FrmRezervasyonKarti uh = new Formlar.RezervasyonIslemleri.FrmRezervasyonKarti();
            uh.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.RezervasyonIslemleri.FrmTumRezervasyonlar tr = new Formlar.RezervasyonIslemleri.FrmTumRezervasyonlar();
            tr.MdiParent = this;
            tr.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.RezervasyonIslemleri.FrmAktifRezervasyonlar ar = new Formlar.RezervasyonIslemleri.FrmAktifRezervasyonlar();
            ar.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.RezervasyonIslemleri.FrmIptalEdilenRezervasyonlar ir = new Formlar.RezervasyonIslemleri.FrmIptalEdilenRezervasyonlar();
            ir.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.RezervasyonIslemleri.FrmGecmisRezervasyonlar gr = new Formlar.RezervasyonIslemleri.FrmGecmisRezervasyonlar();
            gr.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.RezervasyonIslemleri.FrmGelecekRezervasyonlar uh = new Formlar.RezervasyonIslemleri.FrmGelecekRezervasyonlar();
            uh.Show();
        }
    }
}
