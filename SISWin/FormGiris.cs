using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace SISWin
{
    public partial class FormGiris : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public FormGiris()
        {
            InitializeComponent();
        }

        private async void btnGir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullanici.Text))
            {
                MessageBox.Show("Kullanıcı bilgisini boş geçemezsiniz.");
                txtKullanici.SelectAll();
                txtKullanici.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Parola bilgisini boş geçemezsiniz.");
                txtParola.SelectAll();
                txtParola.Focus();
                return;
            }

            int calisanNo = 0;

            btnGir.Enabled = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    var loginVerisi = new
                    {
                        EPosta = txtKullanici.Text,
                        Parola = txtParola.Text
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/calisan/giris", loginVerisi);

                    if (response.IsSuccessStatusCode)
                    {
                        calisanNo = await response.Content.ReadFromJsonAsync<int>();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Hatalı kullanıcı veya parola bilgisi!");
                        txtKullanici.SelectAll();
                        txtKullanici.Focus();
                        return; 
                    }
                    else
                    {
                        MessageBox.Show($"API Hatası: {response.StatusCode}");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Servise bağlanırken bir hata oluştu!\nDetay: " + ex.Message);
                return;
            }
            finally
            {
                btnGir.Enabled = true;
            }

            if (calisanNo > 0)
            {
                Yardimci.KullaniciNo = calisanNo;
                this.Close(); 
            }
        }
    }
}