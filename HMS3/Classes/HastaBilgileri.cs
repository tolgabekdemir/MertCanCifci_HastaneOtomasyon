using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HMS3.Classes
{
    public class HastaBilgileri
    {
        [DisplayName("Hasta ID")]
        public string hastaId { get; set; }
        [DisplayName("Hasta Adı")]
        public string hastaAd { get; set; }
        [DisplayName("Tel. No")]
        public string hastaNo { get; set; }
        [DisplayName("Cinsiyet")]
        public string hastaCinsiyet { get; set; }
        [DisplayName("Adres")]
        public string hastaAdres { get; set; }
        [DisplayName("Ameliyat")]
        public string hastaAmeliyat { get; set; }


    }
    public class StsPerBilgileri
    {
        [DisplayName("Hasta ID")]
        public string hastaId { get; set; }
        [DisplayName("Hasta Adı")]
        public string hastaAd { get; set; }
        [DisplayName("Tel. No")]
        public string hastaNo { get; set; }
        [DisplayName("Cinsiyet")]
        public string hastaCinsiyet { get; set; }
        [DisplayName("Adres")]
        public string hastaAdres { get; set; }
        [DisplayName("Ameliyat")]
        public string hastaAmeliyat { get; set; }
        [DisplayName("Tarih")]
        public string tarih { get; set; }

        //[Browsable(false)]//gizlemeye yarar
        [DisplayName("Ameliyat Fiyatı")]
        public string fiyat { get; set; }


    }


    public class Hasta
    {
        public string HastaAdi { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
    }

    public class Doktor
    {
        public string  DoktorAdi { get; set; }
        public int DoktorID { get; set; }
    }
}
