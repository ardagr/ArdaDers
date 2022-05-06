using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DersProje.Models.Entity
{
    public class OgrenciDers
    {

        public int OgrenciDersId { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public int DersId { get; set; }
        public Ders Dersler { get; set; }
    }
}
