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
    public partial class FormParolaDegistir : Form
    {
        public SISVarliklar.Calisan calisan;
        public FormParolaDegistir()
        {
            InitializeComponent();
        }
        private bool KullanıcıGirdisiDogrula()
        {
            if (txtEski.Text == String.Empty)
            {
                MessageBox.Show("Eski Parola alanı boş geçilemez.");
                txtEski.Select();
                txtEski.Focus();
                return false;
            }
            if (txtYeni.Text == String.Empty)
            {
                MessageBox.Show("Yeni Parola alanı boş geçilemez.");
                txtYeni.Select();
                txtYeni.Focus();
                return false;
            }
         
            if (txtYeni2.Text != txtYeni2.Text)
            {
                MessageBox.Show("Yeni Parola ve Yeni Parola Tekrar alanları aynı olmalıdır.");
                txtYeni2.Select();
                txtYeni2.Focus();
                return false;
            }
            return true;
        }


        private void btnDegistir_Click(object sender, EventArgs e)
        {

        }
    }
}
