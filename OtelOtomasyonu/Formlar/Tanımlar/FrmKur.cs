using DevExpress.XtraEditors;
using OtelOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.Formlar.Tanımlar
{
    public partial class FrmKur : Form
    {
        public FrmKur()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmKur_Load(object sender, EventArgs e)
        {
            db.Kur.Load();
            bindingSource1.DataSource = db.Kur.Local;
            repositoryItemLookUpEditDurum.DataSource = (from x in db.Durum select new { x.DurumId, x.DurumAd }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Lütfen Değerleri Kontrol Edip Tekrar Yapın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
