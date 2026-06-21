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
using SISIsKatmani;
namespace SISWin
{
    public partial class FormRandevuKaydet : Form
    {
        public VAR.Hasta hasta;
        private VAR.Calisan uzman;
        private VAR.Seans seans;

        private void UzmanlariYukle()
        {

        }

        private void UzmanSeanslariniYukle()
        {

        }

        private bool KullanıcıGirdisiDogrula()
        {
            if(uzman==null)
            {
                MessageBox.Show("Lütfen bir uzman seçiniz.");
                cbbUzmanlar.Focus();
                return false;
            }

            if (seans == null)
            {
                MessageBox.Show("Lütfen bir seans seçiniz.");
                cbbSeanslar.Focus();
                return false;
            }
            return true;
        }

        public FormRandevuKaydet()
        {
            InitializeComponent();
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            uzman = (VAR.Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void cbbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seans = (VAR.Seans)cbbSeanslar.SelectedItem;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void FormRandevuKaydet_Load(object sender, EventArgs e)
        {
            lblHasta.Text = hasta.GoruntuMetni;
            UzmanlariYukle();
        }
    }
}
