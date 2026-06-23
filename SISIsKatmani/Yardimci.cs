using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SISIsKatmani
{
    public class Yardimci
    {
        public static int KullaniciNo { get; set; }

        public static void HataKaydet(Exception ex)
        {
            string dosyaAdi = Path.Combine(Environment.CurrentDirectory, "SISIsKatmani_Hata_" + Guid.NewGuid() + ".txt");

            File.WriteAllText(dosyaAdi, ex.ToString());
        }

        public static void YeniParolaEpostasiYolla(string eposta, string parola)
        {
            SmtpClient sc = new SmtpClient();
            sc.Host = "mail.hesapadi.com";

            NetworkCredential crd = new NetworkCredential("hesap", "parola");
            sc.Credentials = crd;

            MailMessage msj = new MailMessage();
            msj.From = new MailAddress("gonderen@hesapadi.com");
            msj.To.Add(eposta);
            msj.Subject = "Parola Değişikliği...";
            msj.Body = "Yeni Parolanız: " + parola;

            try
            {
                sc.Send(msj);
            }
            catch (Exception ex)
            {
                HataKaydet(ex);
            }
        }

        public static string ParolaOlustur()
        {
            //Random r = new Random();
            //return r.Next(100,999).ToString();

            return "123";
        }
    }
}
