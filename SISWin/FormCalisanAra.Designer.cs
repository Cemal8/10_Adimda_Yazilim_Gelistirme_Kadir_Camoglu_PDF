namespace SISWin
{
    partial class FormCalisanAra
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
            lblAyrac = new Label();
            btnAra = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstCalisanlar = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(154, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(378, 218);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(195, 2);
            lblAyrac.TabIndex = 30;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(462, 180);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(111, 23);
            btnAra.TabIndex = 29;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(472, 105);
            txtAd.MaxLength = 50;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 24;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(472, 136);
            txtSoyad.MaxLength = 50;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(378, 139);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 18;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 113);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 17;
            label1.Text = "Adı:";
            // 
            // lstCalisanlar
            // 
            lstCalisanlar.FormattingEnabled = true;
            lstCalisanlar.ItemHeight = 15;
            lstCalisanlar.Location = new Point(378, 249);
            lstCalisanlar.Name = "lstCalisanlar";
            lstCalisanlar.ScrollAlwaysVisible = true;
            lstCalisanlar.Size = new Size(203, 124);
            lstCalisanlar.TabIndex = 31;
            lstCalisanlar.DoubleClick += lstCalisanlar_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(378, 231);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 32;
            label3.Text = "Çalışanlar";
            // 
            // FormCalisanAra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(label3);
            Controls.Add(lstCalisanlar);
            Controls.Add(lblAyrac);
            Controls.Add(btnAra);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCalisanAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalisanAra";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAyrac;
        private Button btnAra;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label2;
        private Label label1;
        private ListBox lstCalisanlar;
        private Label label3;
    }
}