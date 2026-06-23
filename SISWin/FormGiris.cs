using SISIsKatmani;
using System;
using System.Windows.Forms;
using ISK = SISIsKatmani;

namespace SISWin
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGir_Click(object sender, EventArgs e)
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

            try
            {
                calisanNo = ISK.Calisan.KullaniciGirisiniDogrula(txtKullanici.Text, txtParola.Text);
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste bir hata oluştu!");
                return;
            }

            if (calisanNo > 0)
            {
                // Önce numarayı atıyoruz, sonra formu güvenle kapatıyoruz
                Yardimci.KullaniciNo = calisanNo;
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı/parola bilgisi!");
                txtKullanici.SelectAll();
                txtKullanici.Focus();
            }
        }
    }
}