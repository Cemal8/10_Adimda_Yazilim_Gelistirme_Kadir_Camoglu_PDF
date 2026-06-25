using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormSeansYonetimi : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public VAR.Calisan uzman;

        public FormSeansYonetimi()
        {
            InitializeComponent();
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
                MessageBox.Show("Uzmanlar listelenirken serviste bir hata oluştu!\nDetay: " + ex.Message);
            }
        }

        private async Task UzmanSeanslariniYukleAsync()
        {
            if (uzman == null) return;

            VAR.Seans[] seanslar = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);

                    seanslar = await client.GetFromJsonAsync<VAR.Seans[]>($"api/seans/uzman/{uzman.No}");
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Seanslar listelenirken serviste bir hata oluştu!");
            }

            lstSeanslar.DataSource = seanslar;
            lstSeanslar.DisplayMember = "GoruntuMetni";

            lnkSeansIptalEt.Enabled = (lstSeanslar.Items.Count > 0 && lstSeanslar.SelectedIndex > -1);
        }

        private async void FormSeansYonetimi_Load(object sender, EventArgs e)
        {
            await UzmanlariYukleAsync();
        }

        private async void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUzmanlar.SelectedItem is VAR.Calisan secilenUzman)
            {
                this.uzman = secilenUzman;
                await UzmanSeanslariniYukleAsync();
            }
        }

        private async void lnkSeansEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormYeniSeans frm = new FormYeniSeans(this.uzman);
            frm.ShowDialog();

            await UzmanSeanslariniYukleAsync();
        }

        private async void lnkSeansIptalEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lstSeanslar.SelectedItem is VAR.Seans secilenSeans)
            {
                FormSeansIptalEt frm = new FormSeansIptalEt();
                frm.seans = secilenSeans;
                frm.uzmanAdi = cbbUzmanlar.Text;
                frm.ShowDialog();

                await UzmanSeanslariniYukleAsync();
            }
        }
    }
}