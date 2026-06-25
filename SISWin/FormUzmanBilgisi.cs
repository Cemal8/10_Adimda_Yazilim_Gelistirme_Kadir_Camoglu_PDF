using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
// Eski ISK referanslarını tamamen sildik, sadece varlıkları (modelleri) kullanıyoruz
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormUzmanBilgisi : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public VAR.Calisan calisan;

        public FormUzmanBilgisi()
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

            // PDF'teki resimde olan ancak koda eklemeyi unuttuğun Ünvan alanı:
            // (Eğer tasarımda txtUnvan adlı TextBox'ın yoksa bu satırı yoruma alabilirsin)
            // txtUnvan.Text = calisan.Unvan; 
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtAd.Text == String.Empty)
            {
                MessageBox.Show("Ad alanı boş geçilemez.");
                txtAd.Focus();
                return false;
            }
            if (txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Soyad alanı boş geçilemez.");
                txtSoyad.Focus();
                return false;
            }
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("Eposta alanı boş geçilemez.");
                txtEPosta.Focus();
                return false;
            }
            if (txtGsmNo.Text == String.Empty)
            {
                MessageBox.Show("Gsm No alanı boş geçilemez.");
                txtGsmNo.Focus();
                return false;
            }
            if (txtKimlikNo.Text == String.Empty)
            {
                MessageBox.Show("Kimlik No alanı boş geçilemez.");
                txtKimlikNo.Focus();
                return false;
            }
            return true;
        }

        private void FormUzmanBilgisi_Load(object sender, EventArgs e)
        {
            if (calisan != null)
            {
                UzmanYukle();
            }
        }

        // Metodumuzu async yaptık
        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            if (calisan == null)
            {
                calisan = new VAR.Calisan();
            }

            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.TcKimlikNo = txtKimlikNo.Text;

            calisan.CalisanTipi = VAR.CalisanTipleri.Uzman;

            calisan.CepTel = txtGsmNo.Text;
            calisan.Eposta = txtEPosta.Text;
            calisan.EvTel = txtTelefon.Text;


            int sonuc = 0;

            btnKaydet.Enabled = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/calisan/kaydet", calisan);

                    if (response.IsSuccessStatusCode)
                    {
                        sonuc = await response.Content.ReadFromJsonAsync<int>();
                    }
                    else
                    {
                        MessageBox.Show($"API Hatası: {response.StatusCode}");
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
                MessageBox.Show("Kayıt işlemi başarıyla tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem hatalı veya gerçekleştirilemedi.");
            }
        }
    }
}