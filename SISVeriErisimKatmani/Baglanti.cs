using System.Data;
using Microsoft.Data.SqlClient;

namespace SISVeriErisimKatmani
{
    public class Baglanti
    {
        private static readonly string baglantiMetni = @"Data Source=.\SQLEXPRESS;Initial Catalog=SIS;User ID=sa;Password=DbPass..;TrustServerCertificate=True;";        /// <summary>
                                                                                                                                                                         /// Yeni bir bağlantı oluşturularak yollanıyor.
                                                                                                                                                                         /// </summary>
        public static SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            return baglanti;
        }

      
        public static void BaglantiSonlandir(SqlConnection baglanti)
        {
            if (baglanti == null)
            {
                return;
            }

            if (baglanti.State != ConnectionState.Closed && baglanti.State != ConnectionState.Broken)
            {
                baglanti.Close();
            }

            baglanti.Dispose();
        }
    }
}