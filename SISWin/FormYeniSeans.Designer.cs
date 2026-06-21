namespace SISWin
{
    partial class FormYeniSeans
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
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblUzman = new Label();
            dtpBaslangicSaati = new DateTimePicker();
            dtpBaslingicSaati = new DateTimePicker();
            dtpBitisSaati = new DateTimePicker();
            lblAyrac = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(49, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(575, 243);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(85, 35);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 93);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Uzman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 125);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 161);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Başlangıç Saati:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 190);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Bitiş Saati:";
            // 
            // lblUzman
            // 
            lblUzman.BorderStyle = BorderStyle.FixedSingle;
            lblUzman.Location = new Point(439, 82);
            lblUzman.Name = "lblUzman";
            lblUzman.Size = new Size(221, 26);
            lblUzman.TabIndex = 6;
            // 
            // dtpBaslangicSaati
            // 
            dtpBaslangicSaati.Format = DateTimePickerFormat.Short;
            dtpBaslangicSaati.Location = new Point(439, 117);
            dtpBaslangicSaati.Name = "dtpBaslangicSaati";
            dtpBaslangicSaati.Size = new Size(221, 23);
            dtpBaslangicSaati.TabIndex = 7;
            // 
            // dtpBaslingicSaati
            // 
            dtpBaslingicSaati.CustomFormat = "HH:mm";
            dtpBaslingicSaati.Format = DateTimePickerFormat.Custom;
            dtpBaslingicSaati.Location = new Point(439, 155);
            dtpBaslingicSaati.Name = "dtpBaslingicSaati";
            dtpBaslingicSaati.Size = new Size(221, 23);
            dtpBaslingicSaati.TabIndex = 8;
            // 
            // dtpBitisSaati
            // 
            dtpBitisSaati.CustomFormat = "HH:mm";
            dtpBitisSaati.Format = DateTimePickerFormat.Custom;
            dtpBitisSaati.Location = new Point(439, 184);
            dtpBitisSaati.Name = "dtpBitisSaati";
            dtpBitisSaati.Size = new Size(221, 23);
            dtpBitisSaati.TabIndex = 9;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(293, 223);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(495, 2);
            lblAyrac.TabIndex = 15;
            // 
            // FormYeniSeans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAyrac);
            Controls.Add(dtpBitisSaati);
            Controls.Add(dtpBaslingicSaati);
            Controls.Add(dtpBaslangicSaati);
            Controls.Add(lblUzman);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormYeniSeans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu Kaydet";
            Load += FormYeniSeans_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblUzman;
        private DateTimePicker dtpBaslangicSaati;
        private DateTimePicker dtpBaslingicSaati;
        private DateTimePicker dtpBitisSaati;
        private Label lblAyrac;
    }
}