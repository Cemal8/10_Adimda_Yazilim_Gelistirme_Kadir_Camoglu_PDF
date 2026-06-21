namespace SISWin
{
    partial class FormParolaDegistir
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
            btnDegistir = new Button();
            txtEski = new TextBox();
            txtYeni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtYeni2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(290, 172);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(240, 2);
            lblAyrac.TabIndex = 39;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(408, 187);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(111, 23);
            btnDegistir.TabIndex = 38;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // txtEski
            // 
            txtEski.Location = new Point(408, 73);
            txtEski.MaxLength = 10;
            txtEski.Name = "txtEski";
            txtEski.PasswordChar = '*';
            txtEski.Size = new Size(100, 23);
            txtEski.TabIndex = 37;
            // 
            // txtYeni
            // 
            txtYeni.Location = new Point(408, 104);
            txtYeni.MaxLength = 10;
            txtYeni.Name = "txtYeni";
            txtYeni.PasswordChar = '*';
            txtYeni.Size = new Size(100, 23);
            txtYeni.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(291, 107);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 35;
            label2.Text = "Yeni Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 81);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 34;
            label1.Text = "Eski Parola:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(84, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // txtYeni2
            // 
            txtYeni2.Location = new Point(408, 135);
            txtYeni2.MaxLength = 10;
            txtYeni2.Name = "txtYeni2";
            txtYeni2.PasswordChar = '*';
            txtYeni2.Size = new Size(100, 23);
            txtYeni2.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(291, 138);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 40;
            label3.Text = "Yeni Parola (Tekrar):";
            // 
            // FormParolaDegistir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 287);
            Controls.Add(txtYeni2);
            Controls.Add(label3);
            Controls.Add(lblAyrac);
            Controls.Add(btnDegistir);
            Controls.Add(txtEski);
            Controls.Add(txtYeni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormParolaDegistir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parola Değiştirme";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAyrac;
        private Button btnDegistir;
        private TextBox txtEski;
        private TextBox txtYeni;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtYeni2;
        private Label label3;
    }
}