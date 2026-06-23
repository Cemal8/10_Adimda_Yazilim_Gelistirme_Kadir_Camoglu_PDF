using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SISWin
{
    public static class Yardimci
    {
        // Aktif giriş yapan kullanıcının ID bilgisini tutar
        public static int KullaniciNo { get; set; }

        /// <summary>
        /// Uygulama içinde oluşan hataları merkezi bir metotla log dosyasına kaydeder.
        /// </summary>
        public static void HataKaydet(Exception ex)
        {
            try
            {
                // Hatanın kaydedileceği dosya yolu (Uygulamanın çalıştığı dizinde Hatalar.txt)
                string dosyaYolu = Path.Combine(Application.StartupPath, "Hatalar.txt");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--------------------------------------------------");
                sb.AppendLine($"Tarih/Saat: {DateTime.Now}");
                sb.AppendLine($"Hata Mesajı: {ex.Message}");
                if (ex.InnerException != null)
                {
                    sb.AppendLine($"İç Hata: {ex.InnerException.Message}");
                }
                sb.AppendLine($"Hata Kaynağı: {ex.StackTrace}");
                sb.AppendLine("--------------------------------------------------");

                // Dosya yoksa oluşturur, varsa sonuna ekleme yapar
                File.AppendAllText(dosyaYolu, sb.ToString());
            }
            catch
            {
                // Loglama esnasında hata oluşursa uygulamanın çökmemesi için boş bırakılmıştır
            }
        }
    }
}