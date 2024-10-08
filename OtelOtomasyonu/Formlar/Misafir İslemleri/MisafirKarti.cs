﻿using DevExpress.XtraEditors;
using OtelOtomasyonu.Entity;
using OtelOtomasyonu.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Formlar.Misafir_İslemleri
{
    public partial class MisafirKarti : Form
    {
        public MisafirKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<Tbl_Misafir> repo = new Repository<Tbl_Misafir>();
        public int id;
        private void MisafirKarti_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            if (id != 0)
            {
                var misafir = repo.Find(x => x.MisafirId == id);
                txtAdSoyad.Text = misafir.AdSoyad;
                txtTc.Text = misafir.Tc;
                txtAdres.Text = misafir.Adres;
                txtTelefon.Text = misafir.Telefon;
                txtMail.Text = misafir.Mail;
                txtAciklama.Text = misafir.Aciklama;

                pictureEdit13.Image = Image.FromFile(misafir.KimlikFoto1);
                pictureEdit14.Image = Image.FromFile(misafir.KimlikFoto2);
                label1.Text = misafir.KimlikFoto1;
                label2.Text = misafir.KimlikFoto2;
                lookUpEditUlke.EditValue = misafir.Ulke;
                lookUpEditSehir.EditValue = misafir.Sehir;
                lookUpEditIlce.EditValue = misafir.Ilce;
                //     label1.Text = misafir.KimlikOn;

                lookUpEditUlke.Properties.DataSource = (from x in db.Tbl_Ulke select new { x.UlkeId, x.UlkeAd }).ToList();
                lookUpEditSehir.Properties.DataSource = (from x in db.iller select new { x.id, x.sehir }).ToList();
            }

        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from x in db.ilceler select new { x.id, x.ilce, x.sehir }).Where(y => y.sehir == secilen).ToList();
        }


        string resim1, resim2;

        private void pictureEdit13_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = label1.Text = pictureEdit13.GetLoadedImageLocation().ToString();
        }

        private void pictureEdit14_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = label2.Text = pictureEdit14.GetLoadedImageLocation().ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            var deger = repo.Find(x => x.MisafirId == id);
            deger.AdSoyad = txtAdSoyad.Text;
            deger.Tc = txtTc.Text;
            deger.Adres = txtAdres.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Mail = txtMail.Text;
            deger.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            deger.Sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.Ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
            deger.KimlikFoto1 = label1.Text;
            deger.KimlikFoto2 = label2.Text;
            deger.Aciklama = txtAciklama.Text;
            deger.Durum = 1;
            repo.Update(deger);
            XtraMessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_Misafir t = new Tbl_Misafir();
                t.AdSoyad = txtAdSoyad.Text;
                t.Tc = txtTc.Text;
                t.Adres = txtAdres.Text;
                t.Telefon = txtTelefon.Text;
                t.Mail = txtMail.Text;
                t.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
                t.Sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
                t.Ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
                t.KimlikFoto1 = resim1;
                t.KimlikFoto2 = resim2;
                t.Aciklama = txtAciklama.Text;
                t.Durum = 1;
                repo.Add(t);
                XtraMessageBox.Show("Kayıt İşlemi Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
