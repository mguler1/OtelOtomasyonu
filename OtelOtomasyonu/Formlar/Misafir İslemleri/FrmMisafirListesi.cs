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

namespace OtelOtomasyonu.Formlar.Misafir_İslemleri
{
    public partial class FrmMisafirListesi : Form
    {
        public FrmMisafirListesi()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();

        private void FrmMisafirListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_Misafir select new {x.MisafirId, x.AdSoyad, x.Tc, x.Telefon, x.Mail }).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MisafirKarti fr = new MisafirKarti();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("MisafirId").ToString());
            fr.Show();
        }
    }
}
