namespace SISWin
{
    partial class FormHastaRandevuYonet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpArama = new GroupBox();
            grbHastaBilgileri = new GroupBox();
            grpRandevuBilgileri = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnAra = new Button();
            label4 = new Label();
            lnkYeniHastaGir = new LinkLabel();
            IstHastalar = new ListBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblTCKimlikNo = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblCinsiyet = new Label();
            lblEPosta = new Label();
            lblTelefon = new Label();
            lblGsmNo = new Label();
            lblDogumTarihi = new Label();
            lblAdres = new Label();
            lnkHastaGuncelle = new LinkLabel();
            label13 = new Label();
            lnkYeniRandevu = new LinkLabel();
            label14 = new Label();
            label15 = new Label();
            lblRandevuUzman = new Label();
            lblRandevuSeans = new Label();
            lnkRandevuIptalEt = new LinkLabel();
            label18 = new Label();
            lblSeansSeans = new Label();
            lblSeansUzman = new Label();
            label21 = new Label();
            label22 = new Label();
            lblSeansNot = new Label();
            label24 = new Label();
            grpArama.SuspendLayout();
            grbHastaBilgileri.SuspendLayout();
            grpRandevuBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // grpArama
            // 
            grpArama.Controls.Add(IstHastalar);
            grpArama.Controls.Add(lnkYeniHastaGir);
            grpArama.Controls.Add(label4);
            grpArama.Controls.Add(btnAra);
            grpArama.Controls.Add(txtSoyad);
            grpArama.Controls.Add(txtAd);
            grpArama.Controls.Add(label2);
            grpArama.Controls.Add(label1);
            grpArama.Location = new Point(0, 0);
            grpArama.Name = "grpArama";
            grpArama.Size = new Size(261, 579);
            grpArama.TabIndex = 0;
            grpArama.TabStop = false;
            grpArama.Text = "Arama";
            // 
            // grbHastaBilgileri
            // 
            grbHastaBilgileri.Controls.Add(lnkHastaGuncelle);
            grbHastaBilgileri.Controls.Add(lblAdres);
            grbHastaBilgileri.Controls.Add(lblDogumTarihi);
            grbHastaBilgileri.Controls.Add(lblGsmNo);
            grbHastaBilgileri.Controls.Add(lblTelefon);
            grbHastaBilgileri.Controls.Add(lblEPosta);
            grbHastaBilgileri.Controls.Add(lblCinsiyet);
            grbHastaBilgileri.Controls.Add(lblSoyad);
            grbHastaBilgileri.Controls.Add(lblAd);
            grbHastaBilgileri.Controls.Add(lblTCKimlikNo);
            grbHastaBilgileri.Controls.Add(label12);
            grbHastaBilgileri.Controls.Add(label11);
            grbHastaBilgileri.Controls.Add(label10);
            grbHastaBilgileri.Controls.Add(label9);
            grbHastaBilgileri.Controls.Add(label8);
            grbHastaBilgileri.Controls.Add(label7);
            grbHastaBilgileri.Controls.Add(label6);
            grbHastaBilgileri.Controls.Add(label5);
            grbHastaBilgileri.Controls.Add(label3);
            grbHastaBilgileri.Location = new Point(267, 0);
            grbHastaBilgileri.Name = "grbHastaBilgileri";
            grbHastaBilgileri.Size = new Size(252, 579);
            grbHastaBilgileri.TabIndex = 1;
            grbHastaBilgileri.TabStop = false;
            grbHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // grpRandevuBilgileri
            // 
            grpRandevuBilgileri.Controls.Add(lblSeansNot);
            grpRandevuBilgileri.Controls.Add(label24);
            grpRandevuBilgileri.Controls.Add(lblSeansSeans);
            grpRandevuBilgileri.Controls.Add(lblSeansUzman);
            grpRandevuBilgileri.Controls.Add(label21);
            grpRandevuBilgileri.Controls.Add(label22);
            grpRandevuBilgileri.Controls.Add(label18);
            grpRandevuBilgileri.Controls.Add(lnkRandevuIptalEt);
            grpRandevuBilgileri.Controls.Add(lblRandevuSeans);
            grpRandevuBilgileri.Controls.Add(lblRandevuUzman);
            grpRandevuBilgileri.Controls.Add(label15);
            grpRandevuBilgileri.Controls.Add(label14);
            grpRandevuBilgileri.Controls.Add(lnkYeniRandevu);
            grpRandevuBilgileri.Controls.Add(label13);
            grpRandevuBilgileri.Location = new Point(525, 0);
            grpRandevuBilgileri.Name = "grpRandevuBilgileri";
            grpRandevuBilgileri.Size = new Size(278, 579);
            grpRandevuBilgileri.TabIndex = 1;
            grpRandevuBilgileri.TabStop = false;
            grpRandevuBilgileri.Text = "Randevu Bilgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(67, 47);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(133, 23);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(67, 87);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(133, 23);
            txtSoyad.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(125, 132);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(75, 23);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 211);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Hastalar";
            // 
            // lnkYeniHastaGir
            // 
            lnkYeniHastaGir.AutoSize = true;
            lnkYeniHastaGir.LinkColor = Color.Black;
            lnkYeniHastaGir.Location = new Point(164, 182);
            lnkYeniHastaGir.Name = "lnkYeniHastaGir";
            lnkYeniHastaGir.Size = new Size(91, 15);
            lnkYeniHastaGir.TabIndex = 7;
            lnkYeniHastaGir.TabStop = true;
            lnkYeniHastaGir.Text = "Yeni Hasta Girişi";
            // 
            // IstHastalar
            // 
            IstHastalar.FormattingEnabled = true;
            IstHastalar.ItemHeight = 15;
            IstHastalar.Location = new Point(12, 229);
            IstHastalar.Name = "IstHastalar";
            IstHastalar.ScrollAlwaysVisible = true;
            IstHastalar.Size = new Size(243, 349);
            IstHastalar.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 74);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 9;
            label3.Text = "TC Kimlik No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 99);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 10;
            label5.Text = "Ad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 129);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Soyad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 156);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "Cinsiyeti:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 183);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 13;
            label8.Text = "E-Posta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 206);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 14;
            label9.Text = "Telefon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 235);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 15;
            label10.Text = "GSM No:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 264);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 16;
            label11.Text = "Doğum Tarihi:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 292);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 17;
            label12.Text = "Adres:";
            // 
            // lblTCKimlikNo
            // 
            lblTCKimlikNo.BorderStyle = BorderStyle.FixedSingle;
            lblTCKimlikNo.Location = new Point(125, 74);
            lblTCKimlikNo.Name = "lblTCKimlikNo";
            lblTCKimlikNo.Size = new Size(79, 15);
            lblTCKimlikNo.TabIndex = 18;
            // 
            // lblAd
            // 
            lblAd.BorderStyle = BorderStyle.FixedSingle;
            lblAd.Location = new Point(125, 99);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(79, 15);
            lblAd.TabIndex = 19;
            // 
            // lblSoyad
            // 
            lblSoyad.BorderStyle = BorderStyle.FixedSingle;
            lblSoyad.Location = new Point(125, 129);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(79, 15);
            lblSoyad.TabIndex = 20;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.BorderStyle = BorderStyle.FixedSingle;
            lblCinsiyet.Location = new Point(125, 156);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(79, 15);
            lblCinsiyet.TabIndex = 21;
            // 
            // lblEPosta
            // 
            lblEPosta.BorderStyle = BorderStyle.FixedSingle;
            lblEPosta.Location = new Point(125, 183);
            lblEPosta.Name = "lblEPosta";
            lblEPosta.Size = new Size(79, 15);
            lblEPosta.TabIndex = 22;
            // 
            // lblTelefon
            // 
            lblTelefon.BorderStyle = BorderStyle.FixedSingle;
            lblTelefon.Location = new Point(125, 206);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(79, 15);
            lblTelefon.TabIndex = 23;
            // 
            // lblGsmNo
            // 
            lblGsmNo.BorderStyle = BorderStyle.FixedSingle;
            lblGsmNo.Location = new Point(125, 235);
            lblGsmNo.Name = "lblGsmNo";
            lblGsmNo.Size = new Size(79, 15);
            lblGsmNo.TabIndex = 24;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.BorderStyle = BorderStyle.FixedSingle;
            lblDogumTarihi.Location = new Point(125, 264);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(79, 15);
            lblDogumTarihi.TabIndex = 25;
            // 
            // lblAdres
            // 
            lblAdres.BorderStyle = BorderStyle.FixedSingle;
            lblAdres.Location = new Point(68, 292);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(178, 98);
            lblAdres.TabIndex = 26;
            // 
            // lnkHastaGuncelle
            // 
            lnkHastaGuncelle.AutoSize = true;
            lnkHastaGuncelle.LinkColor = Color.Black;
            lnkHastaGuncelle.Location = new Point(108, 37);
            lnkHastaGuncelle.Name = "lnkHastaGuncelle";
            lnkHastaGuncelle.Size = new Size(138, 15);
            lnkHastaGuncelle.TabIndex = 27;
            lnkHastaGuncelle.TabStop = true;
            lnkHastaGuncelle.Text = "Hasta Bilgilerini Güncelle";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label13.Location = new Point(6, 55);
            label13.Name = "label13";
            label13.Size = new Size(137, 15);
            label13.TabIndex = 28;
            label13.Text = "Son Randevu Bilgileri";
            // 
            // lnkYeniRandevu
            // 
            lnkYeniRandevu.AutoSize = true;
            lnkYeniRandevu.LinkColor = Color.Black;
            lnkYeniRandevu.Location = new Point(187, 28);
            lnkYeniRandevu.Name = "lnkYeniRandevu";
            lnkYeniRandevu.Size = new Size(78, 15);
            lnkYeniRandevu.TabIndex = 29;
            lnkYeniRandevu.TabStop = true;
            lnkYeniRandevu.Text = "Yeni Randevu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 87);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 28;
            label14.Text = "Uzman:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 114);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 30;
            label15.Text = "Seans:";
            // 
            // lblRandevuUzman
            // 
            lblRandevuUzman.BorderStyle = BorderStyle.FixedSingle;
            lblRandevuUzman.Location = new Point(111, 87);
            lblRandevuUzman.Name = "lblRandevuUzman";
            lblRandevuUzman.Size = new Size(141, 15);
            lblRandevuUzman.TabIndex = 28;
            // 
            // lblRandevuSeans
            // 
            lblRandevuSeans.BorderStyle = BorderStyle.FixedSingle;
            lblRandevuSeans.Location = new Point(111, 114);
            lblRandevuSeans.Name = "lblRandevuSeans";
            lblRandevuSeans.Size = new Size(141, 15);
            lblRandevuSeans.TabIndex = 31;
            // 
            // lnkRandevuIptalEt
            // 
            lnkRandevuIptalEt.AutoSize = true;
            lnkRandevuIptalEt.LinkColor = Color.Black;
            lnkRandevuIptalEt.Location = new Point(173, 156);
            lnkRandevuIptalEt.Name = "lnkRandevuIptalEt";
            lnkRandevuIptalEt.Size = new Size(92, 15);
            lnkRandevuIptalEt.TabIndex = 32;
            lnkRandevuIptalEt.TabStop = true;
            lnkRandevuIptalEt.Text = "Randevu İptal Et";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label18.Location = new Point(6, 211);
            label18.Name = "label18";
            label18.Size = new Size(119, 15);
            label18.TabIndex = 33;
            label18.Text = "Son Seans Bilgileri";
            // 
            // lblSeansSeans
            // 
            lblSeansSeans.BorderStyle = BorderStyle.FixedSingle;
            lblSeansSeans.Location = new Point(111, 263);
            lblSeansSeans.Name = "lblSeansSeans";
            lblSeansSeans.Size = new Size(141, 15);
            lblSeansSeans.TabIndex = 37;
            // 
            // lblSeansUzman
            // 
            lblSeansUzman.BorderStyle = BorderStyle.FixedSingle;
            lblSeansUzman.Location = new Point(111, 235);
            lblSeansUzman.Name = "lblSeansUzman";
            lblSeansUzman.Size = new Size(141, 16);
            lblSeansUzman.TabIndex = 34;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 263);
            label21.Name = "label21";
            label21.Size = new Size(40, 15);
            label21.TabIndex = 36;
            label21.Text = "Seans:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 236);
            label22.Name = "label22";
            label22.Size = new Size(47, 15);
            label22.TabIndex = 35;
            label22.Text = "Uzman:";
            // 
            // lblSeansNot
            // 
            lblSeansNot.BorderStyle = BorderStyle.FixedSingle;
            lblSeansNot.Location = new Point(111, 292);
            lblSeansNot.Name = "lblSeansNot";
            lblSeansNot.Size = new Size(141, 98);
            lblSeansNot.TabIndex = 39;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 292);
            label24.Name = "label24";
            label24.Size = new Size(30, 15);
            label24.TabIndex = 38;
            label24.Text = "Not:";
            // 
            // FormHastaRandevuYonet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 577);
            Controls.Add(grpRandevuBilgileri);
            Controls.Add(grbHastaBilgileri);
            Controls.Add(grpArama);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormHastaRandevuYonet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta & Randevu Yonetimi";
            grpArama.ResumeLayout(false);
            grpArama.PerformLayout();
            grbHastaBilgileri.ResumeLayout(false);
            grbHastaBilgileri.PerformLayout();
            grpRandevuBilgileri.ResumeLayout(false);
            grpRandevuBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpArama;
        private GroupBox grbHastaBilgileri;
        private GroupBox grpRandevuBilgileri;
        private Button btnAra;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private Label label4;
        private ListBox IstHastalar;
        private LinkLabel lnkYeniHastaGir;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label lblAdres;
        private Label lblDogumTarihi;
        private Label lblGsmNo;
        private Label lblTelefon;
        private Label lblEPosta;
        private Label lblCinsiyet;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblTCKimlikNo;
        private LinkLabel lnkHastaGuncelle;
        private Label lblSeansSeans;
        private Label lblSeansUzman;
        private Label label21;
        private Label label22;
        private Label label18;
        private LinkLabel lnkRandevuIptalEt;
        private Label lblRandevuSeans;
        private Label lblRandevuUzman;
        private Label label15;
        private Label label14;
        private LinkLabel lnkYeniRandevu;
        private Label label13;
        private Label lblSeansNot;
        private Label label24;
    }
}