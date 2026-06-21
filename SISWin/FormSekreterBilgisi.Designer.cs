namespace SISWin
{
    partial class FormSekreterBilgisi
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtKimlikNo = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEPosta = new TextBox();
            txtTelefon = new TextBox();
            txtGsmNo = new TextBox();
            btnKaydet = new Button();
            lblAyrac = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(93, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 98);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(301, 124);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(301, 150);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Soyadı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(301, 178);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "E-Posta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 205);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefon No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 232);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 6;
            label6.Text = "GSM No:";
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(395, 90);
            txtKimlikNo.MaxLength = 11;
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(100, 23);
            txtKimlikNo.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(395, 119);
            txtAd.MaxLength = 50;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 8;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(395, 147);
            txtSoyad.MaxLength = 50;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 9;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(395, 175);
            txtEPosta.MaxLength = 100;
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(100, 23);
            txtEPosta.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(395, 204);
            txtTelefon.MaxLength = 50;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 11;
            // 
            // txtGsmNo
            // 
            txtGsmNo.Location = new Point(395, 233);
            txtGsmNo.MaxLength = 50;
            txtGsmNo.Name = "txtGsmNo";
            txtGsmNo.Size = new Size(100, 23);
            txtGsmNo.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(384, 301);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(111, 23);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(301, 277);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(195, 2);
            lblAyrac.TabIndex = 14;
            // 
            // FormSekreterBilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSekreterBilgisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sekreter";
            Load += FormSekreterBilgisi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtKimlikNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEPosta;
        private TextBox txtTelefon;
        private TextBox txtGsmNo;
        private Button btnKaydet;
        private Label lblAyrac;
    }
}