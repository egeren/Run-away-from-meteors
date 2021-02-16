using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egeEren
{
    public partial class oyun : Form
    {
        oyuncu Oyuncu;
        KeyPressEventArgs tus;
        int hiz = 1;
        int skor = 0;
        int saniye = 0;
        Random sayi = new Random();
        public oyun(oyuncu Oyuncu)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Oyuncu = Oyuncu;
        }
        private void oyun_Load(object sender, EventArgs e)
        {
            kullaniciLbl.Text = Oyuncu.getKullaniciAdi();
            karakter.Tag = "bekleme";
            karakter.Location = new Point(479, 407);
            karakter.Size = new Size(103, 85);
            meteor1.Location = new Point(sayi.Next(-3, 90), sayi.Next(-1000, -220));
            meteor2.Location = new Point(sayi.Next(220, 299), sayi.Next(-1000, -220));
            meteor3.Location = new Point(sayi.Next(427, 507), sayi.Next(-1000, -220));
            meteor4.Location = new Point(sayi.Next(636, 723), sayi.Next(-1000, -220));
            meteor5.Location = new Point(sayi.Next(850, 927), sayi.Next(-1000, -220));
            Cursor.Hide();
        }

        private void oyun_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void oyun_KeyPress(object sender, KeyPressEventArgs e)
        {
            tus = e;
        }
        private void oyun_KeyUp(object sender, KeyEventArgs e)
        {
            tus = null;
            if (karakter.Tag.ToString() == "sol")
            {
                karakter.Image = Properties.Resources.beklesol;
            }
            if (karakter.Tag.ToString() == "sağ")
            {
                karakter.Image = Properties.Resources.beklesag;
            }
            karakter.Tag = "bekle";
        }

            private void hareket_Tick(object sender, EventArgs e)
        {
            if (tus != null)
            {
                if (tus.KeyChar.ToString() == "a" || tus.KeyChar.ToString() == "A")
                {
                    if (karakter.Location.X > -20)
                        karakter.Location = new Point(karakter.Location.X - 5, 407);
                    if (karakter.Tag.ToString() != "sol")
                    {
                        karakter.Tag = "sol";
                        karakter.Image = Properties.Resources.solkos;
                    }
                }
                if (tus.KeyChar.ToString() == "d" || tus.KeyChar.ToString() == "D")
                {
                    if (karakter.Location.X < 976)
                        karakter.Location = new Point(karakter.Location.X + 5, 407);
                    if (karakter.Tag.ToString() != "sağ")
                    {
                        karakter.Tag = "sağ";
                        karakter.Image = Properties.Resources.sagkos;
                    }
                }
            }
            Cursor.Position = this.PointToScreen(new Point(karakter.Location.X + 45, karakter.Location.Y));
            if (meteor1.Location.Y > 300)
            {
                meteor1.Location = new Point(sayi.Next(-3, 90), sayi.Next(-1000, -220));
            }
            if (meteor2.Location.Y > 300)
            {
                meteor2.Location = new Point(sayi.Next(220, 299), sayi.Next(-1000, -220));
            }
            if (meteor3.Location.Y > 300)
            {
                meteor3.Location = new Point(sayi.Next(427, 507), sayi.Next(-1000, -220));
            }
            if (meteor4.Location.Y > 300)
            {
                meteor4.Location = new Point(sayi.Next(636, 723), sayi.Next(-1000, -220));
            }
            if (meteor5.Location.Y > 300)
            {
                meteor5.Location = new Point(sayi.Next(850, 927), sayi.Next(-1000, -220));
            }

            meteor1.Location = new Point(meteor1.Location.X, meteor1.Location.Y + hiz);
            meteor2.Location = new Point(meteor2.Location.X, meteor2.Location.Y + hiz);
            meteor3.Location = new Point(meteor3.Location.X, meteor3.Location.Y + hiz);
            meteor4.Location = new Point(meteor4.Location.X, meteor4.Location.Y + hiz);
            meteor5.Location = new Point(meteor5.Location.X, meteor5.Location.Y + hiz);
        }

        private void meteor_MouseEnter(object sender, EventArgs e)
        {
            hareket.Stop();
            Cursor.Show();
            puan.Stop();
            meteor1.Dispose();
            meteor2.Dispose();
            meteor3.Dispose();
            meteor4.Dispose();
            meteor5.Dispose();
            this.BackgroundImage = Properties.Resources.skorarka;
            karakter.Size = new Size(359, 311);
            karakter.Location = new Point(42, 152);
            skorbitis.Text = skor.ToString();
            skorbitis.Visible = true;
            skorYazi.AutoSize = true;
            skorYazi.Text = "Skorunuz";
            skorYazi.Location = new Point(420, 145);
            skorYazi.Font = new Font(skorYazi.Font.FontFamily, 72f, FontStyle.Underline);
            menuyeDon.Visible = true;
            bildirim.Visible = false;
            karakter.Image = Properties.Resources.beklesag;
            if(skor > Oyuncu.getSkor())
            {
                bildirim.Text = "Yeni Yüksek Skor!";
                bildirim.Visible = true;
                Oyuncu.setSkor(skor);
            }
        }

        private void meteorZaman_Tick(object sender, EventArgs e)
        {
            skor += 10;
            saniye++;
            skorYazi.Text = "Skor: " + skor;
            if (saniye >= 30)
            {
                bildirim.Visible = true;
                saniye = 0;
                hiz++;
            }
            if (saniye == 4)
            {
                bildirim.Visible = false;
            }
        }

        private void menuyeDon_Click(object sender, EventArgs e)
        {
            anaMenu.menu.Show();
            this.Dispose();
        }
    }
}
