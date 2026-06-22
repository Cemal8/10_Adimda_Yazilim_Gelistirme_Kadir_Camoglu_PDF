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
using SISIsKatmani;
namespace SISWin
{
    public partial class FormRandevuKaydet : Form
    {
        public VAR.Hasta hasta;
        private VAR.Calisan uzman;
        private VAR.Seans seans;

        private void UzmanlariYukle()
        {
            VAR.Calisan[] calisanlar = null;
            // servis çağırılıyor
            try
            {
                calisanlar = ISK.Calisan.UzmanlariListele();
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            cbbUzmanlar.DataSource = calisanlar;
            cbbUzmanlar.DisplayMember = "GoruntuMetni";
        }

        private void UzmanSeanslariniYukle()
        {
            VAR.Seans[] seanslar = null;

            // servis çağırılıyor
            try
            {
                seanslar = ISK.Seans.UzmanSeanslariniListele(uzman.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            cbbSeanslar.DataSource = seanslar;
            cbbSeanslar.DisplayMember = "GoruntuMetni";
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if(uzman==null)
            {
                MessageBox.Show("Lütfen bir uzman seçiniz.");
                cbbUzmanlar.Focus();
                return false;
            }

            if (seans == null)
            {
                MessageBox.Show("Lütfen bir seans seçiniz.");
                cbbSeanslar.Focus();
                return false;
            }
            return true;
        }

        public FormRandevuKaydet()
        {
            InitializeComponent();
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            uzman = (VAR.Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (VAR.Seans)cbbSeanslar.SelectedItem;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();
            bool sonuc = false;

            if (!dogruMu)
            {
                return;
            }

            try
            {
                seans.HastaNo = hasta.No;
                sonuc = ISK.Seans.RandevuKaydet(seans.No, hasta.No);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            if (sonuc)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem hatalı!");
            }
        }

        private void FormRandevuKaydet_Load(object sender, EventArgs e)
        {
            lblHasta.Text = hasta.GoruntuMetni;
            UzmanlariYukle();
        }


    }
}
