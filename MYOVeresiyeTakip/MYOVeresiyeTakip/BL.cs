using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYOVeresiyeTakip
{
    public static class BL
    {
        public static List<Kisi> Kisiler = new List<Kisi>();

        public static void KişileriListele()
        {
            Kisiler = DL.KişileriListele();
            foreach(var k in Kisiler)
            {
                k.Girdiler = DL.GirdileriListele(k.kid.ToString());
            }
        }

        public static void KisiEkle(string kid, string plaka, string tc, string ad, string soyad, string telefon, string mail, string adres, DateTime kiratarih, DateTime teslimtarih, string tutar, string odemeturu)
        {
            Kisi k = new Kisi()
            {
                kid = Guid.NewGuid(),
                Ad = ad,
                Plaka = Guid.NewGuid(),
                Soyad = soyad,
                Telefon = telefon,
                Mail = mail,
                Adres = adres,
                KiraTarih = kiratarih,
                TeslimTarih = teslimtarih,
                Tutar = tutar,
                OdemeTuru = odemeturu

            };
            //kid,plaka,tc,ad,soyad,telefon,mail,adres,kiratarih,teslimtarih,tutar,odemeturu
            int res = DL.KisiEkle(k.kid.ToString(),ad,soyad,teslimtarih,telefon,tc,adres,tutar,odemeturu,plaka,kid);
            if (res != -1)
                Kisiler.Add(k);
        }

        public static void KişiSil(string kid)
        {
            int res = DL.KisiSil(kid);
            if (res != -1)
            {
                Kisi k = Kisiler.Find(o => o.kid.ToString() == kid);
                Kisiler.Remove(k);
            }

        }


        public static void KişiDüzenle(string kid, string plaka, string tc, string ad, string soyad, string telefon, string mail, string adres, DateTime kiratarih, DateTime teslimtarih, string tutar, string odemeturu)
        {
            Kisi k = Kisiler.Find(o => o.kid.ToString() == kid);
            int res = DL.KisiDüzenle(ad, soyad, teslimtarih, telefon, tc, adres, tutar, odemeturu, plaka, kid);
            if (res != -1)
            {
                k.kid = Guid.NewGuid();
                k.Ad = ad;
                k.Plaka. = Guid.NewGuid();
                k.Soyad = soyad;
                k.Telefon = telefon;
                k.Mail = mail;
                k.Adres = adres;
                k.KiraTarih = kiratarih;
                k.TeslimTarih = teslimtarih;
                k.Tutar = tutar;
                k.OdemeTuru = odemeturu;
            }

        }

        public static void GirdiEkle(string kid, string plaka, float gunlukfiyat, string marka, string model, string yakit, string renk, string kasatipi, string durum)
        {
            Kisi k = Kisiler.Find(o => o.kid.ToString() == kid);
            Girdi g = new Girdi()
            {
                plaka = Guid.NewGuid(),
                g.GunlukFiyat = gunlukfiyat,
                g.Marka = marka,
                g.Model = model,
                g.Yakit = yakit,
                g.Renk = renk,
                g.KasaTipi = kasatipi,
                g.KasaTipi = kasatipi,
                g.Durum = durum,
        };

            int res = DL.GirdiEkle(plaka, gunlukfiyat, marka, model, yakit , renk , kasatipi , durum);
            if (res != -1)
                k.Girdiler.Add(g);
        }

        internal static float KişiToplamBorcu(string kid)
        {
            Kisi k = Kisiler.Find(o => o.kid.ToString() == kid);
            return k.Girdiler.Sum(o => o.gun);
        }

        public static void GirdiDüzenle(string kid,string plaka, float gunlukfiyat, string marka, string model, string yakit, string renk, string kasatipi, string durum)
        {
            Kisi k = Kisiler.Find(o => o.kid.ToString() == kid);
           

            int res = DL.GirdiDüzenle(plaka, gunlukfiyat, marka, model, yakit , renk , kasatipi , durum);
            if (res != -1)
            {
                Girdi g = k.Girdiler.Find(o => o.plaka.ToString() == plaka);
                g.GunlukFiyat = gunlukfiyat;
                g.Marka = marka;
                g.Model = model;
                g.Yakit = yakit;
                g.Renk = renk;
                g.KasaTipi = kasatipi;
                g.KasaTipi = kasatipi;
                g.Durum = durum;

            }
        }

        public static void GirdiSil(string kid, string plaka)
        {
            Kisi k = Kisiler.Find(o => o.kid.ToString() == kid);


            int res = DL.GirdiSil(plaka);
            if (res != -1)
            {
                Girdi g = k.Girdiler.Find(o => o.plaka.ToString() == plaka);
                k.Girdiler.Remove(g);
            }
        }

        internal static List<Kisi> KişileriFiltrele(string filtre)
        {
            if (string.IsNullOrEmpty(filtre))
                return Kisiler;

            filtre = filtre.ToUpper();

            List<Kisi> _kisiler = new List<Kisi>();
            foreach(var k in Kisiler)
            {
                if (k.Ad.ToUpper().StartsWith(filtre) 
                    || k.Soyad.ToUpper().StartsWith(filtre) 
                    || k.Telefon.ToUpper().StartsWith(filtre) 
                    || k.Mail.ToUpper().StartsWith(filtre))
                    _kisiler.Add(k);
            }

            return _kisiler;
        }
    }
}
