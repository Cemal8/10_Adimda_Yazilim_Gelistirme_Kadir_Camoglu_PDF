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

namespace SISWin
{
    public partial class FormSeansYonetimi : Form
    {
        public SISVarliklar.Calisan uzman;
        public FormSeansYonetimi()
        {
            InitializeComponent();
        }

        private void UzmanlarıYukle()
        {

        }

        private void UzmanSeanslariniYukle()
        {

        }

        private void FormSeansYonetimi_Load(object sender, EventArgs e)
        {
            UzmanlarıYukle();
        }

        private void cbbUzmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uzman = (VAR.Calisan)cbbUzmanlar.SelectedItem;
            UzmanSeanslariniYukle();
        }

        private void lnkSeansEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormYeniSeans frm = new FormYeniSeans();
            frm.uzman = this.uzman; 
            frm.ShowDialog();

            UzmanSeanslariniYukle();
        }

        private void lnkSeansIptalEt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VAR.Seans seans = (VAR.Seans)lstSeanslar.SelectedItem;

            FormSeansIptalEt frm = new FormSeansIptalEt();
            frm.seans = seans; 
            frm.ShowDialog();

            UzmanSeanslariniYukle();
        }
    }
}