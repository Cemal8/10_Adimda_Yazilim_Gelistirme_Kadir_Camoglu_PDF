using System;
using System.IO;
namespace SISApi
{
    public static class Yardimci
    {
        public static void HataKaydet(Exception ex)
        {
            try
            {
                string klasorYolu = @"C:\SISLog";

                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }

                string dosyaAdi = Path.Combine(klasorYolu, $"SISApi_Hata_{Guid.NewGuid()}.txt");

                File.WriteAllText(dosyaAdi, ex.ToString());
            }
            catch
            {
                // Log yazarken bile hata olursa (Örn: C diskinde yer kalmamıştır veya yazma yetkisi yoktur)
                // Sistemi tamamen çökertmemek için burayı boş bir catch bloğu ile yutuyoruz (Fail-safe mekanizması).
            }
        }
    }
}