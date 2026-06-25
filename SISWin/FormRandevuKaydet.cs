using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormRandevuKaydet : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public VAR.Hasta hasta;
        private VAR.Calisan uzman;
        private VAR.Seans seans;

        public FormRandevuKaydet()
        {
            InitializeComponent();
        }

        private async void FormRandevuKaydet_Load(object sender, EventArgs e)
        {
            if (hasta != null)
            {
                lblHasta.Text = hasta.GoruntuMetni;
            }
            else
            {
                lblHasta.Text = "Hasta Bilgisi Bulunamadı!";
                btnKaydet.Enabled = false;
            }

            await UzmanlariYukleAsync();
        }

        private async Task UzmanlariYukleAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    var uzmanlar = await client.GetFromJsonAsync<VAR.Calisan[]>("api/calisan/uzmanlar");

                    cbbUzmanlar.DataSource = uzmanlar;
                    cbbUzmanlar.DisplayMember = "GoruntuMetni";
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Uzman listesi çekilirken bir hata oluştu!\nDetay: " + ex.Message);
            }
        }

        private async Task UzmanSeanslariniYukleAsync()
        {
            if (uzman == null) return;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    var seanslar = await client.GetFromJsonAsync<VAR.Seans[]>($"api/seans/uzman/{uzman.No}");

                    cbbSeanslar.DataSource = seanslar;
                    cbbSeanslar.DisplayMember = "GoruntuMetni";
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Uzmanın seansları çekilirken bir hata oluştu!\nDetay: " + ex.Message);
            }
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (uzman == null)
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

        private async void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUzmanlar.SelectedItem is VAR.Calisan secilenUzman)
            {
                uzman = secilenUzman;
                await UzmanSeanslariniYukleAsync();
            }
        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSeanslar.SelectedItem is VAR.Seans secilenSeans)
            {
                seans = secilenSeans;
            }
            else
            {
                seans = null;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (hasta == null)
            {
                MessageBox.Show("Hasta bilgisi bulunamadığı için randevu kaydedilemiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;

            bool sonuc = false;
            btnKaydet.Enabled = false;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    var randevuVerisi = new
                    {
                        SeansNo = seans.No,
                        HastaNo = hasta.No
                    };

                    HttpResponseMessage response = await client.PostAsJsonAsync("api/seans/randevu-kaydet", randevuVerisi);

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
                MessageBox.Show("Servise bağlanırken bir hata oluştu!");
            }
            finally
            {
                btnKaydet.Enabled = true;
            }

            if (sonuc)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi. Bu seans dolu olabilir veya bir hata oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}