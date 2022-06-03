using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Entity
{
   public class Yolcu
    {
        public int YolcuId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public int KoltukNo { get; set; }
        public int Fiyat { get; set; }
        public int YolId { get; set; }
        public Yol Yol { get; set; }
    }
}
