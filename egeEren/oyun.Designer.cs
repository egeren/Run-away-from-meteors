namespace egeEren
{
    partial class oyun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyun));
            this.karakter = new System.Windows.Forms.PictureBox();
            this.hareket = new System.Windows.Forms.Timer(this.components);
            this.meteor2 = new System.Windows.Forms.PictureBox();
            this.meteor1 = new System.Windows.Forms.PictureBox();
            this.meteor4 = new System.Windows.Forms.PictureBox();
            this.meteor3 = new System.Windows.Forms.PictureBox();
            this.meteor5 = new System.Windows.Forms.PictureBox();
            this.puan = new System.Windows.Forms.Timer(this.components);
            this.skorYazi = new System.Windows.Forms.Label();
            this.skorbitis = new System.Windows.Forms.Label();
            this.menuyeDon = new System.Windows.Forms.Label();
            this.bildirim = new System.Windows.Forms.Label();
            this.kullaniciLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor5)).BeginInit();
            this.SuspendLayout();
            // 
            // karakter
            // 
            this.karakter.BackColor = System.Drawing.Color.Transparent;
            this.karakter.Image = ((System.Drawing.Image)(resources.GetObject("karakter.Image")));
            this.karakter.Location = new System.Drawing.Point(42, 152);
            this.karakter.Name = "karakter";
            this.karakter.Size = new System.Drawing.Size(359, 311);
            this.karakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.karakter.TabIndex = 0;
            this.karakter.TabStop = false;
            // 
            // hareket
            // 
            this.hareket.Enabled = true;
            this.hareket.Interval = 1;
            this.hareket.Tick += new System.EventHandler(this.hareket_Tick);
            // 
            // meteor2
            // 
            this.meteor2.BackColor = System.Drawing.Color.Transparent;
            this.meteor2.Image = ((System.Drawing.Image)(resources.GetObject("meteor2.Image")));
            this.meteor2.Location = new System.Drawing.Point(299, -72);
            this.meteor2.Name = "meteor2";
            this.meteor2.Size = new System.Drawing.Size(124, 218);
            this.meteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor2.TabIndex = 1;
            this.meteor2.TabStop = false;
            this.meteor2.MouseEnter += new System.EventHandler(this.meteor_MouseEnter);
            // 
            // meteor1
            // 
            this.meteor1.BackColor = System.Drawing.Color.Transparent;
            this.meteor1.Image = ((System.Drawing.Image)(resources.GetObject("meteor1.Image")));
            this.meteor1.Location = new System.Drawing.Point(90, -72);
            this.meteor1.Name = "meteor1";
            this.meteor1.Size = new System.Drawing.Size(124, 218);
            this.meteor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor1.TabIndex = 2;
            this.meteor1.TabStop = false;
            this.meteor1.MouseEnter += new System.EventHandler(this.meteor_MouseEnter);
            // 
            // meteor4
            // 
            this.meteor4.BackColor = System.Drawing.Color.Transparent;
            this.meteor4.Image = ((System.Drawing.Image)(resources.GetObject("meteor4.Image")));
            this.meteor4.Location = new System.Drawing.Point(723, -72);
            this.meteor4.Name = "meteor4";
            this.meteor4.Size = new System.Drawing.Size(124, 218);
            this.meteor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor4.TabIndex = 3;
            this.meteor4.TabStop = false;
            this.meteor4.MouseEnter += new System.EventHandler(this.meteor_MouseEnter);
            // 
            // meteor3
            // 
            this.meteor3.BackColor = System.Drawing.Color.Transparent;
            this.meteor3.Image = ((System.Drawing.Image)(resources.GetObject("meteor3.Image")));
            this.meteor3.Location = new System.Drawing.Point(506, -72);
            this.meteor3.Name = "meteor3";
            this.meteor3.Size = new System.Drawing.Size(124, 218);
            this.meteor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor3.TabIndex = 5;
            this.meteor3.TabStop = false;
            this.meteor3.MouseEnter += new System.EventHandler(this.meteor_MouseEnter);
            // 
            // meteor5
            // 
            this.meteor5.BackColor = System.Drawing.Color.Transparent;
            this.meteor5.Image = ((System.Drawing.Image)(resources.GetObject("meteor5.Image")));
            this.meteor5.Location = new System.Drawing.Point(850, -72);
            this.meteor5.Name = "meteor5";
            this.meteor5.Size = new System.Drawing.Size(124, 218);
            this.meteor5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteor5.TabIndex = 6;
            this.meteor5.TabStop = false;
            this.meteor5.MouseEnter += new System.EventHandler(this.meteor_MouseEnter);
            // 
            // puan
            // 
            this.puan.Enabled = true;
            this.puan.Interval = 500;
            this.puan.Tick += new System.EventHandler(this.meteorZaman_Tick);
            // 
            // skorYazi
            // 
            this.skorYazi.BackColor = System.Drawing.Color.Transparent;
            this.skorYazi.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorYazi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skorYazi.Location = new System.Drawing.Point(654, 519);
            this.skorYazi.Name = "skorYazi";
            this.skorYazi.Size = new System.Drawing.Size(397, 29);
            this.skorYazi.TabIndex = 7;
            this.skorYazi.Text = "Skor: 0";
            this.skorYazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skorbitis
            // 
            this.skorbitis.AutoSize = true;
            this.skorbitis.BackColor = System.Drawing.Color.Transparent;
            this.skorbitis.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorbitis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skorbitis.Location = new System.Drawing.Point(437, 302);
            this.skorbitis.Name = "skorbitis";
            this.skorbitis.Size = new System.Drawing.Size(0, 77);
            this.skorbitis.TabIndex = 8;
            this.skorbitis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skorbitis.Visible = false;
            // 
            // menuyeDon
            // 
            this.menuyeDon.AutoSize = true;
            this.menuyeDon.BackColor = System.Drawing.Color.Transparent;
            this.menuyeDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuyeDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuyeDon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuyeDon.Location = new System.Drawing.Point(811, 500);
            this.menuyeDon.Name = "menuyeDon";
            this.menuyeDon.Size = new System.Drawing.Size(231, 42);
            this.menuyeDon.TabIndex = 9;
            this.menuyeDon.Text = "Menüye Dön";
            this.menuyeDon.Visible = false;
            this.menuyeDon.Click += new System.EventHandler(this.menuyeDon_Click);
            // 
            // bildirim
            // 
            this.bildirim.AutoSize = true;
            this.bildirim.BackColor = System.Drawing.Color.Transparent;
            this.bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bildirim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bildirim.Location = new System.Drawing.Point(472, 524);
            this.bildirim.Name = "bildirim";
            this.bildirim.Size = new System.Drawing.Size(176, 24);
            this.bildirim.TabIndex = 10;
            this.bildirim.Text = "Meteorlar Hızlandı !!";
            this.bildirim.Visible = false;
            // 
            // kullaniciLbl
            // 
            this.kullaniciLbl.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciLbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kullaniciLbl.Location = new System.Drawing.Point(12, 519);
            this.kullaniciLbl.Name = "kullaniciLbl";
            this.kullaniciLbl.Size = new System.Drawing.Size(397, 29);
            this.kullaniciLbl.TabIndex = 11;
            this.kullaniciLbl.Text = "Kullanıcı Adı";
            this.kullaniciLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::egeEren.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 566);
            this.Controls.Add(this.kullaniciLbl);
            this.Controls.Add(this.skorYazi);
            this.Controls.Add(this.bildirim);
            this.Controls.Add(this.menuyeDon);
            this.Controls.Add(this.skorbitis);
            this.Controls.Add(this.meteor5);
            this.Controls.Add(this.meteor3);
            this.Controls.Add(this.meteor4);
            this.Controls.Add(this.meteor1);
            this.Controls.Add(this.meteor2);
            this.Controls.Add(this.karakter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oyun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meteorlardan Kaç - egecode";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.oyun_FormClosing);
            this.Load += new System.EventHandler(this.oyun_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oyun_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.oyun_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox karakter;
        private System.Windows.Forms.Timer hareket;
        private System.Windows.Forms.PictureBox meteor2;
        private System.Windows.Forms.PictureBox meteor1;
        private System.Windows.Forms.PictureBox meteor4;
        private System.Windows.Forms.PictureBox meteor3;
        private System.Windows.Forms.PictureBox meteor5;
        private System.Windows.Forms.Timer puan;
        private System.Windows.Forms.Label skorYazi;
        private System.Windows.Forms.Label skorbitis;
        private System.Windows.Forms.Label menuyeDon;
        private System.Windows.Forms.Label bildirim;
        private System.Windows.Forms.Label kullaniciLbl;
    }
}