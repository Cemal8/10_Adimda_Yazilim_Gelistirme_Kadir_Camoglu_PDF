namespace SISWin
{
    partial class FormUzmanBilgisi
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(407, 299);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(195, 2);
            lblAyrac.TabIndex = 29;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(490, 323);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(111, 23);
            btnKaydet.TabIndex = 28;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtGsmNo
            // 
            txtGsmNo.Location = new Point(501, 255);
            txtGsmNo.Name = "txtGsmNo";
            txtGsmNo.Size = new Size(100, 23);
            txtGsmNo.TabIndex = 27;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(501, 226);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 26;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(501, 197);
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(100, 23);
            txtEPosta.TabIndex = 25;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(501, 169);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 24;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(501, 141);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 23;
            // 
            // txtKimlikNo
            // 
            txtKimlikNo.Location = new Point(501, 112);
            txtKimlikNo.Name = "txtKimlikNo";
            txtKimlikNo.Size = new Size(100, 23);
            txtKimlikNo.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 254);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 21;
            label6.Text = "GSM No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 227);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 20;
            label5.Text = "Telefon No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(407, 200);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 19;
            label4.Text = "E-Posta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(407, 172);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 18;
            label3.Text = "Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(407, 146);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 17;
            label2.Text = "Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 120);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 16;
            label1.Text = "TC Kimlik No";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(199, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FormUzmanBilgisi
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
            Name = "FormUzmanBilgisi";
            Text = "Uzman";
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
    }
}