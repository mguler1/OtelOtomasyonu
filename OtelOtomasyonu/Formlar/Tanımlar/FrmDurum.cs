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
using DevExpress.XtraEditors;
using OtelOtomasyonu.Entity;

namespace OtelOtomasyonu.Formlar.Tanımlar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();

        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.Durum.Load();
            bindingSource1.DataSource = db.Durum.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Lütfen Değerleri Kontrol Edip Tekrar Yapın", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
        }
    }
}
