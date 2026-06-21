using System;
using ISK = SISIsKatmani;
using VAR = SISVarliklar;

namespace SISWin
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtKullanici = new TextBox();
            label2 = new Label();
            txtParola = new TextBox();
            btnGir = new Button();
            lblAyrac = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(329, 112);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı:";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_black_padlock_illustration_login_computer_icons_iconfinder_website_login_key_icon_lock_locked_login_miscellaneous_user_password;
            pictureBox1.Location = new Point(98, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(391, 109);
            txtKullanici.MaxLength = 100;
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(100, 23);
            txtKullanici.TabIndex = 2;
            txtKullanici.Text = "abc";
            txtKullanici.TextChanged += txtKullanici_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(329, 146);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            label2.Click += label2_Click;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(391, 143);
            txtParola.MaxLength = 10;
            txtParola.Multiline = true;
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(100, 23);
            txtParola.TabIndex = 4;
            txtParola.Text = "111";
            txtParola.TextChanged += txtParola_TextChanged;
            // 
            // btnGir
            // 
            btnGir.Location = new Point(329, 206);
            btnGir.Name = "btnGir";
            btnGir.Size = new Size(195, 48);
            btnGir.TabIndex = 5;
            btnGir.Text = "Gir";
            btnGir.UseVisualStyleBackColor = true;
            btnGir.Click += btnGir_Click;
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(329, 180);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(195, 2);
            lblAyrac.TabIndex = 6;
            lblAyrac.Click += lblAyrac_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAyrac);
            Controls.Add(btnGir);
            Controls.Add(txtParola);
            Controls.Add(label2);
            Controls.Add(txtKullanici);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblAyrac_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtKullanici;
        private Label label2;
        private TextBox txtParola;
        private Button btnGir;
        private Label lblAyrac;
    }
}
