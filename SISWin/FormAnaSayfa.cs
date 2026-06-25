using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR = SISVarliklar;

namespace SISWin
{
    public partial class FormAnaSayfa : Form
    {
        // API Adresimiz
        private readonly string apiUrl = "https://localhost:7003/";

        public VAR.Calisan calisan;

        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void SaatYaz()
        {
            tslSaat.Text = DateTime.Now.ToLongTimeString();
            tslTarih.Text = DateTime.Now.ToLongDateString();
        }

        // BUG FIX: Tüm menüleri başlangıçta gizleyen ve yetkiye göre açan sistem
        private void MenuleriSifirla()
        {
            // Tasarım ekranındaki (Designer) menü isimlerin ile buradakilerin aynı olduğundan emin ol
            mniSekreterKaydet.Visible = false;
            mniParolaSifirla.Visible = false;
            mniRandevuYonet.Visible = false;
            mniSeansYonetSekreter.Visible = false;
            mniUzmanKaydet.Visible = false;
            mniCalisanAra.Visible = false;
            uzmanSeansYönetToolStripMenuItem.Visible = false;
            mniCikis.Visible = false;
            mniParolaDegistir.Visible = false;
        }

        private void MenuYukle()
        {
            MenuleriSifirla();

            mniCikis.Visible = true;
            mniParolaDegistir.Visible = true;

            if (calisan == null) return;

            switch (calisan.CalisanTipi)
            {
                case VAR.CalisanTipleri.SistemYoneticisi:
                    mniSekreterKaydet.Visible = true;
                    mniParolaSifirla.Visible = true;
                    tslKullanici.Text = calisan.Ad + " " + calisan.Soyad + " (Sistem Yöneticisi)";
                    break;

                case VAR.CalisanTipleri.Sekreter:
                    mniRandevuYonet.Visible = true;
                    mniSeansYonetSekreter.Visible = true;
                    mniUzmanKaydet.Visible = true;
                    mniCalisanAra.Visible = true;
                    tslKullanici.Text = calisan.Ad + " " + calisan.Soyad + " (Sekreter)";
                    break;

                case VAR.CalisanTipleri.Uzman:
                    uzmanSeansYönetToolStripMenuItem.Visible = true;
                    tslKullanici.Text = calisan.Ad + " " + calisan.Soyad + " (Uzman)";
                    break;

                default:
                    break;
            }
        }

        private async Task GirisVeYukleAsync()
        {
            this.Hide();      
            MenuleriSifirla();

            FormGiris frm = new FormGiris();
            frm.ShowDialog(this); 

            if (Yardimci.KullaniciNo > 0)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(apiUrl);
                        calisan = await client.GetFromJsonAsync<VAR.Calisan>($"api/calisan/{Yardimci.KullaniciNo}");
                    }

                    if (calisan != null)
                    {
                        MenuYukle(); 
                        this.Show(); 
                        SaatYaz();
                        tmrSaat.Start();
                    }
                    else
                    {
                        MessageBox.Show("Çalışan bilgileri sunucudan alınamadı.");
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Servise bağlanırken bir hata oluştu!\nDetay: " + ex.Message);
                    Application.Exit(); 
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private async void FormAnaSayfa_Shown(object sender, EventArgs e)
        {
            await GirisVeYukleAsync();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private async void mniCikis_Click_1(object sender, EventArgs e)
        {
            Yardimci.KullaniciNo = 0;
            calisan = null;
            tmrSaat.Stop();

            await GirisVeYukleAsync();
        }

        private void mniParolaDegistir_Click_1(object sender, EventArgs e)
        {
            FormParolaDegistir frm = new FormParolaDegistir();
            frm.calisan = this.calisan;
            frm.ShowDialog();
        }

        private void mniParolaSifirla_Click_1(object sender, EventArgs e)
        {
            FormParolaSifirla frm = new FormParolaSifirla();
            frm.ShowDialog();
        }

        private void mniUzmanKaydet_Click_1(object sender, EventArgs e)
        {
            FormUzmanBilgisi frm = new FormUzmanBilgisi();
            frm.ShowDialog();
        }

        private void mniSekreterKaydet_Click_1(object sender, EventArgs e)
        {
            FormSekreterBilgisi frm = new FormSekreterBilgisi();
            frm.ShowDialog();
        }

        private void mniCalisanAra_Click1(object sender, EventArgs e)
        {
            FormCalisanAra frm = new FormCalisanAra();
            frm.ShowDialog();
        }

        private void mniRandevuYonet_Click1(object sender, EventArgs e)
        {
            FormHastaRandevuYonet frm = new FormHastaRandevuYonet();
            frm.ShowDialog();
        }

        private void mniSeansYonetSekreter_Click1(object sender, EventArgs e)
        {
            FormSeansYonetimi frm = new FormSeansYonetimi();
            frm.ShowDialog();
        }

        private void uzmanSeansYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUzmanSeansYonetimi frm = new FormUzmanSeansYonetimi();
            frm.Show();
        }

        // Tasarımcıda yanlışlıkla açılan boş metotlar (Hata vermemesi için kalabilir)
        private void menüToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void tmrSaat_Tick_1(object sender, EventArgs e) { SaatYaz(); }
    }
}