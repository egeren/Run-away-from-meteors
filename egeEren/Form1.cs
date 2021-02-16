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
    public partial class anaMenu : Form
    {
        public static anaMenu menu;
        public static oyuncu Oyuncu;
        public anaMenu()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menu = this;
        }

        public void girisYapildi()
        {
            girisLbl.Hide();
            kayitLbl.Hide();
            kullaniciLbl.Text = Oyuncu.getKullaniciAdi();
            kullaniciLbl.Show();
        }
        private void basla_MouseEnter(object sender, EventArgs e)
        {
            baslaresim.Visible = true;
        }

        private void basla_MouseLeave(object sender, EventArgs e)
        {
            baslaresim.Visible = false;
        }

        private void cikis_MouseEnter(object sender, EventArgs e)
        {
            cikisresim.Visible = true;
        }

        private void cikis_MouseLeave(object sender, EventArgs e)
        {
            cikisresim.Visible = false;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void basla_Click(object sender, EventArgs e)
        {
            if (Oyuncu != null)
            {
                oyun oyna = new oyun(Oyuncu);
                oyna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oyuna başlamak için önce giriş yapmalısınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siralama_MouseEnter(object sender, EventArgs e)
        {
            siralamaresim.Visible = true;
        }

        private void siralama_MouseLeave(object sender, EventArgs e)
        {
            siralamaresim.Visible = false;
        }

        private void siralama_Click(object sender, EventArgs e)
        {
            liderlik liderlikPanel = new liderlik(Oyuncu);
            liderlikPanel.Owner = this;
            liderlikPanel.Show();
            this.Hide();
        }

        private void girisLbl_Click(object sender, EventArgs e)
        {
            giris girisPanel = new giris(this);
            girisPanel.ShowDialog(); 
        }

        private void kayitLbl_Click(object sender, EventArgs e)
        {
            kayitOl kayitPanel = new kayitOl();
            kayitPanel.Show();
        }
    }
}
