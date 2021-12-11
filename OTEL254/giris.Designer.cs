namespace OTEL254
{
    partial class giris
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.tKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.bGiris = new System.Windows.Forms.Button();
            this.bSifreUnuttum = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Lavender;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(323, 17);
            this.tSAciklama.Text = "Bu program www.projevekod.com tarafından tasarlanmıştır.";
            // 
            // tKullaniciAdi
            // 
            this.tKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tKullaniciAdi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tKullaniciAdi.Location = new System.Drawing.Point(115, 96);
            this.tKullaniciAdi.MaxLength = 25;
            this.tKullaniciAdi.Name = "tKullaniciAdi";
            this.tKullaniciAdi.Size = new System.Drawing.Size(256, 29);
            this.tKullaniciAdi.TabIndex = 5;
            this.tKullaniciAdi.Text = "kullanıcı adı";
            this.tKullaniciAdi.Click += new System.EventHandler(this.tClick);
            this.tKullaniciAdi.TextChanged += new System.EventHandler(this.tChanged);
            this.tKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tKeyPress);
            // 
            // tSifre
            // 
            this.tSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSifre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tSifre.Location = new System.Drawing.Point(115, 131);
            this.tSifre.MaxLength = 50;
            this.tSifre.Name = "tSifre";
            this.tSifre.Size = new System.Drawing.Size(256, 29);
            this.tSifre.TabIndex = 6;
            this.tSifre.Text = "Şifre";
            this.tSifre.Click += new System.EventHandler(this.tClick);
            this.tSifre.TextChanged += new System.EventHandler(this.tChanged);
            // 
            // bGiris
            // 
            this.bGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGiris.ForeColor = System.Drawing.Color.Cornsilk;
            this.bGiris.Location = new System.Drawing.Point(289, 166);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(82, 36);
            this.bGiris.TabIndex = 7;
            this.bGiris.Text = "Giriş";
            this.bGiris.UseVisualStyleBackColor = false;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            // 
            // bSifreUnuttum
            // 
            this.bSifreUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSifreUnuttum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSifreUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSifreUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSifreUnuttum.ForeColor = System.Drawing.Color.Cornsilk;
            this.bSifreUnuttum.Location = new System.Drawing.Point(115, 166);
            this.bSifreUnuttum.Name = "bSifreUnuttum";
            this.bSifreUnuttum.Size = new System.Drawing.Size(168, 36);
            this.bSifreUnuttum.TabIndex = 8;
            this.bSifreUnuttum.Text = "Şifremi unuttum";
            this.bSifreUnuttum.UseVisualStyleBackColor = false;
            // 
            // pLogo
            // 
            this.pLogo.Image = global::OTEL254.Properties.Resources.baslik;
            this.pLogo.Location = new System.Drawing.Point(46, 22);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(398, 50);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pLogo.TabIndex = 0;
            this.pLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "admin";
            // 
            // giris
            // 
            this.AcceptButton = this.bGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(488, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSifreUnuttum);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.tKullaniciAdi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.giris_FormClosed);
            this.Load += new System.EventHandler(this.giris_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        private System.Windows.Forms.TextBox tKullaniciAdi;
        private System.Windows.Forms.TextBox tSifre;
        private System.Windows.Forms.Button bGiris;
        private System.Windows.Forms.Button bSifreUnuttum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

