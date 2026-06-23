namespace SISWin
{
    partial class FormAnaSayfa
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
            components = new System.ComponentModel.Container();
            ManinMenu = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            mniParolaDegistir = new ToolStripMenuItem();
            mniParolaSifirla = new ToolStripMenuItem();
            mniUzmanKaydet = new ToolStripMenuItem();
            mniSekreterKaydet = new ToolStripMenuItem();
            mniCalisanAra = new ToolStripMenuItem();
            mniRandevuYonet = new ToolStripMenuItem();
            mniSeansYonetSekreter = new ToolStripMenuItem();
            mniAyrac = new ToolStripMenuItem();
            mniCikis = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tslKullanici = new ToolStripStatusLabel();
            tslTarih = new ToolStripStatusLabel();
            tslSaat = new ToolStripStatusLabel();
            tmrSaat = new System.Windows.Forms.Timer(components);
            uzmanSeansYönetToolStripMenuItem = new ToolStripMenuItem();
            ManinMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ManinMenu
            // 
            ManinMenu.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem });
            ManinMenu.Location = new Point(0, 0);
            ManinMenu.Name = "ManinMenu";
            ManinMenu.Size = new Size(800, 24);
            ManinMenu.TabIndex = 0;
            ManinMenu.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniParolaDegistir, mniParolaSifirla, mniUzmanKaydet, mniSekreterKaydet, mniCalisanAra, mniRandevuYonet, mniSeansYonetSekreter, uzmanSeansYönetToolStripMenuItem, mniAyrac, mniCikis });
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(50, 20);
            menüToolStripMenuItem.Text = "&Menü";
            menüToolStripMenuItem.Click += menüToolStripMenuItem_Click;
            // 
            // mniParolaDegistir
            // 
            mniParolaDegistir.Name = "mniParolaDegistir";
            mniParolaDegistir.Size = new Size(199, 22);
            mniParolaDegistir.Text = "Parola &Değiştir";
            mniParolaDegistir.Click += mniParolaDegistir_Click_1;
            // 
            // mniParolaSifirla
            // 
            mniParolaSifirla.Name = "mniParolaSifirla";
            mniParolaSifirla.Size = new Size(199, 22);
            mniParolaSifirla.Text = "Parola Sıfırla";
            mniParolaSifirla.Click += mniParolaSifirla_Click_1;
            // 
            // mniUzmanKaydet
            // 
            mniUzmanKaydet.Name = "mniUzmanKaydet";
            mniUzmanKaydet.Size = new Size(199, 22);
            mniUzmanKaydet.Text = "&Uzman Kaydet";
            mniUzmanKaydet.Click += mniUzmanKaydet_Click_1;
            // 
            // mniSekreterKaydet
            // 
            mniSekreterKaydet.Name = "mniSekreterKaydet";
            mniSekreterKaydet.Size = new Size(199, 22);
            mniSekreterKaydet.Text = "&Sekreter Kaydet";
            mniSekreterKaydet.Click += mniSekreterKaydet_Click_1;
            // 
            // mniCalisanAra
            // 
            mniCalisanAra.Name = "mniCalisanAra";
            mniCalisanAra.Size = new Size(199, 22);
            mniCalisanAra.Text = "Çalışan &Ara";
            mniCalisanAra.Click += mniCalisanAra_Click1;
            // 
            // mniRandevuYonet
            // 
            mniRandevuYonet.Name = "mniRandevuYonet";
            mniRandevuYonet.Size = new Size(199, 22);
            mniRandevuYonet.Text = "Hasta && &Randevu Yönet";
            mniRandevuYonet.Click += mniRandevuYonet_Click1;
            // 
            // mniSeansYonetSekreter
            // 
            mniSeansYonetSekreter.Name = "mniSeansYonetSekreter";
            mniSeansYonetSekreter.Size = new Size(199, 22);
            mniSeansYonetSekreter.Text = "&Seans Yönet";
            mniSeansYonetSekreter.Click += mniSeansYonetSekreter_Click1;
            // 
            // mniAyrac
            // 
            mniAyrac.Name = "mniAyrac";
            mniAyrac.Size = new Size(199, 22);
            mniAyrac.Text = "-";
            // 
            // mniCikis
            // 
            mniCikis.Name = "mniCikis";
            mniCikis.Size = new Size(199, 22);
            mniCikis.Text = "&Çıkış";
            mniCikis.Click += mniCikis_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslKullanici, tslTarih, tslSaat });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslKullanici
            // 
            tslKullanici.Name = "tslKullanici";
            tslKullanici.Size = new Size(690, 17);
            tslKullanici.Spring = true;
            tslKullanici.Text = "Cemal Kıvrak (Sistem Yöneticisi)";
            // 
            // tslTarih
            // 
            tslTarih.Name = "tslTarih";
            tslTarih.Size = new Size(61, 17);
            tslTarih.Text = "15.06.2026";
            // 
            // tslSaat
            // 
            tslSaat.Name = "tslSaat";
            tslSaat.Size = new Size(34, 17);
            tslSaat.Text = "11:57";
            // 
            // tmrSaat
            // 
            tmrSaat.Enabled = true;
            tmrSaat.Interval = 1000;
            tmrSaat.Tick += tmrSaat_Tick_1;
            // 
            // uzmanSeansYönetToolStripMenuItem
            // 
            uzmanSeansYönetToolStripMenuItem.Name = "uzmanSeansYönetToolStripMenuItem";
            uzmanSeansYönetToolStripMenuItem.Size = new Size(199, 22);
            uzmanSeansYönetToolStripMenuItem.Text = "&Uzman &Seans Yönet";
            uzmanSeansYönetToolStripMenuItem.Click += uzmanSeansYönetToolStripMenuItem_Click;
            // 
            // FormAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(ManinMenu);
            MainMenuStrip = ManinMenu;
            Name = "FormAnaSayfa";
            Text = "FormAnaSayfa";
            ManinMenu.ResumeLayout(false);
            ManinMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ManinMenu;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripMenuItem mniParolaDegistir;
        private ToolStripMenuItem mniParolaSifirla;
        private ToolStripMenuItem mniUzmanKaydet;
        private ToolStripMenuItem mniSekreterKaydet;
        private ToolStripMenuItem mniCalisanAra;
        private ToolStripMenuItem mniRandevuYonet;
        private ToolStripMenuItem mniSeansYonetSekreter;
        private ToolStripMenuItem mniCikis;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslKullanici;
        private ToolStripStatusLabel tslTarih;
        private ToolStripStatusLabel tslSaat;
        private ToolStripMenuItem mniAyrac;
        private System.Windows.Forms.Timer tmrSaat;
        private ToolStripMenuItem uzmanSeansYönetToolStripMenuItem;
    }
}