using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SISVeriErisimKatmani
{
    public class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            string dosyaAdi = Environment.CurrentDirectory + "\\SISVeriErisimKatmani_Hata_" + Guid.NewGuid().ToString() + ".txt";
        }
    }
}
