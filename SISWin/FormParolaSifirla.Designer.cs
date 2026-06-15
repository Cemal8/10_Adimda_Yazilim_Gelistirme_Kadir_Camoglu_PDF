namespace SISWin
{
    partial class FormParolaSifirla
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
            btnSifirla = new Button();
            txtEPosta = new TextBox();
            txtParola = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAyrac
            // 
            lblAyrac.BorderStyle = BorderStyle.Fixed3D;
            lblAyrac.Location = new Point(271, 177);
            lblAyrac.Name = "lblAyrac";
            lblAyrac.Size = new Size(240, 2);
            lblAyrac.TabIndex = 48;
            // 
            // btnSifirla
            // 
            btnSifirla.Location = new Point(389, 192);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(111, 23);
            btnSifirla.TabIndex = 47;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(389, 105);
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(100, 23);
            txtEPosta.TabIndex = 46;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(389, 136);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(100, 23);
            txtParola.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(272, 139);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 44;
            label2.Text = "Yeni Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 113);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 43;
            label1.Text = "EPosta:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_avatar_svg;
            pictureBox1.Location = new Point(65, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // FormParolaSifirla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAyrac);
            Controls.Add(btnSifirla);
            Controls.Add(txtEPosta);
            Controls.Add(txtParola);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormParolaSifirla";
            Text = "FormParolaSifirla";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAyrac;
        private Button btnSifirla;
        private TextBox txtEPosta;
        private TextBox txtParola;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}