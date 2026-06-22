using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAR = SISVarliklar;
using ISK = SISIsKatmani;
using SISIsKatmani;
using SISVeriErisimKatmani;
using System;
namespace SISWin
{
    public partial class FormAnaSayfa : Form
    {
        // 1. Form seviyesindeki çalışan değişkeni
        public VAR.Calisan calisan;

        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        // --- YARDIMCI METOTLAR ---

        private void SaatYaz()
        {
            tslSaat.Text = DateTime.Now.ToLongTimeString();
            tslTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void MenuYukle()
        {
            mniCikis.Visible = true;
            mniParolaDegistir.Visible = true;

            switch (calisan.CalisanTipi)
            {
                case VAR.CalisanTipleri.SistemYoneticisi:
                    mniSekreterKaydet.Visible = true;
                    mniParolaSifirla.Visible = true;
                    tslKullanici.Text += " (Sistem Yöneticisi)";
                    break;
                case VAR.CalisanTipleri.Sekreter:
                    mniRandevuYonet.Visible = true;
                    mniSeansYonetSekreter.Visible = true;
                    mniUzmanKaydet.Visible = true;
                    tslKullanici.Text += " (Sekreter)";
                    break;
                case VAR.CalisanTipleri.Uzman:
                    mniSeansYonetUzman.Visible = true;
                    tslKullanici.Text += " (Uzman)";
                    break;
                default:
                    break;
            }
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            SISIsKatmani.Yardimci.HataKaydet(new Exception("Hata kaydet testi."));

            this.Hide();
            FormGiris frm = new FormGiris();
            frm.ShowDialog(this);

            if (SISIsKatmani.Yardimci.KullaniciNo > 0)
            {
                SaatYaz();

                try
                {
                    calisan = SISIsKatmani.Calisan.CalisanGetir(SISIsKatmani.Yardimci.KullaniciNo);
                }
                catch (Exception ex)
                {
                    SISIsKatmani.Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu!");
                }

                tslKullanici.Text = calisan.GoruntuMetni;

                MenuYukle();
            }
            else
            {
                this.Close();
            }
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void mniParolaDegistir_Click(object sender, EventArgs e)
        {
            FormParolaDegistir frm = new FormParolaDegistir();
            frm.calisan = this.calisan;
            frm.ShowDialog();
        }

        private void mniParolaSifirla_Click(object sender, EventArgs e)
        {
            FormParolaSifirla frm = new FormParolaSifirla();
            frm.ShowDialog();
        }

        private void mniUzmanKaydet_Click(object sender, EventArgs e)
        {
            FormUzmanBilgisi frm = new FormUzmanBilgisi();
            frm.ShowDialog();
        }

        private void mniSekreterKaydet_Click(object sender, EventArgs e)
        {
            FormSekreterBilgisi frm = new FormSekreterBilgisi();
            frm.ShowDialog();
        }

        private void mniCalisanAra_Click(object sender, EventArgs e)
        {
            FormCalisanAra frm = new FormCalisanAra();
            frm.ShowDialog();
        }

        private void mniRandevuYonet_Click(object sender, EventArgs e)
        {
            FormHastaRandevuYonet frm = new FormHastaRandevuYonet();
            frm.ShowDialog();
        }

        private void mniSeansYonetSekreter_Click(object sender, EventArgs e)
        {
            FormSeansYonetimi frm = new FormSeansYonetimi();
            frm.ShowDialog();
        }

        private void mniSeansYonetUzman_Click(object sender, EventArgs e)
        {
            FormUzmanSeansYonetimi frm = new FormUzmanSeansYonetimi();
            frm.Show();
        }

        private void mniCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mevcut boş metodunuz
        }
    }
}