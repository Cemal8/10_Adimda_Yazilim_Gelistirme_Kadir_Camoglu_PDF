using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISK = SISIsKatmani;
using VAR = SISVarliklar;
using SISVarliklar;

namespace SISWin
{
    public partial class FormYeniSeans : Form
    {
        public VAR.Calisan uzman;
        private const int enKisaSeansSuresi = 30;

        public FormYeniSeans(VAR.Calisan seciliUzman)
        {
            InitializeComponent();
            uzman = seciliUzman;
            lblUzman.Text = uzman.GoruntuMetni;
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (dtpTarih.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Seans tarihi bugünden önce olamaz.");
                dtpTarih.Select();
                dtpTarih.Focus();
                return false;
            }
            if (dtpBitisSaati.Value <= dtpTarih.Value.AddMinutes(enKisaSeansSuresi))
            {
                MessageBox.Show($"Seans süresi en az {enKisaSeansSuresi} dakika olmalıdır.");
                dtpBitisSaati.Select();
                dtpBitisSaati.Focus();
                return false;
            }
            return true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // ✅ null kontrolü eklendi (ekstra güvenlik için)
            if (uzman == null)
            {
                MessageBox.Show("Uzman bilgisi bulunamadı!");
                return;
            }

            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            VAR.Seans seans = new SISVarliklar.Seans();
            seans.UzmanNo = uzman.No;
            seans.Tarih = dtpTarih.Value;
            seans.BaslangicSaati = dtpBaslingicSaati.Value.ToShortTimeString();
            seans.BitisSaati = dtpBitisSaati.Value.ToShortTimeString();

            int sonuc = 0;

            // servis çağırılıyor
            try
            {
                sonuc = ISK.Seans.Kaydet(seans);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt işlemi tamamlandı.");
                this.Close();
            }
            else if (sonuc == -1)
            {
                MessageBox.Show("Seans saatlerinde çakışma var!");
            }
            else
            {
                MessageBox.Show("İşlem hatalı!");
            }
        }

        private void FormYeniSeans_Load(object sender, EventArgs e)
        {

        }
    }
}