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
    public partial class FormUzmanBilgisi : Form
    {
        public VAR.Calisan calisan;

        public FormUzmanBilgisi()
        {
            InitializeComponent();
        }

        private void UzmanYukle()
        {
            txtAd.Text = calisan.Ad;
            txtSoyad.Text = calisan.Soyad;
            txtEPosta.Text = calisan.Eposta;
            txtGsmNo.Text = calisan.CepTel;
            txtKimlikNo.Text = calisan.TcKimlikNo;
            txtTelefon.Text = calisan.EvTel;
        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtAd.Text == String.Empty)
            {
                MessageBox.Show("Ad alanı boş geçilemez.");
                return false;
            }
            if (txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Soyad alanı boş geçilemez.");
                return false;
            }
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("Eposta alanı boş geçilemez.");
                return false;
            }
            if (txtGsmNo.Text == String.Empty)
            {
                MessageBox.Show("Gsm No alanı boş geçilemez.");
                return false;
            }
            if (txtKimlikNo.Text == String.Empty)
            {
                MessageBox.Show("Kimlik No alanı boş geçilemez.");
                return false;
            }
            return true;
        }

        private void FormUzmanBilgisi_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
