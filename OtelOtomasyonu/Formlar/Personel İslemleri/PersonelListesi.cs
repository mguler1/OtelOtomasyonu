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

namespace OtelOtomasyonu.Formlar.Personel_İslemleri
{
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource  = (from x in db.Tbl_Personel
                         select new
                         {
                            x.PersonelId, x.Tc,x.AdSoyad,x.Telefon,x.Mail,x.Tbl_Departman.DepartmanAd,x.Tbl_Gorev.GorevAd
                         }).ToList();
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           FrmPersonelKarti fr = new FrmPersonelKarti();
            fr.id =int.Parse(gridView1.GetFocusedRowCellValue("PersonelId").ToString());
            fr.Show();
        }
    }
}
