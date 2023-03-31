using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemekhane_Kayıt_Programı
{
    public class Kullanici
    {
        public string  tc_kimlik { get; set; }
        public string  adi { get; set; }
        public string soyadi { get; set; }
        public string kart_No { get; set; }
        public string sifre { get; set; }
        public Kullanici_Tipi kullanici_tipi { get; set; }

    }
    public enum Kullanici_Tipi
    {
        Ogrenci=1,
        Ogretmen=2,
        IdariPersonel=3
    }
}
