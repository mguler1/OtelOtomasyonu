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
    public partial class FrmUrunGiris : Form
    {
        public FrmUrunGiris()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmUrunGiris_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_UrunHareket select new
            { x.HareketId,
            x.Tbl_Urun.UrunAd,
            x.Miktar,
            x.Tarih,
            x.HareketTuru
            }).Where(y=>y.HareketTuru=="Giriş").ToList();
        }
    }
}
