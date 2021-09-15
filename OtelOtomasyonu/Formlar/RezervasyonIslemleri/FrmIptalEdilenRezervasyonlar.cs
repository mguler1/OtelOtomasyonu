using OtelOtomasyonu.Entity;
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
    public partial class FrmIptalEdilenRezervasyonlar : Form
    {
        public FrmIptalEdilenRezervasyonlar()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmIptalEdilenRezervasyonlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Rezervasyon
                                       select new
                                       {
                                           x.RezervasyonId,
                                           x.Tbl_Misafir.AdSoyad,
                                           x.GirisTarihi,
                                           x.CikisTarihi,
                                           x.KisiSayisi,
                                           x.Tbl_Oda.OdaNo,
                                           x.Telefon,
                                           x.Tbl_Durum.DurumAd
                                       }).Where(y => y.DurumAd == "Rezervasyon İptal").ToList();
        }
    }
}
