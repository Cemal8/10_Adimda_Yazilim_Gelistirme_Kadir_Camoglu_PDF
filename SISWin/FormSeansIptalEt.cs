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
    public partial class FormSeansIptalEt : Form
    {
        public VAR.Seans seans;
        public string uzmanAdi = "";
        private bool KullanıcıGirdisiDogrula()
        {
            if (txtIptalNedeni.Text == String.Empty)
            {
                MessageBox.Show("İptal Nedeni alanı boş geçilemez.");
                txtIptalNedeni.Select();
                txtIptalNedeni.Focus();
                return false;
            }
            return true;
        }

        public FormSeansIptalEt()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            bool sonuc = false;
            // servis çağırılıyor
            try
            {
                sonuc = ISK.Seans.IptalEt(seans);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            if (sonuc)
            {
                MessageBox.Show("Seans iptal edildi.");
            }
            else
            {
                MessageBox.Show("Oluşan bir hata nedeniyle seans iptal edilemedi.");
            }

            this.Close();
        }

        private void FormSeansIptalEt_Load(object sender, EventArgs e)
        {
            lblUzman.Text = uzmanAdi;
            lblSeans.Text = seans.GoruntuMetni;
            seans.IptalEdenNo = Yardimci.KullaniciNo;
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();

            if (!dogruMu)
            {
                return;
            }

            bool sonuc = false;
            // servis çağırılıyor
            try
            {
                sonuc = ISK.Seans.IptalEt(seans);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
            }

            if (sonuc)
            {
                MessageBox.Show("Seans iptal edildi.");
            }
            else
            {
                MessageBox.Show("Oluşan bir hata nedeniyle seans iptal edilemedi.");
            }

            this.Close();
        }
    }
}
