using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAR = SISVarliklar;
using VEK = SISVeriErisimKatmani;

namespace SISIsKatmani
{
    public class Hasta
    {
        public static int Kaydet(VAR.Hasta hasta)
        {
            bool sonuc = false;

            if (hasta.No > 0)
            {
                sonuc = VEK.Hasta.Guncelle(hasta);
            }
            else
            {
                sonuc = VEK.Hasta.Kaydet(hasta);
            }

            if (sonuc)
            {
                return hasta.No;
            }
            else
            {
                return 0;
            }
        }

        public static SISVarliklar.Hasta[] HastalariListele(string ad, string soyad)
        {
            VAR.Hasta[] hastalar = null;
            hastalar = VEK.Hasta.HastalariListele(ad, soyad);
            return hastalar;
        }

        public static VAR.Hasta HastaGetir(int hastaNo)
        {
            VAR.Hasta hasta = null;
            hasta = VEK.Hasta.HastaGetir(hastaNo);

            return hasta;
        }
    }
}
