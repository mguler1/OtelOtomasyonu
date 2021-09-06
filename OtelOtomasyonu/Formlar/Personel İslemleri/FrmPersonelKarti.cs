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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Repository<Tbl_Personel> repo = new Repository<Tbl_Personel>();
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
        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            lookUpEditDepartman.Properties.DataSource = (from x in db.Tbl_Departman select new { x.DepartmanId, x.DepartmanAd }).ToList();
            lookUpEditGorev.Properties.DataSource = (from x in db.Tbl_Gorev select new { x.GorevId, x.GorevAd }).ToList();
        }
    }
}
