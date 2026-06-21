namespace SISWin
{
    partial class FormRandevuKaydet
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKaydet = new Button();
            cbbUzmanlar = new ComboBox();
            cbbSeanslar = new ComboBox();
            lblHasta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(297, 223);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(290, 2);
            lblAyrac.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 102);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Hasta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 138);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Uzman:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 175);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Seans:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(472, 240);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cbbUzmanlar
            // 
            cbbUzmanlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUzmanlar.FormattingEnabled = true;
            cbbUzmanlar.Location = new Point(401, 135);
            cbbUzmanlar.Name = "cbbUzmanlar";
            cbbUzmanlar.Size = new Size(186, 23);
            cbbUzmanlar.TabIndex = 12;
            cbbUzmanlar.SelectedIndexChanged += cbbUzmanlar_SelectedIndexChanged;
            // 
            // cbbSeanslar
            // 
            cbbSeanslar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSeanslar.FormattingEnabled = true;
            cbbSeanslar.Location = new Point(401, 172);
            cbbSeanslar.Name = "cbbSeanslar";
            cbbSeanslar.Size = new Size(186, 23);
            cbbSeanslar.TabIndex = 13;
            cbbSeanslar.SelectedIndexChanged += cbbSeanslar_SelectedIndexChanged;
            // 
            // lblHasta
            // 
            lblHasta.Location = new Point(401, 99);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(186, 23);
            lblHasta.TabIndex = 14;
            // 
            // FormRandevuKaydet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHasta);
            Controls.Add(cbbSeanslar);
            Controls.Add(cbbUzmanlar);
            Controls.Add(btnKaydet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAyrac);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRandevuKaydet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu Kaydet";
            Load += FormRandevuKaydet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAyrac;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKaydet;
        private ComboBox cbbUzmanlar;
        private ComboBox cbbSeanslar;
        private TextBox lblHasta;
    }
}