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

      

        private void FormSeansIptalEt_Load(object sender, EventArgs e)
        {
           lblUzman.Text = seans.GoruntuMetni;
            lblSeans.Text = seans.GoruntuMetni;
            seans.IptalEdenNo = Program.KullaniciNo;
        }
    }
}
