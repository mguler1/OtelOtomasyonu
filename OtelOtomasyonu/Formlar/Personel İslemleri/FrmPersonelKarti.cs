using DevExpress.XtraEditors;
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

namespace OtelOtomasyonu.Formlar.Personel_İslemleri
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }
        Repository<Tbl_Personel> repo = new Repository<Tbl_Personel>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_Personel t = new Tbl_Personel();
                t.AdSoyad = txtAdSoyad.Text;
                t.Tc = txtTc.Text;
                t.Adres = txtAdres.Text;
                t.Telefon = txtTelefon.Text;
                t.Mail = txtMail.Text;
                t.IseGirisTarihi = DateTime.Parse(dateGiris.Text);
                // t.IstenCikisTarihi =DateTime.Parse(dateCikis.Text);
                t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
                t.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
                t.KimlikOn = pictureEdit13.GetLoadedImageLocation();
                t.KimlikArka = pictureEdit14.GetLoadedImageLocation();
                t.Sifre = txtSifre.Text;
                //t.Yetki =;
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
        DbOtelEntities db = new DbOtelEntities();
        public int id;
        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            if (id!=0)
            {
                var personel = repo.Find(x => x.PersonelId == id);
                txtAdSoyad.Text = personel.AdSoyad;
                txtTc.Text = personel.Tc;
                txtAdres.Text = personel.Adres;
                txtTelefon.Text = personel.Telefon;
                txtMail.Text = personel.Mail;
                dateGiris.Text =personel.IseGirisTarihi.ToString();
                dateCikis.Text = personel.IstenCikisTarihi.ToString();
                txtAciklama.Text = personel.Aciklama;
                txtSifre.Text = personel.Sifre;
                pictureEdit13.Image = Image.FromFile(personel.KimlikOn);
                pictureEdit14.Image = Image.FromFile(personel.KimlikArka);
                label1.Text = personel.KimlikOn;
                label2.Text = personel.KimlikArka;
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;
                label1.Text = personel.KimlikOn;

            }
            lookUpEditDepartman.Properties.DataSource = (from x in db.Tbl_Departman select new { x.DepartmanId, x.DepartmanAd }).ToList();
            lookUpEditGorev.Properties.DataSource = (from x in db.Tbl_Gorev select new { x.GorevId, x.GorevAd }).ToList();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelId == id);
            deger.AdSoyad = txtAdSoyad.Text;
            deger.Tc = txtTc.Text;
            deger.Adres = txtAdres.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Mail = txtMail.Text;
            deger.IseGirisTarihi = DateTime.Parse(dateGiris.Text);
            deger.IstenCikisTarihi =DateTime.Parse(dateCikis.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.KimlikOn = label1.Text;
            deger.KimlikArka = label2.Text;
            deger.Sifre = txtSifre.Text;
            deger.Aciklama = txtAciklama.Text;
            deger.Durum = 1;
            repo.Update(deger);
            XtraMessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void pictureEdit13_EditValueChanged(object sender, EventArgs e)
        {
            label1.Text = pictureEdit13.GetLoadedImageLocation().ToString();
        }

        private void pictureEdit14_EditValueChanged(object sender, EventArgs e)
        {
            label2.Text = pictureEdit14.GetLoadedImageLocation().ToString();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
