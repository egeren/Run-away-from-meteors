using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace egeEren
{
    public partial class giris : Form
    {
        anaMenu menu;
        public giris(anaMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void cikisLbl_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void kullaniciTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kullaniciTxt.Text))
            {
                errorProvider.SetError(kullaniciTxt, "Lütfen alanı doldurunuz.");
            }
            else
            {
                errorProvider.SetError(kullaniciTxt, null);
            }
        }

        private void sifreTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sifreTxt.Text))
            {
                errorProvider.SetError(sifreTxt, "Lütfen alanı doldurunuz.");
            }
            else
            {
                errorProvider.SetError(sifreTxt, null);
            }
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (errorProvider.GetError(kullaniciTxt) == "" && errorProvider.GetError(sifreTxt) == "")
            {
                string kullanici = kullaniciTxt.Text;
                string sifre = sifreTxt.Text;
                db.con.Open();
                db.cmd = new SqlCommand("select * from kullanicilar where kullaniciAdi='" + kullanici + "' and sifre='"+sifre+"'", db.con);
                db.reader = db.cmd.ExecuteReader();
                if (db.reader.HasRows)
                {
                    db.reader.Read();
                    int id = (int) db.reader["id"];
                    string kullaniciAdi = (string) db.reader["kullaniciAdi"];
                    int skor = (int) db.reader["skor"];
                    anaMenu.Oyuncu = new oyuncu(id, kullaniciAdi, skor);
                    MessageBox.Show("Başarıyla giriş yapıldı.", "Girş Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu.girisYapildi();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
