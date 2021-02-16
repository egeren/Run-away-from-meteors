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
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            if(errorProvider.GetError(kullaniciTxt) == "" && errorProvider.GetError(sifreTxt) == "")
            { 
                string kullanici = kullaniciTxt.Text;
                string sifre = sifreTxt.Text;
                db.con.Open();
                db.cmd = new SqlCommand("select * from kullanicilar where kullaniciAdi='"+kullanici+"'", db.con);
                db.reader = db.cmd.ExecuteReader();
                if(!db.reader.HasRows)
                {
                    db.reader.Close();
                    db.cmd = new SqlCommand("insert into kullanicilar(kullaniciAdi,sifre) values('"+kullanici+"','"+sifre+"')", db.con);
                    db.cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla kayıt olundu.","Kayıt olma başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı kullanılıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.con.Close(); 
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
