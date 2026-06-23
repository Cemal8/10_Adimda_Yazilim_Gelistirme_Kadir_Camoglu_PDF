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
    public partial class FormHastaBilgisi : Form
    {
        public VAR.Hasta hasta;
        public FormHastaBilgisi()
        {
            InitializeComponent();
        }

        private void FormHastaBilgisi_Load(object sender, EventArgs e)
        {
            //
            dtpDogumTarihi.Value = DateTime.Now;
            cbbCinsiyet.SelectedIndex = 0;

            if (hasta != null)
            {
                HastaYukle();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            // yeni kayıtsa, yeni bir calisan nesnesi olusturuluyor.
            if (hasta == null)
            {
                hasta = new SISVarliklar.Hasta();
            }

            hasta.Ad = txtAd.Text;
            hasta.Adres = txtAdres.Text;
            hasta.CepTel = txtGsmNo.Text;
            hasta.Cinsiyet = cbbCinsiyet.Items[cbbCinsiyet.SelectedIndex].ToString();
            hasta.DogumTarihi = dtpDogumTarihi.Value;
            hasta.Eposta = txtEPosta.Text;
            hasta.EvTel = txtTelefon.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.TcKimlikNo = txtKimlikNo.Text;

            int sonuc = 0;

            // servis çağırılıyor
            try
            {
                sonuc = ISK.Hasta.Kaydet(hasta);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
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

        private void HastaYukle()
        {
            txtAd.Text = hasta.Ad;
            txtSoyad.Text = hasta.Soyad;
            txtEPosta.Text = hasta.Eposta;
            txtGsmNo.Text = hasta.CepTel;
            txtKimlikNo.Text = hasta.TcKimlikNo;
            txtTelefon.Text = hasta.EvTel;
            dtpDogumTarihi.Value = hasta.DogumTarihi;
            cbbCinsiyet.SelectedItem = hasta.Cinsiyet;

        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtAd.Text == String.Empty)
            {
                MessageBox.Show("Ad alanı boş geçilemez.");
                txtAd.Select();
                txtAd.Focus();
                return false; 
            }
            if (txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Soyad alanı boş geçilemez.");
                txtSoyad.Select();
                txtSoyad.Focus();
                return false;
            }
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("Eposta alanı boş geçilemez.");
                txtEPosta.Select();
                txtEPosta.Focus();
                return false;
            }
            if (txtGsmNo.Text == String.Empty)
            {
                MessageBox.Show("Gsm No alanı boş geçilemez.");
                txtGsmNo.Select();
                txtGsmNo.Focus();
                return false;
            }
            if (txtKimlikNo.Text == String.Empty)
            {
                MessageBox.Show("Kimlik No alanı boş geçilemez.");
                txtKimlikNo.Select();
                txtKimlikNo.Focus();
                return false;
            }
            if (cbbCinsiyet.SelectedItem == null)
            {
                MessageBox.Show("Cinsiyet seçimi yapılmalıdır.");
                cbbCinsiyet.Select();
                cbbCinsiyet.Focus();
                return false;
            }
            return true;
        }

   
    }
}
