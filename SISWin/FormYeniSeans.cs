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
using SISVarliklar;
namespace SISWin
{
    public partial class FormYeniSeans : Form
    {
        public VAR.Calisan uzman = null;
        private const int enKisaSeansSuresi = 30;

        public FormYeniSeans()
        {
            InitializeComponent();
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (dtpBaslangicSaati.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Seans tarihi bugünden önce olamaz.");
                dtpBaslangicSaati.Select();
                dtpBaslangicSaati.Focus();
                return false;
            }
            if (dtpBitisSaati.Value <= dtpBaslangicSaati.Value.AddMinutes(enKisaSeansSuresi))
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
            lblUzman.Text = uzman.GoruntuMetni;

            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            VAR.Seans seans = new SISVarliklar.Seans();
            seans.UzmanNo = uzman.No;
            //seans.Tarih = dtpTarih.Value;
            seans.BaslangicSaati = dtpBaslangicSaati.Value.ToShortTimeString();
            seans.BitisSaati = dtpBitisSaati.Value.ToShortTimeString();

            int sonuc = 0;

            // servis çağırılıyor
            try
            {
                sonuc = ISK.Seans.Kaydet(seans);
            }
            catch (Exception ex)
            {
                ISK.Yardimci.HataKaydet(ex);
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
