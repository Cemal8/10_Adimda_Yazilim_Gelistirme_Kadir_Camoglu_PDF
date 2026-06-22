using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using ISK = SISIsKatmani;
using VAR = SISVarliklar;
namespace SISWin
{
    public partial class FormCalisanAra : Form
    {
        public VAR.Calisan calisan;

        public FormCalisanAra()
        {
            InitializeComponent();
        }

        private void CalisanlariListele()
        {
            VAR.Calisan[] calisanlar = null;
            lstCalisanlar.DisplayMember = "GoruntuMetni";
            // servis çağırılıyor
            try
            {
                calisanlar = ISK.Calisan.CalisanlariListele(txtAd.Text, txtSoyad.Text);
            }
            catch (Exception ex)
            {
                ISK.Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }
            finally
            {
                lstCalisanlar.DataSource = calisanlar;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CalisanlariListele();
        }

        private void lstCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            int indeks = lstCalisanlar.SelectedIndex;
            VAR.Calisan calisan = (VAR.Calisan)lstCalisanlar.SelectedItem;

            if (calisan.CalisanTipi==VAR.CalisanTipleri.Sekreter) 
            {
                FormSekreterBilgisi frm = new FormSekreterBilgisi();
                frm.calisan = calisan;
                frm.ShowDialog();
            }
            else if (calisan.CalisanTipi== VAR.CalisanTipleri.Uzman)
            {
                FormUzmanBilgisi frm = new FormUzmanBilgisi();
                frm.calisan = calisan;
                frm.ShowDialog();
            }

            CalisanlariListele();
            lstCalisanlar.SelectedIndex = indeks;
            
        }


    }
}
