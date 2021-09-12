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

namespace OtelOtomasyonu.Formlar.UrunIslemleri
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Urun select new
            {
                x.UrunId,
                x.UrunAd,
                x.Tbl_UrunGrup.UrunGrupAd,
                x.Fiyat,
                x.Birim,
                x.Toplam
            }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrunKarti fr = new FrmUrunKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("UrunId").ToString());
            fr.Show();
        }
    }
}
