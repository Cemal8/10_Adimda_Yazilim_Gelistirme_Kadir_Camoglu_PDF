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
        private void MenuYukle()
        {
            mniCikis.Visible = true;
            mniParolaDegistir.Visible = true;

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

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormGiris frm = new FormGiris();
            frm.ShowDialog(this);

            if (Yardimci.KullaniciNo > 0)
            {
                this.Show();
                SaatYaz();
                tmrSaat.Start();

                try
                {
                    calisan = ISK.Calisan.CalisanGetir(Yardimci.KullaniciNo);
                }
                catch (Exception ex)
                {
                    Yardimci.HataKaydet(ex);
                    MessageBox.Show("Serviste bir hata oluştu!");
                }

                MenuYukle();
            }
            else
            {
                Application.Exit();
            }
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tmrSaat_Tick_1(object sender, EventArgs e)
        {
            SaatYaz();
        }

        private void mniCikis_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Yardimci.KullaniciNo = 0;

            FormGiris frm = new FormGiris();
            frm.ShowDialog(this);

            if (Yardimci.KullaniciNo > 0)
            {
                FormAnaSayfa_Load(sender, e);
            }
            else
            {
                Application.Exit();
            }
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
    }
}