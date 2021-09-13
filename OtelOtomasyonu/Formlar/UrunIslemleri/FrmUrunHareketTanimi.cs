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

namespace OtelOtomasyonu.Formlar.UrunIslemleri
{
    public partial class FrmUrunHareketTanimi : Form
    {
        public FrmUrunHareketTanimi()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<Tbl_UrunHareket> repo = new Repository<Tbl_UrunHareket>();
        public int id;
        private void FrmUrunHareketTanimi_Load(object sender, EventArgs e)
        {
            txtId.Text = id.ToString();
            txtId.Enabled = false;
            if (id!=0)
            {
                var urun = repo.Find(x => x.HareketId == id);
                lookUpEditUrun.EditValue = urun.Urun;
                txtMiktar.Text = urun.Miktar.ToString();
                txtAciklama.Text = urun.Aciklama;
                cmbHareket.Text = urun.HareketTuru;
                dateEdit1.Text = urun.Tarih.ToString();
            }

            lookUpEditUrun.Properties.DataSource = (from x in db.Tbl_Urun select new { x.UrunId, x.UrunAd }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_UrunHareket t = new Tbl_UrunHareket();
            t.Urun =int.Parse(lookUpEditUrun.EditValue.ToString());
            t.Tarih =DateTime.Parse(dateEdit1.Text);
            t.HareketTuru = cmbHareket.Text;
            t.Miktar =decimal.Parse(txtMiktar.Text);
            t.Aciklama = txtAciklama.Text;
            repo.Add(t);
            XtraMessageBox.Show("Kaydetme İşlemi Başarılı");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var t = repo.Find(x => x.HareketId == id);
            t.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            t.Tarih = DateTime.Parse(dateEdit1.Text);
            t.HareketTuru = cmbHareket.Text;
            t.Miktar = decimal.Parse(txtMiktar.Text);
            t.Aciklama = txtAciklama.Text;
            repo.Update(t);
            XtraMessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
