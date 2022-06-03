using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBileti.Entity
{
    public class Yol
    {
        public int YolId { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        public int Fiyat { get; set; }
        public List<Yolcu> Yolcular { get; set; }

    }
}
