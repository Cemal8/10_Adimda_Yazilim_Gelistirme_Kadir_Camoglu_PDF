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

        }

        private bool KullanıcıGirdisiDogrula()
        {
            if (txtEPosta.Text == String.Empty)
            {
                MessageBox.Show("Yeni Parola alanı boş geçilemez.");
                txtEPosta.Select();
                txtEPosta.Focus();
                return false;
            }
            if (txtParola.Text == String.Empty)
            {
                MessageBox.Show("Yeni Parola Tekrar alanı boş geçilemez.");
                txtParola.Select();
                txtParola.Focus();
                return false;
            }
           
            return true;
        }
    }
}
