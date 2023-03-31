using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemekhane_Kayıt_Programı
{
    public class Log
    {
        public Guid Id { get; set; } = new Guid();
        public int Tc_Kimlik { get; set; }
        
        public DateTime OlayTarihi { get; set; }
        public string FormName { get; set; }
        public string OlayBaslik { get; set; }
        public string  OlayAciklama { get; set; }
    }
}


