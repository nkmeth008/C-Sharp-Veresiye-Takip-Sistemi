using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYOVeresiyeTakip
{
    public static class DL
    {
        static MySqlConnection baglanti = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "78.135.82.146",
                Database = "18010208025_db",
                UserID = "18010208025",
                Password = "18010208025"

            }.ConnectionString

            );

        ///*
        //create table kisiler
        //(
        // kid varchar(32) primary key,
        //    adi varchar(32) not null,
        //    soyadi varchar(32) not null,
        //    telefon varchar(32) not null,
        //    mail varchar(255) not null
        //);

        //create table borclar
        //(
        //    gid varchar(32) primary key,
        //    kid varchar(32) references kisiler(kid) on delete cascade on update cascade,
        //    miktar  float	not null default 0,
        //    tarih   datetime	not null,
        //    aciklama varchar(255)   not null 
        //);
        //*/

        public static List<Kisi> KişileriListele()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "select * from kiralama ";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();
                List<Kisi> kisiler = new List<Kisi>();
                while (dr.Read())
                {
                    kisiler.Add(
                        new Kisi()
                        {
                            kid = Guid.Parse(dr[0].ToString()),
                            Ad = dr[1].ToString(),
                            Soyad = dr[2].ToString(),
                            Telefon = dr[3].ToString(),
                            Mail = dr[4].ToString(),
                            Adres = dr[5].ToString(),
                            Tutar = dr[6].ToString(),
                            OdemeTuru = dr[7].ToString()

                        });
                }

                return kisiler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static List<Girdi> GirdileriListele(string plaka)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "select * from araclar where plaka=@plaka ";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                komut.Parameters.AddWithValue("@plaka", plaka);

                MySqlDataReader dr = komut.ExecuteReader();
                List<Girdi> girdiler = new List<Girdi>();
                while (dr.Read())
                {
                    girdiler.Add(
                        new Girdi()
                        {
                            plaka = Guid.Parse(dr[0].ToString()),
                            kid = Guid.Parse(dr[1].ToString()),
                            GunlukFiyat = (float)dr[2],
                            Marka = dr[5].ToString(),
                            Durum = dr[4].ToString(),
                            Model = dr[6].ToString(),
                            Yakit = dr[7].ToString(),
                            Renk = dr[8].ToString(),
                            KasaTipi = dr[9].ToString(),

                        });
                }

                return girdiler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static int KisiEkle(string kid, string plaka, string tc, string ad, string soyad, string telefon , string mail , string adres, DateTime kiratarih , DateTime teslimtarih , string tutar, string odemeturu)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "insert into kiralama values(@kid, @plaka, @tc, @ad, @soyad, @telefon, @mail, @adres, @kiratarih, @teslimtarih, @tutar, @odemeturu)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);
                komut.Parameters.AddWithValue("@kid",kid);
                komut.Parameters.AddWithValue("@plaka",plaka);
                komut.Parameters.AddWithValue("@tc",tc);
                komut.Parameters.AddWithValue("@ad",ad);
                komut.Parameters.AddWithValue("@soyad",soyad);
                komut.Parameters.AddWithValue("@telefon",telefon);
                komut.Parameters.AddWithValue("@mail",mail);
                komut.Parameters.AddWithValue("@adres",adres);
                komut.Parameters.AddWithValue("@kiratarih",kiratarih);
                komut.Parameters.AddWithValue("@teslimtarih",teslimtarih);
                komut.Parameters.AddWithValue("@tutar",tutar);
                komut.Parameters.AddWithValue("@odemeturu",odemeturu);
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }


        public static int KisiSil(string kid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string delete = "delete from kiralama where kid=@kid";
                MySqlCommand komut = new MySqlCommand(delete, baglanti);
                komut.Parameters.AddWithValue("@kid", kid);

                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static int KisiDüzenle(string kid, string plaka, string tc, string ad, string soyad, string telefon, string mail, string adres, DateTime kiratarih, DateTime teslimtarih, string tutar, string odemeturu)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = 
                    "update kisiler " +
                    " set plaka=@plaka, tc=@tc, ad=@ad, soyad=@soyad, telefon=@telefon, mail=@mail, adres=@adres, kiratarih=@kiratarih, teslimtarih=@teslimtarih, tutar=@tutar, odemeturu=@odemeturu " +
                    " where kid=@kid";
                MySqlCommand komut = new MySqlCommand(update, baglanti);
                komut.Parameters.AddWithValue("@plaka", plaka);
                komut.Parameters.AddWithValue("@tc", tc);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@kiratarih", kiratarih);
                komut.Parameters.AddWithValue("@teslimtarih", teslimtarih);
                komut.Parameters.AddWithValue("@tutar", tutar);
                komut.Parameters.AddWithValue("@odemeturu", odemeturu);
                komut.Parameters.AddWithValue("@kid", kid);

                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static int GirdiEkle(string plaka, float gunlukfiyat, string marka, string model, string yakit, string renk, string kasatipi, string durum)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "insert into araclar values(@plaka, @marka, @model, @yakit, @renk, @kasatipi, @gunlukfiyat, @durum)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);
                komut.Parameters.AddWithValue("@gid", plaka);
                komut.Parameters.AddWithValue("@marka", marka);
                komut.Parameters.AddWithValue("@model", model);
                komut.Parameters.AddWithValue("@yakit", yakit);
                komut.Parameters.AddWithValue("@renk", renk);
                komut.Parameters.AddWithValue("@kasatipi", kasatipi);
                komut.Parameters.AddWithValue("@gunlukfiyat", gunlukfiyat);
                komut.Parameters.AddWithValue("@durum", durum);

                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static int GirdiDüzenle(string plaka, float gunlukfiyat, string marka, string model, string yakit, string renk, string kasatipi, string durum)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "update araclar " +
                    " set marka=@marka, model=@model, yakit=@yakit, renk =@renk, kasatipi=@kasatipi, gunlukfiyat=@gunlukfiyat, durum=@durum " +
                    " where plaka=@plaka";
                MySqlCommand komut = new MySqlCommand(update, baglanti);
                komut.Parameters.AddWithValue("@marka", marka);
                komut.Parameters.AddWithValue("@model", model);
                komut.Parameters.AddWithValue("@yakit", yakit);
                komut.Parameters.AddWithValue("@renk", renk);
                komut.Parameters.AddWithValue("@kasatipi", kasatipi);
                komut.Parameters.AddWithValue("@gunlukfiyat", gunlukfiyat);
                komut.Parameters.AddWithValue("@durum", durum);
                komut.Parameters.AddWithValue("@plaka", plaka);
                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        public static int GirdiSil(string plaka)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string delete = "delete from araclar where plaka=@plaka";

                MySqlCommand komut = new MySqlCommand(delete, baglanti);
                komut.Parameters.AddWithValue("@plaka", plaka);

                return komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }


    }
}
