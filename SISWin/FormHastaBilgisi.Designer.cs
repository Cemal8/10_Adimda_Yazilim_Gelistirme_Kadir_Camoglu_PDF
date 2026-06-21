namespace SISWin
{
    partial class FormHastaBilgisi
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
            lblAyrac = new Label();
            btnKaydet = new Button();
            txtGsmNo = new TextBox();
            txtTelefon = new TextBox();
            txtEPosta = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtKimlikNo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dtpDogumTarihi = new DateTimePicker();
            cbbCinsiyet = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtAdres = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(342, 397);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(368, 1);
            lblAyrac.TabIndex = 29;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(599, 410);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(111, 23);
            btnKaydet.TabIndex = 28;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtGsmNo
            // 
            txtGsmNo.Location = new Point(436, 312);
            txtGsmNo.MaxLength = 13;
            txtGsmNo.Name = "txtGsmNo";
            txtGsmNo.Size = new Size(100, 23);
            txtGsmNo.TabIndex = 27;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(436, 283);
            txtTelefon.MaxLength = 13;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 26;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(436, 254);
            txtEPosta.MaxLength = 50;
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(100, 23);
            txtEPosta.TabIndex = 25;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(436, 166);
            txtSoyad.MaxLength = 50;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 24;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(436, 138);
            txtAd.MaxLength = 50;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 23;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(436, 109);
            txtKimlikNo.MaxLength = 11;
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(100, 23);
            txtKimlikNo.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(342, 311);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 21;
            label6.Text = "GSM No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 284);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 20;
            label5.Text = "Telefon No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(342, 257);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 19;
            label4.Text = "E-Posta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(342, 169);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 18;
            label3.Text = "Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(342, 143);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 117);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 16;
            label1.Text = "TC Kimlik No";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(78, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(436, 195);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(168, 23);
            dtpDogumTarihi.TabIndex = 30;
            // 
            // cbbCinsiyet
            // 
            cbbCinsiyet.FormattingEnabled = true;
            cbbCinsiyet.Items.AddRange(new object[] { "E", "K" });
            cbbCinsiyet.Location = new Point(436, 227);
            cbbCinsiyet.Name = "cbbCinsiyet";
            cbbCinsiyet.Size = new Size(121, 23);
            cbbCinsiyet.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 201);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 32;
            label7.Text = "Doğum Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 227);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 33;
            label8.Text = "Cinsiyet";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(436, 341);
            txtAdres.MaxLength = 350;
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(342, 340);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(40, 15);
            label9.TabIndex = 34;
            label9.Text = "Adres:";
            // 
            // FormHastaBilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 717);
            Controls.Add(txtAdres);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbbCinsiyet);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(lblAyrac);
            Controls.Add(btnKaydet);
            Controls.Add(txtGsmNo);
            Controls.Add(txtTelefon);
            Controls.Add(txtEPosta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtKimlikNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormHastaBilgisi";
            Text = "Hasta Bilgisi";
            Load += FormHastaBilgisi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAyrac;
        private Button btnKaydet;
        private TextBox txtGsmNo;
        private TextBox txtTelefon;
        private TextBox txtEPosta;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtKimlikNo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dtpDogumTarihi;
        private ComboBox cbbCinsiyet;
        private Label label7;
        private Label label8;
        private TextBox txtAdres;
        private Label label9;
    }
}