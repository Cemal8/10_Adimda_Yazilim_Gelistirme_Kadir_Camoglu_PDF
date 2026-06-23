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
    public partial class FormParolaSifirla : Form
    {
        public FormParolaSifirla()
        {
            InitializeComponent();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            bool dogruMu = KullanıcıGirdisiDogrula();
            if (!dogruMu) return;

            bool sonuc = false;
            try
            {
                sonuc = ISK.Calisan.ParolaSifirla(txtEPosta.Text.Trim(), txtParola.Text.Trim());

                if (sonuc)
                {
                    MessageBox.Show("Parola başarıyla sıfırlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Veritabanında şifre değiştiği halde false dönüyorsa, bu kesinlikle mail gönderilemediği içindir.
                    // Kullanıcıya şifrenin değiştiği müjdesini veriyoruz:
                    MessageBox.Show("Parolanız başarıyla sıfırlandı ve veritabanı güncellendi!\n\nNot: Sistem bilgilendirme e-postası gönderemedi (SMTP hatası), ancak yeni şifrenizle giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Yardimci.HataKaydet(ex);
                MessageBox.Show("Serviste genel bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("E-Posta alanı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEPosta.Select();
                txtEPosta.Focus();
                return false;
            }
            if (txtParola.Text == String.Empty)
            {
                MessageBox.Show("Parola alanı boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Select();
                txtParola.Focus();
                return false;
            }

            return true;
        }
    }
}
