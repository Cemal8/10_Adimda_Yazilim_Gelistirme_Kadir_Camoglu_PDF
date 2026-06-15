namespace SISWin
{
    partial class FormSeansYonetimi
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
            cbbUzmanlar = new ComboBox();
            listBox1 = new ListBox();
            lblAyrac = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cbbUzmanlar
            // 
            cbbUzmanlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUzmanlar.FormattingEnabled = true;
            cbbUzmanlar.Location = new Point(343, 41);
            cbbUzmanlar.Name = "cbbUzmanlar";
            cbbUzmanlar.Size = new Size(121, 23);
            cbbUzmanlar.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(292, 109);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(404, 199);
            listBox1.TabIndex = 2;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(292, 76);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(368, 2);
            lblAyrac.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 44);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 31;
            label1.Text = "Uzman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 32;
            label2.Text = "Seanslar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(610, 91);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(86, 15);
            label3.TabIndex = 33;
            label3.Text = "Yeni Seans Ekle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 318);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(109, 15);
            label4.TabIndex = 34;
            label4.Text = "Seçili Seansı İptal Et";
            // 
            // FormSeansYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAyrac);
            Controls.Add(listBox1);
            Controls.Add(cbbUzmanlar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSeansYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seans Yonetimi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cbbUzmanlar;
        private ListBox listBox1;
        private Label lblAyrac;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}