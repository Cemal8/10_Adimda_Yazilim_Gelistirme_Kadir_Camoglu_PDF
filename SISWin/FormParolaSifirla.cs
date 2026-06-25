using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormParolaSifirla : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public FormParolaSifirla()
        {
            InitializeComponent();
        }

        private async void btnSifirla_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;

            btnSifirla.Enabled = false;
            bool sonuc = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    var requestData = new
                    {
                        EPosta = txtEPosta.Text.Trim(),
                        Parola = txtParola.Text.Trim()
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/calisan/parola-sifirla", requestData);

                    if (response.IsSuccessStatusCode)
                    {
                        sonuc = await response.Content.ReadFromJsonAsync<bool>();

                        if (sonuc)
                        {
                            MessageBox.Show("Parola başarıyla sıfırlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Parolanız başarıyla sıfırlandı ve veritabanı güncellendi!\n\nNot: Sistem bilgilendirme e-postası gönderemedi (SMTP hatası), ancak yeni şifrenizle giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"API İşlemi Başarısız Oldu. Statü Kodu: {response.StatusCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Servise bağlanırken genel bir hata oluştu!\nDetay: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSifirla.Enabled = true;
            }
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("E-Posta alanı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEPosta.Select();
                txtEPosta.Focus();
                return false;
            }
            if (txtParola.Text == String.Empty)
            {
                MessageBox.Show("Parola alanı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Select();
                txtParola.Focus();
                return false;
            }

            return true;
        }
    }
}