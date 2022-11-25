using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS3.Classes
{ 
        public class KullaniciBilgileri
        {
            [DisplayName("Kullanıcı ID")]
            public string kullaniciId { get; set; }
            [DisplayName("Kullanıcı Tipi")]
            public string kullaniciTipi { get; set; }
            [DisplayName("KUllanıcı Adı")]
            public string kullaniciAdi { get; set; }
            [DisplayName("Şifre")]
            public string kullaniciSifre { get; set; }
        }
}
