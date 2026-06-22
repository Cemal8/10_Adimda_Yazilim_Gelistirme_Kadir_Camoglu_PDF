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
    public partial class FormSekreterBilgisi : Form
    {
        public VAR.Calisan calisan;
        public FormSekreterBilgisi()
        {
            InitializeComponent();
        }

        private void UzmanYukle()
        {
            txtAd.Text = calisan.Ad;
            txtSoyad.Text = calisan.Soyad;
            txtEPosta.Text = calisan.Eposta;
            txtGsmNo.Text = calisan.CepTel;
            txtKimlikNo.Text = calisan.TcKimlikNo;
            txtTelefon.Text = calisan.EvTel;

        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtAd.Text == String.Empty)
            {
                MessageBox.Show("Ad alanı boş geçilemez.");
                return false;
            }
            if (txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Soyad alanı boş geçilemez.");
                return false;
            }
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("Eposta alanı boş geçilemez.");
                return false;
            }
            if (txtGsmNo.Text == String.Empty)
            {
                MessageBox.Show("Gsm No alanı boş geçilemez.");
                return false;
            }
            if (txtKimlikNo.Text == String.Empty)
            {
                MessageBox.Show("Kimlik No alanı boş geçilemez.");
                return false;
            }
            if (txtTelefon.Text == String.Empty)
            {
                MessageBox.Show("Telefon alanı boş geçilemez.");
                return false;
            }
            return true;
        }

        private void FormSekreterBilgisi_Load(object sender, EventArgs e)
        {
            if(calisan != null)
            {
                UzmanYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if(!dogruMu)
            {
                return;
            }

            if (calisan == null)
            {
                calisan = new SISVarliklar.Calisan();
            }

            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.TcKimlikNo = txtKimlikNo.Text;
            calisan.CalisanTipi = VAR.CalisanTipleri.Sekreter;
            calisan.CepTel = txtGsmNo.Text;
            calisan.Eposta = txtEPosta.Text;
            calisan.EvTel = txtTelefon.Text;

            int sonuc = 0;

            try
            {
                sonuc = ISK.Calisan.Kaydet(calisan);
            }
            catch(Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu");
            }

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem hatalı");
            }

        }
    }
}
