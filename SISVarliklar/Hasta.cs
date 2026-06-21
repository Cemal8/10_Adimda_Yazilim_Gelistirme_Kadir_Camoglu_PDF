using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVarliklar
{
    public class Hasta:Kisi
    {
        private DateTime dogumTarihi = DateTime.MinValue;
        private string cinsiyet = String.Empty;
        private string adres = String.Empty;


        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }

        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public override string GoruntuMetni
        {
            get
            {
                return string.Format("{0} {1} ({2})", base.Ad, base.Soyad, evTel);
            }
        }
    }
}
