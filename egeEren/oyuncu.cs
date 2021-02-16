using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace egeEren
{
    public class oyuncu
    {
        private int id;
        private string kullaniciAdi;
        private int skor;

        public oyuncu(int id, string kullaniciAdi, int skor)
        {
            this.id = id;
            this.kullaniciAdi = kullaniciAdi;
            this.skor = skor;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }

        public void setSkor(int skor)
        {
            db.con.Open();
            db.cmd = new SqlCommand("update kullanicilar set skor=" + skor + " where id="+ getId(), db.con);
            db.cmd.ExecuteNonQuery();
            db.con.Close();
            this.skor = skor;
        }

        public int getId()
        {
            return this.id;
        }

        public string getKullaniciAdi()
        {
            return this.kullaniciAdi;
        }

        public int getSkor()
        {
            return this.skor;
        }
    }
}
