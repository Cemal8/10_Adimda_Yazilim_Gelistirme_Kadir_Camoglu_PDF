using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using ISK = SISIsKatmani;
using VAR = SISVarliklar;
namespace SISWin
{
    public partial class FormHastaRandevuYonet : Form
    {
        public VAR.Hasta hasta = null;
        private VAR.Seans sonRandevu = null;
        private VAR.Seans sonSeans = null;

        private void RandevuBilgisiYukle()
        {

        }

        private void HastalariListele()
        {

        }


        private void HastalariYukle()
        {
            HastaBilgisiTemizle();

            lblAd.Text = hasta.Ad;
            lblSoyad.Text = hasta.Soyad;
            lblGsmNo.Text = hasta.CepTel;
            lblCinsiyet.Text = hasta.Cinsiyet;
            lblDogumTarihi.Text = hasta.DogumTarihi.ToShortDateString();
            lblEPosta.Text = hasta.Eposta;
            lblTelefon.Text = hasta.EvTel;
            lblTCKimlikNo.Text = hasta.TcKimlikNo;
            lblAdres.Text = hasta.Adres;

        }

        private void HastaBilgisiTemizle()
        {
            lblAd.Text = "";
            lblSoyad.Text = "";
            lblGsmNo.Text = "";
            lblCinsiyet.Text = "";
            lblDogumTarihi.Text = "";
            lblEPosta.Text = "";
            lblTelefon.Text = "";
            lblTCKimlikNo.Text = "";
            lblAdres.Text = "";

        }

        private void RandevuBilgisiTemizle()
        {
            lblRandevuSeans.Text = "";
            lblRandevuUzman.Text = "";

            lblSeansNot.Text = "";
            lblSeansSeans.Text = "";
            lblSeansUzman.Text = "";
            lnkYeniRandevu.Enabled = false;
            lnkRandevuIptalEt.Enabled = false;


        }

        public FormHastaRandevuYonet()
        {
            InitializeComponent();
        }





        private void btnAra_Click(object sender, EventArgs e)
        {
            HastalariListele();
        }

        private void lnkYeniHastaGir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaBilgisi frm = new FormHastaBilgisi();
            DialogResult cevap = frm.ShowDialog();
            if (cevap== DialogResult.OK)
            {
                txtAd.Text = frm.hasta.Ad;
                txtSoyad.Text = frm.hasta.Soyad;
                HastalariListele();
                if(lstHastalar.Items.Count>0)
                {
                    lstHastalar.SelectedIndex = 0;
                }
            }
        }

        private void lnkHastaGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int indeks = lstHastalar.SelectedIndex;
            FormHastaBilgisi frm = new FormHastaBilgisi();
            frm.hasta = this.hasta;
            frm.ShowDialog();

            HastalariListele();
            lstHastalar.SelectedIndex = indeks;
        }

        private void lnkYeniRandevu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRandevuKaydet frm = new FormRandevuKaydet();
            frm.hasta = this.hasta;
            frm.ShowDialog();
            RandevuBilgisiYukle();
        }

        private void lnkRandevuIptalEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasta = (VAR.Hasta)lstHastalar.Items[lstHastalar.SelectedIndex];
            HastalariYukle();
            RandevuBilgisiYukle();
        }

        private void grbHastaBilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void FormHastaRandevuYonet_Load(object sender, EventArgs e)
        {
            HastaBilgisiTemizle();
            RandevuBilgisiTemizle();
        }
    }
}
