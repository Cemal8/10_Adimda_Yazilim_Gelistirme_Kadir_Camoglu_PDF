namespace SISWin
{
    partial class FormSeansIptalEt
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
            btnIptal = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblUzman = new TextBox();
            lblSeans = new TextBox();
            txtIptalNedeni = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(348, 196);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(368, 1);
            lblAyrac.TabIndex = 32;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(605, 209);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(111, 23);
            btnIptal.TabIndex = 31;
            btnIptal.Text = "İptal Et";
            btnIptal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(84, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 72);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 33;
            label1.Text = "Uzman:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 144);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 34;
            label2.Text = "Seans:";
            // 
            // lblUzman
            // 
            lblUzman.Location = new Point(448, 69);
            lblUzman.Name = "lblUzman";
            lblUzman.Size = new Size(268, 23);
            lblUzman.TabIndex = 35;
            // 
            // lblSeans
            // 
            lblSeans.Location = new Point(448, 141);
            lblSeans.Name = "lblSeans";
            lblSeans.Size = new Size(268, 23);
            lblSeans.TabIndex = 36;
            // 
            // txtIptalNedeni
            // 
            txtIptalNedeni.Location = new Point(448, 259);
            txtIptalNedeni.Multiline = true;
            txtIptalNedeni.Name = "txtIptalNedeni";
            txtIptalNedeni.Size = new Size(268, 23);
            txtIptalNedeni.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 267);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 37;
            label3.Text = "İptal Nedeni:";
            // 
            // FormSeansIptalEt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIptalNedeni);
            Controls.Add(label3);
            Controls.Add(lblSeans);
            Controls.Add(lblUzman);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAyrac);
            Controls.Add(btnIptal);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSeansIptalEt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seans İptal Et";
            Load += FormSeansIptalEt_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAyrac;
        private Button btnIptal;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox lblUzman;
        private TextBox lblSeans;
        private TextBox txtIptalNedeni;
        private Label label3;
    }
}