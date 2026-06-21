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
    public partial class FormUzmanSeansYonetimi : Form
    {
        public VAR.Calisan uzman = null;

        private VAR.Hasta hasta = null;
        private VAR.Seans aktifseans = null;
        private VAR.Seans gecmisSeans = null;

        private void UzmanSeanslariniYukle()
        {

        }

        private void BilgileriYukle()
        {

        }

        private void SeansNotuKaydet(int seansNo, string seansNotu)
        {

        }

        private void EkranıTemizle()
        {
            hasta = null;
            lblTCKimlikNo.Text = "";
            lblAd.Text = "";
            lblAdres.Text = "";
            lblGsmNo.Text = "";
            lblCinsiyet.Text = "";
            lblDogumTarihi.Text = "";
            lblEPosta.Text = "";
            lblTelefon.Text = "";
            lblSoyad.Text = "";
        }

        public FormUzmanSeansYonetimi()
        {
            InitializeComponent();
        }

        private void FormUzmanSeansYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gecmisSeans = (VAR.Seans)cbbSeanslar.SelectedItem;
            if (gecmisSeans != null)
            {
                txtGecmisSeansNotu.Text = gecmisSeans.SeansNotu;
            }
        }


        private void txtGecmisSeansNotu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGecmisSeansNotu.Text))
            {
                MessageBox.Show("Seans notu boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAktifSeansNotu.Focus();
                return;
            }

            bool sonuc = SeansNotuKaydet(aktifseans.No, txtAktifSeansNotu.Text);
            if (sonuc)
            {
                MessageBox.Show("Seans notu başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seans notu kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGecmisSeansNotu.Text))
            {
                MessageBox.Show("Seans notu boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGecmisSeansNotu.Focus();
                return;
            }
            bool sonuc = SeansNotuKaydet(gecmisSeans.No, txtGecmisSeansNotu.Text);
            if (sonuc)
            {
                MessageBox.Show("Seans notu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Seans notu güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}