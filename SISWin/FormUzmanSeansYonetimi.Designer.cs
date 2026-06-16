namespace SISWin
{
    partial class FormUzmanSeansYonetimi
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
            cbbSeanslar = new ComboBox();
            label1 = new Label();
            grbHastaBilgileri = new GroupBox();
            grpHastaGecmisi = new GroupBox();
            grpSeansNotu = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblTCKimlikNo = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblCinsiyet = new Label();
            lblEPosta = new Label();
            lblTelefon = new Label();
            lblGsmNo = new Label();
            lblDogumTarihi = new Label();
            label11 = new Label();
            lstSeanslar = new ListBox();
            label12 = new Label();
            txtGecmisSeansNotu = new TextBox();
            btnGüncelle = new Button();
            txtAktifSeansNotu = new TextBox();
            btnKaydet = new Button();
            grbHastaBilgileri.SuspendLayout();
            grpHastaGecmisi.SuspendLayout();
            grpSeansNotu.SuspendLayout();
            SuspendLayout();
            // 
            // cbbSeanslar
            // 
            cbbSeanslar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSeanslar.FormattingEnabled = true;
            cbbSeanslar.Location = new Point(86, 12);
            cbbSeanslar.Name = "cbbSeanslar";
            cbbSeanslar.Size = new Size(251, 23);
            cbbSeanslar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Seanslar";
            // 
            // grbHastaBilgileri
            // 
            grbHastaBilgileri.Controls.Add(label11);
            grbHastaBilgileri.Controls.Add(lblDogumTarihi);
            grbHastaBilgileri.Controls.Add(lblGsmNo);
            grbHastaBilgileri.Controls.Add(lblTelefon);
            grbHastaBilgileri.Controls.Add(lblEPosta);
            grbHastaBilgileri.Controls.Add(lblCinsiyet);
            grbHastaBilgileri.Controls.Add(lblSoyad);
            grbHastaBilgileri.Controls.Add(lblAd);
            grbHastaBilgileri.Controls.Add(lblTCKimlikNo);
            grbHastaBilgileri.Controls.Add(label10);
            grbHastaBilgileri.Controls.Add(label9);
            grbHastaBilgileri.Controls.Add(label8);
            grbHastaBilgileri.Controls.Add(label7);
            grbHastaBilgileri.Controls.Add(label6);
            grbHastaBilgileri.Controls.Add(label5);
            grbHastaBilgileri.Controls.Add(label4);
            grbHastaBilgileri.Controls.Add(label3);
            grbHastaBilgileri.Controls.Add(label2);
            grbHastaBilgileri.Location = new Point(12, 54);
            grbHastaBilgileri.Name = "grbHastaBilgileri";
            grbHastaBilgileri.Size = new Size(325, 624);
            grbHastaBilgileri.TabIndex = 2;
            grbHastaBilgileri.TabStop = false;
            grbHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // grpHastaGecmisi
            // 
            grpHastaGecmisi.Controls.Add(btnGüncelle);
            grpHastaGecmisi.Controls.Add(txtGecmisSeansNotu);
            grpHastaGecmisi.Controls.Add(label12);
            grpHastaGecmisi.Controls.Add(lstSeanslar);
            grpHastaGecmisi.Location = new Point(363, 54);
            grpHastaGecmisi.Name = "grpHastaGecmisi";
            grpHastaGecmisi.Size = new Size(325, 624);
            grpHastaGecmisi.TabIndex = 3;
            grpHastaGecmisi.TabStop = false;
            grpHastaGecmisi.Text = "Hasta Geçmişi";
            // 
            // grpSeansNotu
            // 
            grpSeansNotu.Controls.Add(btnKaydet);
            grpSeansNotu.Controls.Add(txtAktifSeansNotu);
            grpSeansNotu.Location = new Point(722, 54);
            grpSeansNotu.Name = "grpSeansNotu";
            grpSeansNotu.Size = new Size(325, 624);
            grpSeansNotu.TabIndex = 4;
            grpSeansNotu.TabStop = false;
            grpSeansNotu.Text = "Seans Notu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Soyadı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(52, 15);
            label5.TabIndex = 3;
            label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 139);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 4;
            label6.Text = "E-Posta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 167);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 5;
            label7.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 199);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 6;
            label8.Text = "GSM No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 230);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 7;
            label9.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 255);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 8;
            label10.Text = "Adres:";
            // 
            // lblTCKimlikNo
            // 
            lblTCKimlikNo.BorderStyle = BorderStyle.FixedSingle;
            lblTCKimlikNo.Location = new Point(100, 40);
            lblTCKimlikNo.Name = "lblTCKimlikNo";
            lblTCKimlikNo.Size = new Size(219, 23);
            lblTCKimlikNo.TabIndex = 9;
            // 
            // lblAd
            // 
            lblAd.BorderStyle = BorderStyle.FixedSingle;
            lblAd.Location = new Point(100, 64);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(219, 23);
            lblAd.TabIndex = 10;
            // 
            // lblSoyad
            // 
            lblSoyad.BorderStyle = BorderStyle.FixedSingle;
            lblSoyad.Location = new Point(100, 89);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(219, 23);
            lblSoyad.TabIndex = 11;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.BorderStyle = BorderStyle.FixedSingle;
            lblCinsiyet.Location = new Point(100, 113);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(219, 23);
            lblCinsiyet.TabIndex = 12;
            // 
            // lblEPosta
            // 
            lblEPosta.BorderStyle = BorderStyle.FixedSingle;
            lblEPosta.Location = new Point(100, 139);
            lblEPosta.Name = "lblEPosta";
            lblEPosta.Size = new Size(219, 23);
            lblEPosta.TabIndex = 13;
            // 
            // lblTelefon
            // 
            lblTelefon.BorderStyle = BorderStyle.FixedSingle;
            lblTelefon.Location = new Point(100, 166);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(219, 23);
            lblTelefon.TabIndex = 14;
            // 
            // lblGsmNo
            // 
            lblGsmNo.BorderStyle = BorderStyle.FixedSingle;
            lblGsmNo.Location = new Point(100, 191);
            lblGsmNo.Name = "lblGsmNo";
            lblGsmNo.Size = new Size(219, 23);
            lblGsmNo.TabIndex = 15;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.BorderStyle = BorderStyle.FixedSingle;
            lblDogumTarihi.Location = new Point(100, 222);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(219, 23);
            lblDogumTarihi.TabIndex = 16;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(100, 255);
            label11.Name = "label11";
            label11.Size = new Size(219, 270);
            label11.TabIndex = 17;
            // 
            // lstSeanslar
            // 
            lstSeanslar.FormattingEnabled = true;
            lstSeanslar.ItemHeight = 15;
            lstSeanslar.Location = new Point(6, 191);
            lstSeanslar.Name = "lstSeanslar";
            lstSeanslar.ScrollAlwaysVisible = true;
            lstSeanslar.Size = new Size(313, 334);
            lstSeanslar.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 30);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 6;
            label12.Text = "Seanslar";
            // 
            // txtGecmisSeansNotu
            // 
            txtGecmisSeansNotu.Location = new Point(6, 48);
            txtGecmisSeansNotu.Multiline = true;
            txtGecmisSeansNotu.Name = "txtGecmisSeansNotu";
            txtGecmisSeansNotu.ScrollBars = ScrollBars.Vertical;
            txtGecmisSeansNotu.Size = new Size(313, 134);
            txtGecmisSeansNotu.TabIndex = 7;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(237, 543);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(82, 32);
            btnGüncelle.TabIndex = 8;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // txtAktifSeansNotu
            // 
            txtAktifSeansNotu.Location = new Point(6, 32);
            txtAktifSeansNotu.Multiline = true;
            txtAktifSeansNotu.Name = "txtAktifSeansNotu";
            txtAktifSeansNotu.ScrollBars = ScrollBars.Vertical;
            txtAktifSeansNotu.Size = new Size(313, 493);
            txtAktifSeansNotu.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(227, 543);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(82, 32);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // FormUzmanSeansYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 746);
            Controls.Add(grpSeansNotu);
            Controls.Add(grpHastaGecmisi);
            Controls.Add(grbHastaBilgileri);
            Controls.Add(label1);
            Controls.Add(cbbSeanslar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormUzmanSeansYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uzman Seans Yönetimi";
            grbHastaBilgileri.ResumeLayout(false);
            grbHastaBilgileri.PerformLayout();
            grpHastaGecmisi.ResumeLayout(false);
            grpHastaGecmisi.PerformLayout();
            grpSeansNotu.ResumeLayout(false);
            grpSeansNotu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbSeanslar;
        private Label label1;
        private GroupBox grbHastaBilgileri;
        private GroupBox grpHastaGecmisi;
        private GroupBox grpSeansNotu;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label lblDogumTarihi;
        private Label lblGsmNo;
        private Label lblTelefon;
        private Label lblEPosta;
        private Label lblCinsiyet;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblTCKimlikNo;
        private Button btnGüncelle;
        private TextBox txtGecmisSeansNotu;
        private Label label12;
        private ListBox lstSeanslar;
        private Button btnKaydet;
        private TextBox txtAktifSeansNotu;
    }
}