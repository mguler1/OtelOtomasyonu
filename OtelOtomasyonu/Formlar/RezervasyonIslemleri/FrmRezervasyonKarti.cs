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

namespace OtelOtomasyonu.Formlar.RezervasyonIslemleri
{
    public partial class FrmRezervasyonKarti : Form
    {
        public FrmRezervasyonKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<Tbl_Rezervasyon> repo = new Repository<Tbl_Rezervasyon>();
        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {
            lookUpEditMisafir.Properties.DataSource = (from x in db.Tbl_Misafir select new { x.MisafirId, x.AdSoyad }).ToList();
            lookUpEditDurum.Properties.DataSource = (from x in db.Tbl_Durum select new { x.DurumId, x.DurumAd }).ToList();
            lookUpEditOda.Properties.DataSource = (from x in db.Tbl_Oda select new { x.OdaId, x.OdaNo,x.Tbl_Durum.DurumAd }).Where(y=>y.DurumAd=="Aktif").ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_Rezervasyon t = new Tbl_Rezervasyon();
                t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
                t.GirisTarihi =DateTime.Parse(dateEditGiris.Text);
                t.CikisTarihi =DateTime.Parse(dateEditCikis.Text);
                t.KisiSayisi = nmrKisiSayisi.Value.ToString();
                t.Telefon = txtTelefon.Text;
                t.Oda = int.Parse(lookUpEditOda.EditValue.ToString());
                t.Aciklama = txtAciklama.Text;
                t.RezervasyonAdSoyad = txtRezervasyonAdSoyad.Text;
                t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
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
