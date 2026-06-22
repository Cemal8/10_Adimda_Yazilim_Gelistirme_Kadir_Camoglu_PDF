using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAR = SISVarliklar;
using VEK = SISVeriErisimKatmani;
namespace SISVeriErisimKatmani
{
    public class Hasta
    {
        public static bool Kaydet(VAR.Hasta hasta)
        {
            string spAdi = "prHastaYeniKaydet";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@tCKimlikNo", hasta.TcKimlikNo);
            k.ParametreEkle("@ad", hasta.Ad);
            k.ParametreEkle("@soyad", hasta.Soyad);
            k.ParametreEkle("@dogumTarihi", hasta.DogumTarihi);
            k.ParametreEkle("@cinsiyeti", hasta.Cinsiyet);
            k.ParametreEkle("@ePosta", hasta.Eposta);
            k.ParametreEkle("@cepTel", hasta.CepTel);
            k.ParametreEkle("@evTel", hasta.EvTel);
            k.ParametreEkle("@adres", hasta.Adres);
            k.ParametreEkleOut("@hastaNo", SqlDbType.Int, 0);

            etkilenen = k.Islet();
            if (etkilenen > 0)
            {
                hasta.No = k.OutParametreDegeriGetir("@hastaNo");
            }

            k.Temizle();
            return etkilenen > 0;
        }
        public static bool Guncelle(SISVarliklar.Hasta hasta)
        {
            string spAdi = "prHastaGuncelle";
            int etkilenen = 0;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@tCKimlikNo", hasta.TcKimlikNo);
            k.ParametreEkle("@ad", hasta.Ad);
            k.ParametreEkle("@soyad", hasta.Soyad);
            k.ParametreEkle("@dogumTarihi", hasta.DogumTarihi);
            k.ParametreEkle("@cinsiyeti", hasta.Cinsiyet);
            k.ParametreEkle("@ePosta", hasta.Eposta);
            k.ParametreEkle("@cepTel", hasta.CepTel);
            k.ParametreEkle("@evTel", hasta.EvTel);
            k.ParametreEkle("@adres", hasta.Adres);
            k.ParametreEkle("@hastaNo", hasta.No);

            etkilenen = k.Islet();
            k.Temizle();
            return etkilenen > 0;
        }

        public static SISVarliklar.Hasta[] HastalariListele(string ad, string soyad)
        {
            string spAdi = "prHastalariListele";
            List<VAR.Hasta> hastalar = new List<SISVarliklar.Hasta>();

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@ad", ad);
            k.ParametreEkle("@soyad", soyad);

            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                VAR.Hasta hasta = HastaBilgileriYukle(sdr);
                hastalar.Add(hasta);
            }
            sdr.Close();
            k.Temizle();

            return hastalar.ToArray();
        }

        public static VAR.Hasta HastaGetir(int hastaNo)
        {
            string spAdi = "prHastaGetir";
            VAR.Hasta hasta = null;

            Komut k = new Komut(spAdi);
            k.ParametreEkle("@hastaNo", hastaNo);
            SqlDataReader sdr = k.IsletReader();
            while (sdr.Read())
            {
                hasta = HastaBilgileriYukle(sdr);
            }
            sdr.Close();
            k.Temizle();

            return hasta;
        }

        private static VAR.Hasta HastaBilgileriYukle(SqlDataReader sdr)
        {
            VAR.Hasta hasta = new SISVarliklar.Hasta();

            hasta.No = Komut.Int32Getir(sdr, "HastaNo");
            hasta.TcKimlikNo = Komut.StringGetir(sdr, "TCKimlikNo");
            hasta.Ad = Komut.StringGetir(sdr, "Ad");
            hasta.Soyad = Komut.StringGetir(sdr, "Soyad");
            hasta.DogumTarihi = Komut.TarihGetir(sdr, "DogumTarihi");
            hasta.Cinsiyet = Komut.StringGetir(sdr, "Cinsiyeti");
            hasta.Eposta = Komut.StringGetir(sdr, "EPosta");
            hasta.CepTel = Komut.StringGetir(sdr, "CepTel");
            hasta.EvTel = Komut.StringGetir(sdr, "EvTel");
            hasta.Adres = Komut.StringGetir(sdr, "Adres");

            return hasta;
        }
    }
}
