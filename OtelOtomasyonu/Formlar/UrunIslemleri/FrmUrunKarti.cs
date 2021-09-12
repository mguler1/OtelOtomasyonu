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
    public partial class FrmUrunKarti : Form
    {
        public FrmUrunKarti()
        {
            InitializeComponent();
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<Tbl_Urun> repo = new Repository<Tbl_Urun>();
        public int id;
        private void FrmUrunKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var t = repo.Find(x => x.UrunId == id);
                txtUrunAd.Text = t.UrunAd;
                lookUpEditGrup.EditValue = t.UrunGrup;
                lookUpEditDurum.EditValue = t.Durum;
                lookUpEditBirim.EditValue = t.Birim;
                txtFiyat.Text = t.Fiyat.ToString();
                txtToplam.Text = t.Toplam.ToString();
                txtKdv.Text = t.Kdv.ToString();

            }
            lookUpEditBirim.Properties.DataSource = (from x in db.Tbl_Birim select new { x.BirimId, x.BirimAd }).ToList();
            lookUpEditGrup.Properties.DataSource = (from x in db.Tbl_UrunGrup select new { x.UrunGrupId, x.UrunGrupAd }).ToList();
            lookUpEditDurum.Properties.DataSource = (from x in db.Tbl_Durum select new { x.DurumId, x.DurumAd }).ToList();

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_Urun t = new Tbl_Urun();
                t.UrunAd = txtUrunAd.Text;
                t.UrunGrup = int.Parse(lookUpEditGrup.EditValue.ToString());
                t.Birim = int.Parse(lookUpEditBirim.EditValue.ToString());
                t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
                t.Fiyat = decimal.Parse(txtFiyat.Text);
                t.Toplam = decimal.Parse(txtToplam.Text);
                t.Kdv = byte.Parse(txtKdv.Text);
                repo.Add(t);
                XtraMessageBox.Show("Kaydetme İşlemi Başarılı");
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var t = repo.Find(x => x.UrunId == id);
                t.UrunAd = txtUrunAd.Text;
                t.UrunGrup = int.Parse(lookUpEditGrup.EditValue.ToString());
                t.Birim = int.Parse(lookUpEditBirim.EditValue.ToString());
                t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
                t.Fiyat = decimal.Parse(txtFiyat.Text);
                t.Toplam = decimal.Parse(txtToplam.Text);
                t.Kdv = byte.Parse(txtKdv.Text);
                repo.Update(t);
                XtraMessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            catch (Exception ex)
            {

               XtraMessageBox.Show(ex.Message);
            }
           
        }
    }
}
