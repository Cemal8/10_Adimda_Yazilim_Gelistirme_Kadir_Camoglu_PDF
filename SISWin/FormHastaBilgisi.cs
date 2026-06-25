using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
// ISK (İş Katmanı) referansını tamamen sildik, çünkü artık API ile haberleşeceğiz.
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormHastaBilgisi : Form
    {
        // API adresi
        private readonly string apiUrl = "https://localhost:7003/";

        public VAR.Hasta hasta;

        public FormHastaBilgisi()
        {
            InitializeComponent();
        }

        private void FormHastaBilgisi_Load(object sender, EventArgs e)
        {
            dtpDogumTarihi.Value = DateTime.Now;
            cbbCinsiyet.SelectedIndex = 0;

            if (hasta != null)
            {
                HastaYukle();
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            if (hasta == null)
            {
                hasta = new VAR.Hasta();
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

            btnKaydet.Enabled = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/hasta/kaydet", hasta);

                    if (response.IsSuccessStatusCode)
                    {
                        sonuc = await response.Content.ReadFromJsonAsync<int>();
                    }
                    else
                    {
                        MessageBox.Show($"API İşlemi Başarısız Oldu. Hata Kodu: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex); 
                MessageBox.Show("Servise bağlanırken bir hata oluştu!\nDetay: " + ex.Message);
            }
            finally
            {
                btnKaydet.Enabled = true;
            }

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem hatalı veya kayıt gerçekleşemedi.");
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