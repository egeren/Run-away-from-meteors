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
    public partial class liderlik : Form
    {
        oyuncu Oyuncu;
        public liderlik(oyuncu Oyuncu)
        {
            InitializeComponent();
            this.Oyuncu = Oyuncu;
        }

        private void liderlik_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void liderlik_Load(object sender, EventArgs e)
        {
            bool inTop10 = false;
            db.con.Open();
            db.cmd = new SqlCommand("select TOP(10) ROW_NUMBER() OVER(ORDER BY SKOR desc) AS sira, * from kullanicilar", db.con);
            db.reader = db.cmd.ExecuteReader();
            for (int i = 1; db.reader.Read(); i++)
            {
                siralamaLbl.Text += i + ". " + db.reader["kullaniciAdi"] + " - " + db.reader["skor"] + " Puan\n ";
                if (Oyuncu != null)
                {
                    if ((int)db.reader["id"] == Oyuncu.getId())
                    {
                        inTop10 = true;
                    }
                }
            }
            if(Oyuncu != null && !inTop10)
            {
                db.reader.Close();
                db.cmd = new SqlCommand("select ROW_NUMBER() OVER(ORDER BY SKOR desc) AS siralama, * from kullanicilar", db.con);
                db.reader = db.cmd.ExecuteReader();
                while(db.reader.Read())
                {
                    if((int) db.reader["id"] == Oyuncu.getId())
                    {
                        siralamaLbl.Text += "--------------------------------------------------- \n" + db.reader["siralama"] + ". " + Oyuncu.getKullaniciAdi() + " - " + Oyuncu.getSkor() + " Puan";
                        break;
                    }
                }
            }
            db.con.Close();
        }
    }
}
