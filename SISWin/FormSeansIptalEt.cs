using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormSeansIptalEt : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public VAR.Seans seans;
        public string uzmanAdi = "";

        public FormSeansIptalEt()
        {
            InitializeComponent();
        }

        private void FormSeansIptalEt_Load(object sender, EventArgs e)
        {
            if (seans != null)
            {
                lblUzman.Text = uzmanAdi;
                lblSeans.Text = seans.GoruntuMetni;

                seans.IptalEdenNo = Yardimci.KullaniciNo;
            }
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtIptalNedeni.Text == String.Empty)
            {
                MessageBox.Show("İptal Nedeni alanı boş geçilemez.");
                txtIptalNedeni.Select();
                txtIptalNedeni.Focus();
                return false;
            }
            return true;
        }

        private async void btnIptal_Click_1(object sender, EventArgs e)
        {
            if (seans == null)
            {
                MessageBox.Show("İptal edilecek seans bilgisi bulunamadı!");
                return;
            }

            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;

            seans.SeansNotu = txtIptalNedeni.Text;

            btnIptal.Enabled = false;
            bool sonuc = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/seans/iptal", seans);

                    if (response.IsSuccessStatusCode)
                    {
                        sonuc = await response.Content.ReadFromJsonAsync<bool>();
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
                btnIptal.Enabled = true;
            }

            if (sonuc)
            {
                MessageBox.Show("Seans başarıyla iptal edildi.");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Oluşan bir hata nedeniyle seans iptal edilemedi.");
            }
        }
    }
}